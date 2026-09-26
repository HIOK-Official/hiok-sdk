#!/usr/bin/env python3
"""
Generate the operation layer of every HIOK SDK from the API's own OpenAPI document.

    python3 hiok-sdk/generator/generate.py                         # from http://localhost:5001
    python3 hiok-sdk/generator/generate.py --spec swagger.json     # from a saved document

The API has ~840 operations in ~90 groups. Written by hand in five languages they
would drift the week after they were written, so each SDK is a small hand-written
core (authentication, retries, errors, file transfer) plus this generated layer:
one class per API group, one method per operation, named from the operationId.

Emits:
  python/src/hiok/_generated.py
  dotnet/Hiok.Cloud/Generated.cs
  java/src/main/java/com/hiokcloud/api/*.java  (one file per group + Api.java)
  typescript/src/generated.ts
  go/generated.go
  operations.json   (the same data, for the documentation page)
"""
from __future__ import annotations

import argparse
import json
import re
import shutil
import sys
import urllib.request
from dataclasses import dataclass, field
from pathlib import Path

ROOT = Path(__file__).resolve().parent.parent
VERBS = ("GET", "POST", "PUT", "PATCH", "DELETE", "HEAD", "OPTIONS")
# Trailing path parameters that carry a path of their own ("docs/2026/report.csv").
SLASHED = {"key", "path", "blobname", "repositoryname", "filepath", "filename", "prefix"}


# ── model ─────────────────────────────────────────────────────────────────────

@dataclass
class Param:
    name: str          # as the API spells it
    ident: str         # safe identifier (camelCase)
    required: bool
    kind: str          # "path" | "query"
    slashed: bool = False
    array: bool = False


@dataclass
class Op:
    group: str
    name: str          # PascalCase method base, unique in its group
    http: str
    path: str
    summary: str
    path_params: list[Param] = field(default_factory=list)
    query_params: list[Param] = field(default_factory=list)
    body: str | None = None   # None | "json" | "multipart"
    body_required: bool = False
    deprecated: bool = False


def pascal(text: str) -> str:
    parts = re.split(r"[^0-9A-Za-z]+", text)
    out = "".join(p[:1].upper() + p[1:] for p in parts if p)
    return out if out and not out[0].isdigit() else "N" + out


def camel(text: str) -> str:
    p = pascal(text)
    return p[:1].lower() + p[1:]


def snake(text: str) -> str:
    # A plural acronym is one word: VMs -> vms, IPs -> ips (not v_ms, i_ps).
    text = re.sub(r"([A-Z]{2,})s(?=[A-Z0-9]|$)", lambda m: m.group(1).capitalize() + "s", text)
    s = re.sub(r"[^0-9A-Za-z]+", "_", text)
    s = re.sub(r"([a-z0-9])([A-Z])", r"\1_\2", s)
    s = re.sub(r"([A-Z]+)([A-Z][a-z])", r"\1_\2", s)
    s = s.strip("_").lower()
    return s if s and not s[0].isdigit() else "n_" + s


RESERVED = {
    "python": {"from", "import", "class", "def", "global", "type", "id", "in", "is", "lambda", "pass", "return", "async", "await", "format", "filter", "list", "range", "object", "input", "open", "self", "body", "query", "files", "form"},
    "csharp": {"object", "string", "class", "namespace", "operator", "params", "base", "event", "ref", "out", "in", "is", "as", "lock", "checked", "fixed", "internal", "body", "query", "files", "form", "ct", "default", "static", "new", "this"},
    "java": {"c", "query_", "class", "package", "import", "default", "new", "this", "static", "final", "interface", "enum", "switch", "case", "public", "private", "protected", "native", "body", "query", "files", "form", "goto", "const", "int", "long", "char", "byte", "short", "boolean", "double", "float", "void", "throws", "throw", "try", "catch", "finally", "return", "abstract", "assert", "break", "continue", "do", "else", "extends", "for", "if", "implements", "instanceof", "strictfp", "super", "synchronized", "transient", "volatile", "while", "var", "record", "yield", "sealed", "permits"},
    "ts": {"delete", "new", "class", "default", "function", "var", "let", "const", "in", "of", "typeof", "instanceof", "void", "with", "yield", "enum", "export", "import", "package", "private", "protected", "public", "static", "interface", "body", "query", "files", "form", "options", "this", "super", "switch", "case", "return", "throw", "try", "catch"},
    "go": {"a", "type", "func", "var", "const", "package", "import", "map", "chan", "go", "range", "select", "struct", "switch", "case", "default", "defer", "fallthrough", "goto", "interface", "return", "break", "continue", "for", "if", "else", "body", "query", "files", "form", "ctx", "c", "string", "len", "new", "make", "error", "id"},
}


