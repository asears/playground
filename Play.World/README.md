# C# 6.0 Console app

Trying out some new features such as <https://devblogs.microsoft.com/dotnet/introducing-net-hot-reload/>.

See Properties - launchSettings.json

## DevLog

- Note that con and console are reserved words.  Don't use them in anything!
- The default dotnet new console command should require some additional mandatory parmeters.  See above.
- appsettings.json is currently showing EOF error in VSCode.  Appears to be a bug.
- Hot Reload doesn't seem to reload the text of the console output string when changed.
- .NET 5.0 SDK includes Microsoft.CodeAnalysis.NetAnalyzers by default, no need for a package.  There is also a nuget package.  It doesn't appear compatible with .NET 6.0.

## Initializing files

```shell
dotnet new gitignore
dotnet new -i Duotify.Templates.DotNetNew
dotnet new editorconfig
```

## Managing packages

```shell
dotnet add package Microsoft.Extensions.Hosting --prerelease
dotnet restore
dotnet list package
```

## Running

```shell
dotnet watch
```

## Resources

Naming Guidelines <https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines>

Console tricks <https://dev.to/krusty93/net-core-5-0-console-app-configuration-trick-and-tips-c1j>

Code Analysis <https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview>
