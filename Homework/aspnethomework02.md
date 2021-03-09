# ASP.NET Chapter 2 Homework
## Austin Stiffler
### 22 February, 2021

1. *Visual Studio* is a full-featured development environment. *VSCode* is a cross-platform editor that can be extended with plugins to your needs.

1. *LocalDB* is a Windows-only feature provided by SQL Server that is not available on other platforms.

1. The first command creates a folder named FirstProject and adds to it a file named global.json, which specifies the version
of .NET Core that the project will use; this ensures you get the expected results when following the examples. The second command
creates a new ASP.NET Core project.

1. 
	* *dotnet new mvc* will build an ASP.NET project from the command line.
	* *dotnet run* will run the project.
	
1. An *endpoint* handles the incoming requests in an ASP.NET application.

1. A *controller* is a C# class that is derived from the Microsoft.AspNetCore.Mvc.Controller class, the built-in controller base class.

1. *Actions* are defined in a *controller*.

1. The ASP.NET Core *routing system* is responsible for selecting the endpoint that will handle an HTTP request.

1. 
	* /
	* /Home
	* /Home/Index
	
1. The *ViewResult* object instructs ASP.NET Core to *render* a view.

1. All public methods of the *controller* class are called *action methods*.

1. A *view model* is the data provided by *action methods* to views, by passing arguments to the View method.