def safe(name: str, lang: str) -> str:
    return name + "_" if name in RESERVED[lang] else name


import keyword as _kw

METHOD_RESERVED = {
    "python": set(_kw.kwlist) | {"request", "request_multipart"},
    "csharp": set(),                     # methods end in Async
    "java": RESERVED["java"] - {"body", "query", "files", "form"},
    "ts": (RESERVED["ts"] - {"body", "query", "files", "form", "options"}) | {"constructor"},
    "go": set(),                         # exported names are capitalised
}


def method(name: str, lang: str) -> str:
    return name + "_" if name in METHOD_RESERVED[lang] else name


def load(source: str) -> dict:
    if source.startswith("http"):
        with urllib.request.urlopen(source, timeout=60) as r:
            return json.load(r)
    return json.loads(Path(source).read_text())


def collect(spec: dict) -> list[Op]:
    ops: list[Op] = []
    taken: dict[str, set[str]] = {}
    for path, item in spec["paths"].items():
        for http, raw in item.items():
            if http.upper() not in VERBS:
                continue
            group = pascal((raw.get("tags") or ["General"])[0])
            base = raw.get("operationId") or f"{http}_{path}"
            base = re.sub(r"_(GET|POST|PUT|PATCH|DELETE|HEAD|OPTIONS)$", "", base)
            name = pascal(base)
            used = taken.setdefault(group, set())
            if name in used:
                name = name + pascal(http.lower())
            n = 2
            while name in used:
                name, n = f"{name}{n}", n + 1
            used.add(name)

            names_in_path = re.findall(r"{([^}]+)}", path)
            params = {p["name"]: p for p in raw.get("parameters", []) + item.get("parameters", [])}
            op = Op(group=group, name=name, http=http.upper(), path=path,
                    summary=" ".join((raw.get("summary") or raw.get("description") or "").split())[:300],
                    deprecated=bool(raw.get("deprecated")))
            for i, pname in enumerate(names_in_path):
                op.path_params.append(Param(pname, camel(pname), True, "path",
                                            slashed=(i == len(names_in_path) - 1 and pname.lower() in SLASHED)))
            for pname, p in params.items():
                if p.get("in") != "query":
                    continue
                schema = p.get("schema") or {}
                op.query_params.append(Param(pname, camel(pname), bool(p.get("required")), "query",
                                             array=schema.get("type") == "array"))
            body = raw.get("requestBody")
            if body:
                content = body.get("content", {})
                op.body = "multipart" if "multipart/form-data" in content and not any("json" in c for c in content) else "json"
                op.body_required = bool(body.get("required"))
            ops.append(op)
    ops.sort(key=lambda o: (o.group, o.name))
    return ops


def by_group(ops: list[Op]) -> dict[str, list[Op]]:
    groups: dict[str, list[Op]] = {}
    for op in ops:
        groups.setdefault(op.group, []).append(op)
    return groups


def unique_idents(op: Op, lang: str, style) -> dict[str, str]:
    """Identifier per parameter, unique within the method."""
    seen: set[str] = set()
    out = {}
    for p in op.path_params + op.query_params:
        ident = safe(style(p.name), lang)
        while ident in seen:
            ident += "_" if lang == "python" else "2"
        seen.add(ident)
        out[id(p)] = ident
    return out


def doc_line(op: Op) -> str:
    text = op.summary or pascal_words(op.name) + "."
    return text.replace("*/", "* /").replace(chr(34) * 3, "'")


