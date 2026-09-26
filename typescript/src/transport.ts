/** A file for a multipart request. */
export interface FilePart {
  fileName: string;
  content: Uint8Array;
}

/** What the generated operations need from a client. */
export interface HiokTransport {
  /** Encodes one path parameter; a key keeps its slashes ("dir/file.txt"). */
  segment(value: string, slashed?: boolean): string;
  /** Sends one request and parses the JSON answer (undefined when there is none). */
  call(method: string, path: string, body?: unknown, query?: Record<string, unknown>): Promise<any>;
  /** Sends one request and returns the raw body. */
  callRaw(method: string, path: string, body?: unknown, query?: Record<string, unknown>, headers?: Record<string, string>): Promise<Uint8Array>;
  /** Sends multipart/form-data. */
  callMultipart(method: string, path: string, form: Record<string, string>, files: Record<string, FilePart>, query?: Record<string, unknown>): Promise<any>;
}
