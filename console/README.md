# C# 6.0 Console app with hotreload

Trying out some new features.

Add LaunchSettings.

```json
{
    "profiles": {
      "playground": {
        "commandName": "playground",
        "hotReloadProfile": "net60"
      }
    }
  }
```

## Console tricks

<https://dev.to/krusty93/net-core-5-0-console-app-configuration-trick-and-tips-c1j>

```shell
dotnet add package Microsoft.Extensions.Hosting --prerelease
```