def pascal_words(name: str) -> str:
    words = re.sub(r"([a-z0-9])([A-Z])", r"\1 \2", name).split()
    return " ".join([words[0]] + [w.lower() for w in words[1:]]) if words else name


# ── Python ────────────────────────────────────────────────────────────────────

def emit_python(ops: list[Op]) -> str:
    out = ['"""Generated from the HIOK API\'s OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py."""',
           "from __future__ import annotations", "", "from typing import Any, TYPE_CHECKING", "",
           "if TYPE_CHECKING:", "    from .client import HiokClient", ""]
    groups = by_group(ops)
    for group, items in groups.items():
        out += ["", f"class {group}Api:", f'    """{group} operations."""', "",
                "    def __init__(self, client: \"HiokClient\"):", "        self._c = client"]
        for op in items:
            ids = unique_idents(op, "python", snake)
            args = ["self"]
            args += [ids[id(p)] + ": str" for p in op.path_params]
            if op.body == "json":
                args.append("body: Any" + ("" if op.body_required else " = None"))
            if op.body == "multipart":
                args += ["form: dict[str, Any] | None = None", "files: dict[str, tuple[str, bytes]] | None = None"]
            kw = [f"{ids[id(p)]}: Any = None" for p in op.query_params]
            sig = ", ".join(args + (["*"] + kw if kw else []))
            path = op.path
            fmt = []
            for p in op.path_params:
                path = path.replace("{" + p.name + "}", "{" + ids[id(p)] + "}")
            path_expr = "f" + json.dumps(path).replace("{", "{self._c._seg(").replace("}", ")}") if op.path_params else json.dumps(path)
            if op.path_params:
                # _seg(value, slashed)
                path_expr = json.dumps(op.path)
                for p in op.path_params:
                    path_expr = path_expr.replace("{" + p.name + "}", "\" + self._c._seg(" + ids[id(p)] + (", True" if p.slashed else "") + ") + \"")
                path_expr = path_expr.replace(' + ""', "").replace('"" + ', "")
            query = "{" + ", ".join(f'"{p.name}": {ids[id(p)]}' for p in op.query_params) + "}" if op.query_params else "None"
            name = method(snake(op.name), "python")
            out += ["", f"    def {name}({sig}) -> Any:", f'        """{doc_line(op)}  [{op.http} {op.path}]"""']
            if op.body == "multipart":
                out.append(f"        return self._c.request_multipart({json.dumps(op.http)}, {path_expr}, form or {{}}, files or {{}}, query={query})")
            else:
                body = "body" if op.body == "json" else "None"
                out.append(f"        return self._c.request({json.dumps(op.http)}, {path_expr}, {body}, query={query})")
    out += ["", "", "class Api:", '    """Every API operation, grouped as the API groups them: client.api.<group>.<operation>()."""', "",
            "    def __init__(self, client: \"HiokClient\"):"]
    for group in groups:
        out.append(f"        self.{snake(group)} = {group}Api(client)")
    return "\n".join(out) + "\n"


# ── C# ────────────────────────────────────────────────────────────────────────

def cs_escape(s: str) -> str:
    return s.replace("&", "&amp;").replace("<", "&lt;").replace(">", "&gt;")


