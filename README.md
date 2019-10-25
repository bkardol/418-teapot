Welcome to the Teapot repository!

[![NuGet Downloads](https://img.shields.io/nuget/dt/Teapot.AspNetCore.svg)](https://www.nuget.org/packages/Teapot.AspNetCore/)

# Info
This is a simple library including a 'teapot' endpoint with a 'brewcoffee' method.

The [Hyper Text Coffee Pot Control Protocol (HTCPCP/1.0)](https://tools.ietf.org/html/rfc2324#section-2.3.2) states the following: 

`Any attempt to brew coffee with a teapot should result in the error
   code "418 I'm a teapot". The resulting entity body MAY be short and
   stout.`.

I hear you think, what is the use of this random teapot/brewcoffee endpoint if you're not creating an API for a controllable teapot? Well, you might want to:
  - check whether your API is up and running;
  - start your application afer deploying it;
  - prevent application pool recycling;
  - hide an easter egg (that is how this status code was [born](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/418) after all).
  
This repository also contains the Teapot.API project, demonstrating the purpose of the library.

# Quick-Start
All you need to do is install the library from [NuGet](https://www.nuget.org/packages/Teapot.AspNetCore/) into your .NET Core 3 API project and it automagically works!

# Suggestions?
Please create an issue or contact me in case of any issues or suggestions.