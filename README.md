# C# Banking App with Tests and Fluent Assertions Library

- dotnet new sln -o Banking
- cd Banking
- dotnet new console -o Application
- dotnet new classlib -o Library
- dotnet new xunit -o Application.Tests
- dotnet sln add Application/Application.csproj
- dotnet sln add Application.Tests/Application.Tests.csproj
- dotnet sln add Library/Library.csproj
- dotnet add Application/Application.csproj reference Library/Library.csproj
- dotnet add Application.Tests/Application.Tests.csproj reference Library/Library.csproj
- dotnet add Application.Tests/Application.Tests.csproj package FluentAssertions
- dotnet run --project Application
- dotnet test
