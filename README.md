# Rotativa.AspNetCore

Rotativa for Asp.Net Core.

Docs are in the making. Should work almost exactly as Rotativa https://github.com/webgio/Rotativa

## Development version
This is the first version of Rotativa for Asp.Net Core.

Install with nuget.org:

https://www.nuget.org/packages/Rotativa.AspNetCore


Please give feedback!

## Needs configuration
Basic configuration done in Startup.cs:

```csharp
RotativaConfiguration.Setup(env);
```

### Windows 
Make sure you have a folder with the wkhtmltopdf.exe file accessible by the process running the web app. By default it searches in a folder named "Rotativa" in the root of the web app ("wwwroot/Rotativa"). If you need to change that use the optional parameter to the Setup call `RotativaConfiguration.Setup(env, "path/relative/to/root")`

### Linux
To run Rotary on Linux platforms, you need to install wkhtmltopdf. Some guides:

- [Ubuntu](https://gist.github.com/brunogaspar/bd89079245923c04be6b0f92af431c10)
- [CentOS 7](https://gist.github.com/calebbrewer/aca424fb14618df8aadd)