def emit_csharp(ops: list[Op]) -> str:
    out = ["// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.",
           "#nullable enable", "using System.Collections.Generic;", "using System.Net.Http;", "using System.Text.Json.Nodes;",
           "using System.Threading;", "using System.Threading.Tasks;", "", "namespace Hiok.Cloud;", ""]
    groups = by_group(ops)
    out += ["/// <summary>Every API operation, grouped as the API groups them: <c>client.Api.&lt;Group&gt;.&lt;Operation&gt;Async()</c>.</summary>",
            "public sealed partial class HiokApi", "{"]
    for group in groups:
        out.append(f"    public {group}Api {group} {{ get; }}")
    out += ["", "    internal HiokApi(HiokClient client)", "    {"]
    for group in groups:
        out.append(f"        {group} = new {group}Api(client);")
    out += ["    }", "}", ""]
    for group, items in groups.items():
        out += [f"/// <summary>{group} operations.</summary>", f"public sealed partial class {group}Api", "{",
                "    private readonly HiokClient _c;", f"    internal {group}Api(HiokClient client) => _c = client;"]
        for op in items:
            ids = unique_idents(op, "csharp", camel)
            args = [f"string {ids[id(p)]}" for p in op.path_params]
            if op.body == "json":
                args.append("object? body" + ("" if op.body_required else " = null"))
            if op.body == "multipart":
                args += ["IDictionary<string, string>? form = null", "IDictionary<string, (string FileName, byte[] Content)>? files = null"]
            args += [f"object? {ids[id(p)]} = null" for p in op.query_params]
            args.append("CancellationToken ct = default")
            path_expr = '"' + op.path + '"'
            for p in op.path_params:
                path_expr = path_expr.replace("{" + p.name + "}", '" + HiokClient.Segment(' + ids[id(p)] + (", true" if p.slashed else "") + ') + "')
            path_expr = path_expr.replace(' + ""', "").replace('"" + ', "")
            query = ("new Dictionary<string, object?> { " + ", ".join(f'["{p.name}"] = {ids[id(p)]}' for p in op.query_params) + " }") if op.query_params else "null"
            out += ["", f"    /// <summary>{cs_escape(doc_line(op))} <c>[{op.http} {cs_escape(op.path)}]</c></summary>"]
            if op.deprecated:
                out.append("    [System.Obsolete]")
            out.append(f"    public Task<JsonNode?> {op.name}Async({', '.join(args)})")
            if op.body == "multipart":
                out.append(f"        => _c.InvokeMultipartAsync(HttpMethod.{op.http.title()}, {path_expr}, form, files, {query}, ct);")
            else:
                out.append(f"        => _c.InvokeAsync(new HttpMethod(\"{op.http}\"), {path_expr}, {'body' if op.body == 'json' else 'null'}, {query}, ct);")
        out += ["}", ""]
    return "\n".join(out)


# ── Java ──────────────────────────────────────────────────────────────────────

def emit_java(ops: list[Op], dest: Path) -> int:
    if dest.exists():
        shutil.rmtree(dest)
    dest.mkdir(parents=True)
    groups = by_group(ops)
    header = "// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.\npackage com.hiokcloud.api;\n\n"
    for group, items in groups.items():
        lines = [header + "import com.hiokcloud.HiokClient;\nimport com.fasterxml.jackson.databind.JsonNode;\nimport java.util.LinkedHashMap;\nimport java.util.Map;\n",
                 f"/** {group} operations. */", f"public final class {group}Api {{", "    private final HiokClient c;",
                 f"    public {group}Api(HiokClient client) {{ this.c = client; }}"]
        for op in items:
            ids = unique_idents(op, "java", camel)
            args = [f"String {ids[id(p)]}" for p in op.path_params]
            if op.body == "json":
                args.append("Object body")
            if op.body == "multipart":
                args += ["Map<String, String> form", "Map<String, HiokClient.FilePart> files"]
            full = args + [f"Object {ids[id(p)]}" for p in op.query_params]
            path_expr = '"' + op.path + '"'
            for p in op.path_params:
                path_expr = path_expr.replace("{" + p.name + "}", '" + HiokClient.segment(' + ids[id(p)] + (", true" if p.slashed else "") + ') + "')
            path_expr = path_expr.replace(' + ""', "").replace('"" + ', "")
            lines.append("")
            lines.append(f"    /** {doc_line(op).replace('@', '{@literal @}')} [{op.http} {op.path}] */")
            if op.deprecated:
                lines.append("    @Deprecated")
            lines.append(f"    public JsonNode {method(camel(op.name), 'java')}({', '.join(full)}) {{")
            if op.query_params:
                lines.append("        Map<String, Object> query_ = new LinkedHashMap<>();")
                for p in op.query_params:
                    lines.append(f'        query_.put("{p.name}", {ids[id(p)]});')
            q = "query_" if op.query_params else "null"
            if op.body == "multipart":
                lines.append(f'        return c.sendMultipart("{op.http}", {path_expr}, form, files, {q});')
            else:
                lines.append(f'        return c.send("{op.http}", {path_expr}, {"body" if op.body == "json" else "null"}, {q});')
            lines.append("    }")
            # Convenience overload without the optional query parameters.
            if op.query_params and not any(p.required for p in op.query_params):
                lines.append(f"    public JsonNode {method(camel(op.name), 'java')}({', '.join(args)}) {{")
                call = ", ".join([ids[id(p)] for p in op.path_params] + (["body"] if op.body == "json" else []) +
                                 (["form", "files"] if op.body == "multipart" else []) + ["null"] * len(op.query_params))
                lines.append(f"        return {method(camel(op.name), 'java')}({call});")
                lines.append("    }")
        lines.append("}")
        (dest / f"{group}Api.java").write_text("\n".join(lines) + "\n")
    api = [header + "import com.hiokcloud.HiokClient;\n",
           "/** Every API operation, grouped as the API groups them: {@code client.api().<group>().<operation>()}. */",
           "public final class Api {"]
    for group in groups:
        api.append(f"    private final {group}Api {camel(group)};")
    api.append("    public Api(HiokClient client) {")
    for group in groups:
        api.append(f"        this.{camel(group)} = new {group}Api(client);")
    api.append("    }")
    for group in groups:
        api.append(f"    public {group}Api {camel(group)}() {{ return {camel(group)}; }}")
    api.append("}")
    (dest / "Api.java").write_text("\n".join(api) + "\n")
    return len(groups) + 1


