# ASP.NET Chapter 3 Homework
## Austin Stiffler
### 28 February, 2021


1. The data model is the most important part of any ASP.NET Core 3 application.

1. The *domain model* contains the C# objects (known as domain objects) that make up the universe of the application and the methods that manipulate them.

1. Model classes are defined in a folder named *Models*.

1. A single controller class can define multiple action methods.

1. A *tag helper* tells Razor to insert a URL for an action method defined by the same controller for which the current view is being rendered.

1. The *asp-action* attribute is an instruction to add an href attribute to the a element that contains a URL for an action method.

1. 
	* A GET request is what a browser issues normally each time someone clicks a link.  This version of the action will be responsible for displaying the initial blank form when
someone first visits /Home/RsvpForm.
	*  By default, forms rendered using Html.BeginForm() are submitted by the browser as a POST request. This version of the action will be responsible for receiving
submitted data and deciding what to do with it.

1. *Model binding* is a useful ASP.NET Core feature whereby incoming data is parsed and the key/value pairs in the HTTP request are used to populate properties of domain model types.

1. 
	* We should validate user data because without validating the data, users could could potentially not enter correct information.
	* Validation rules are defined by applying attributes to model classes, which means the same validation rules can be applied in any form that uses that class.
	
1. The ModelState.IsValid property will check to see whether there has been a validation problem in the form data.

1. The *asp-validation-summary* attribute is applied to a div element, and it displays a list of validation errors when the view is rendered.

1. wwwroot/css

1. *Bootstrap* is a good CSS framework originally developed by Twitter that has become a major open source project and a mainstay of web application development.
It contains CSS- and (optionally) JavaScript-based design templates for typography, forms, buttons, navigation, and other interface components.