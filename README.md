# Dependency Demo
Visual Studio does not properly resolve transient package dependencies in a specific scenario, demonstrated by this solution:

1. You have a .Net Standard class library project which references a nuget package
2. You have a .Net Framework project, which is using the *legacy* .csproj file format, and references the .Net Standard class library

To view the behavior, launch `OldConsoleApp` from Visual studio. You should see an exception:

    System.IO.FileNotFoundException: 'Could not load file or assembly 'Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed' or one of its dependencies. The system cannot find the file specified.'

By contrast, `NewConsoleApp` is defined using the new .csproj file format. When run, it properly loads the dependent package assemblies.

Also note, `OldConsoleApp` is unable to directly reference Newtonsoft.Json. If you attempt to reference the package you receive a compiler warning. `NewConsoleApp` does not experience this issue, and compiles just fine with references to Newtonsot.Json.
