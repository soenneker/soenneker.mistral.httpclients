[![](https://img.shields.io/nuget/v/soenneker.mistral.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.mistral.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.mistral.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.mistral.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.mistral.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.mistral.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.mistral.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.mistral.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Mistral.HttpClients

Provides a cached, authenticated `HttpClient` for the Mistral API.

## Installation

```bash
dotnet add package Soenneker.Mistral.HttpClients
```

## Configuration

```json
{
  "Mistral": {
    "ApiKey": "your-api-key"
  }
}
```

`Mistral:ClientBaseUrl` can override the default `https://api.mistral.ai` endpoint. `Mistral:AuthHeaderName` and `Mistral:AuthHeaderValueTemplate` can override the default `Authorization: Bearer {token}` header.

## Usage

```csharp
using Soenneker.Mistral.HttpClients.Abstract;
using Soenneker.Mistral.HttpClients.Registrars;

services.AddMistralOpenApiHttpClientAsSingleton();

IMistralOpenApiHttpClient mistral = serviceProvider
    .GetRequiredService<IMistralOpenApiHttpClient>();

HttpClient client = await mistral.Get(cancellationToken);
```

Do not dispose the returned `HttpClient`; the registered provider owns it. Disposing the provider removes the cached client.
