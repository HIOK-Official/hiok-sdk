# HIOK Cloud SDKs

Official source SDKs for HIOK Cloud.

- [TypeScript](typescript/) — browser or Node.js
- [Python](python/) — Python 3.10+
- [Go](go/) — Go 1.23+
- [.NET](dotnet/) — .NET 10+

All SDKs use the same REST API and support either a bearer token or email/password sign-in. Tokens and passwords must come from environment variables or a secret manager, never source control.

## API endpoint

Production: `https://hiokcloud.com`

For a private deployment, pass its base URL to the client constructor.

## Current surface

The public preview includes authentication, generic authenticated requests, VM listing/creation, regions, resource search, hierarchy, and billing. Resource-specific helpers will grow without removing the generic request escape hatch.

## Security

Report vulnerabilities privately to `security@hiokcloud.com`.