# ── TypeScript ────────────────────────────────────────────────────────────────

def emit_typescript(ops: list[Op]) -> str:
    out = ["// Generated from the HIOK API's OpenAPI document. Do not edit: run hiok-sdk/generator/generate.py.",
           "import type { HiokTransport, FilePart } from './transport.js';", ""]
    groups = by_group(ops)
    for group, items in groups.items():
        out += [f"/** {group} operations. */", f"export class {group}Api {{", "  constructor(private readonly c: HiokTransport) {}"]
        for op in items:
            ids = unique_idents(op, "ts", camel)
            args = [f"{ids[id(p)]}: string" for p in op.path_params]
            if op.body == "json":
                args.append("body" + ("" if op.body_required else "?") + ": unknown")
            if op.body == "multipart":
                args += ["form: Record<string, string> = {}", "files: Record<string, FilePart> = {}"]
            if op.query_params:
                fields = "; ".join(f"{json.dumps(p.name)}?: unknown" for p in op.query_params)
                args.append(f"query: {{ {fields} }} = {{}}")
            path_expr = "`" + op.path + "`"
            for p in op.path_params:
                path_expr = path_expr.replace("{" + p.name + "}", "${this.c.segment(" + ids[id(p)] + (", true" if p.slashed else "") + ")}")
            q = "query" if op.query_params else "undefined"
            out += ["", f"  /** {doc_line(op)} `[{op.http} {op.path}]` */" + ("\n  /** @deprecated */" if op.deprecated else ""),
                    f"  {method(camel(op.name), 'ts')}({', '.join(args)}): Promise<any> {{"]
            if op.body == "multipart":
                out.append(f"    return this.c.callMultipart('{op.http}', {path_expr}, form, files, {q});")
            else:
                out.append(f"    return this.c.call('{op.http}', {path_expr}, {'body' if op.body == 'json' else 'undefined'}, {q});")
            out.append("  }")
        out += ["}", ""]
    out += ["/** Every API operation, grouped as the API groups them: `client.api.<group>.<operation>()`. */", "export class Api {"]
    for group in groups:
        out.append(f"  readonly {camel(group)}: {group}Api;")
    out.append("  constructor(c: HiokTransport) {")
    for group in groups:
        out.append(f"    this.{camel(group)} = new {group}Api(c);")
    out += ["  }", "}", ""]
    return "\n".join(out)


# ── Go ────────────────────────────────────────────────────────────────────────

