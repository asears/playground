# PlayConsole Tests

## DevLog

When initializing a sample test project with dotnet new xunit, failure NU1108 since the project name should be specified.  The default name will collide with xunit's name.

```shell
  Determining projects to restore...
D:\projects\csharp\playground\xunit\xunit.csproj : error NU1108: Cycle detected. 
D:\projects\csharp\playground\xunit\xunit.csproj : error NU1108:   xunit -> xunit (>= 2.4.1).
  Failed to restore D:\projects\csharp\playground\xunit\xunit.csproj (in 202 ms).
```

With Roslynator global cli tool installed, was getting this error.

```shell
CSC : warning AD0001: Analyzer 'Roslynator.CodeAnalysis.CSharp.InvocationExpressionAnalyzer' threw an exception of type 'System.MissingMethodException' with message 'Method not found: 'Boolean Roslynator.DiagnosticsExtensions.IsAnalyzerSuppressed(Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext, Microsoft.CodeAnalysis.DiagnosticDescriptor)'.'. [D:\projects\csharp\playground\play.console\Play.World.csproj]
```
