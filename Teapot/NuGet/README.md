

Create package:

    Make sure nuget.exe is present inside the NuGet directory of the Teapot library;
    Open Developer Command Prompt and navigate to the NuGet directory;
    Run command 'nuget pack Teapot.nuspec'.

Publish package:

    Open Developer Command Prompt and navigate to the NuGet directory;
    Run command 'nuget push Teapot.AspNetCore.nupkg <API_KEY> -src https://www.nuget.org/packages/Teapot.AspNetCore/'