def emit_go(ops: list[Op]) -> str:
    out = ["// Code generated from the HIOK API's OpenAPI document by hiok-sdk/generator/generate.py. DO NOT EDIT.", "",
           "package hiok", "", "import (", '\t"context"', '\t"encoding/json"', ")", "",
           "// Api holds every API operation, grouped as the API groups them: client.API().<Group>.<Operation>(ctx, ...).",
           "type Api struct {"]
    groups = by_group(ops)
    for group in groups:
        out.append(f"\t{group} *{group}Api")
    out += ["}", "", "func newAPI(c *Client) *Api {", "\treturn &Api{"]
    for group in groups:
        out.append(f"\t\t{group}: &{group}Api{{c: c}},")
    out += ["\t}", "}", ""]
    for group, items in groups.items():
        out += [f"// {group}Api holds the {group} operations.", f"type {group}Api struct{{ c *Client }}", ""]
        for op in items:
            ids = unique_idents(op, "go", camel)
            args = ["ctx context.Context"] + [f"{ids[id(p)]} string" for p in op.path_params]
            if op.body == "json":
                args.append("body any")
            if op.body == "multipart":
                args += ["form map[string]string", "files map[string]FilePart"]
            if op.query_params:
                args.append("query Query")
            path_expr = '"' + op.path + '"'
            for p in op.path_params:
                path_expr = path_expr.replace("{" + p.name + "}", '" + segment(' + ids[id(p)] + (", true" if p.slashed else ", false") + ') + "')
            path_expr = path_expr.replace(' + ""', "").replace('"" + ', "")
            q = "query" if op.query_params else "nil"
            qdoc = (" Query keys: " + ", ".join(p.name for p in op.query_params) + ".") if op.query_params else ""
            out.append(f"// {op.name} — {doc_line(op)} [{op.http} {op.path}].{qdoc}")
            if op.deprecated:
                out.append("//\n// Deprecated: the API marks this operation deprecated.")
            out.append(f"func (a *{group}Api) {op.name}({', '.join(args)}) (json.RawMessage, error) {{")
            if op.body == "multipart":
                out.append(f'\treturn a.c.CallMultipart(ctx, "{op.http}", {path_expr}, form, files, {q})')
            else:
                out.append(f'\treturn a.c.Call(ctx, "{op.http}", {path_expr}, {"body" if op.body == "json" else "nil"}, {q})')
            out += ["}", ""]
    return "\n".join(out)


# ── operations.json (docs) ────────────────────────────────────────────────────

def emit_index(ops: list[Op]) -> str:
    return json.dumps([{
        "group": o.group, "name": o.name, "http": o.http, "path": o.path, "summary": o.summary,
        "python": f"client.api.{snake(o.group)}.{method(snake(o.name), 'python')}()",
        "dotnet": f"client.Api.{o.group}.{o.name}Async()",
        "java": f"client.api().{camel(o.group)}().{method(camel(o.name), 'java')}()",
        "typescript": f"client.api.{camel(o.group)}.{method(camel(o.name), 'ts')}()",
        "go": f"client.API().{o.group}.{o.name}(ctx)",
    } for o in ops], indent=1)


def main() -> int:
    ap = argparse.ArgumentParser()
    ap.add_argument("--spec", default="http://localhost:5001/swagger/v1/swagger.json")
    args = ap.parse_args()
    ops = collect(load(args.spec))
    (ROOT / "python/src/hiok/_generated.py").write_text(emit_python(ops))
    (ROOT / "dotnet/Hiok.Cloud/Generated.cs").write_text(emit_csharp(ops))
    java_files = emit_java(ops, ROOT / "java/src/main/java/com/hiokcloud/api")
    (ROOT / "typescript/src/generated.ts").write_text(emit_typescript(ops))
    (ROOT / "go/generated.go").write_text(emit_go(ops))
    gofmt = shutil.which("gofmt") or str(Path.home() / ".go/bin/gofmt")
    if Path(gofmt).exists():
        import subprocess
        subprocess.run([gofmt, "-w", str(ROOT / "go/generated.go")], check=False)
    (ROOT / "operations.json").write_text(emit_index(ops))
    groups = len(by_group(ops))
    print(f"{len(ops)} operations in {groups} groups → python, dotnet, java ({java_files} files), typescript, go")
    return 0


if __name__ == "__main__":
    sys.exit(main())
