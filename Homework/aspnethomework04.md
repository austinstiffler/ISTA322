# ASP.NET Chapter 4 Homework
## Austin Stiffler
### 01 March, 2021


1. The .NET Core SDK includes a set of command-line tools for creating, managing, building, and running projects. Visual Studio provides integrated support for some of 
these tasks, but if you are using Visual Studio Code, then the command line is the only option.

1. 
	* **dotnet new console** is for creating a command-line application that can run on .NET Core.
	* **dotnet new mvc** is for creating an ASP.NET Core application with MVC Views and Controllers.
	* **dotnet new web** is for creating a blank ASP.NET Core application.

1. 
	* Creates a MySolution/MyProject folder that contains a global.json file, which specifies that the project will use .NET Core version 3.1.1.
	* Creates the project using the web template. The --no-https argument creates a project without support for HTTPS. The --framework argument selects the .NET Core 
	runtime that will be used for the project.
	* Creates a new solution named MySolution
	* References MySolution/MyProject
	
1. The *global.json* file specifies that the project will use a specific .NET Core version.

1. The app.UseStaticFiles() method enables static files to be served.

1. 
	* **dotnet build** builds a project.
	* **dotnet run** will run the project.
	
1. *Packages* contain compled code (as DLLs) along with other content needed in the projects that consume these packages.

1. *Tool packages* install commands that can be used from the command line to perform operations on .NET Core projects.

1. *Tool packages* install commands that can be used from the command line to perform operations on .NET Core projects.

1. *Client-side packages* contain content that is delivered to the client, such as images, CSS stylesheets, JavaScript files, and static HTML.

1. 
	* Use a debugger.
	* Add System.Console.WriteLine commands to code to figure out what's going on.