# C# Chapter 15 Homework
## Austin Stiffler
### 24 February, 2021


1. A property may look like a field, but it acts like a mthod. The compiler automatically tranaslates properties into calls to accessor methods.

1. Methods are explicitly called, whereas properties work on compile and runtime implicitly.

1. *Encapsulation* bundles data into a single unit, and keeps data safe from outside interference.

1. I think that in a case sensitive language it is enough to distinguish between different identifiers; especially in C# where you can easily hover over
an identifier and find out what it is. I also think it could potentially lead to more errors being made, but not difficult to be fixed either.

1. 
	* You may use read-only property for information like customer information.
	* You may use a write-only property for something like a password, so it cannot be read by others.
	
1. Logs or password is a good example.

1. 
	* You can assign a value through a property of a structure or class only after the structure or class has been initialized. 
	* You can'tt use a property as a ref or an out argument to a method.
	* A property can contain at most one get accessor and one set accessor. A property cannot contain other methods, fields, or properties.
	* The get and set accessors cannot take any parameters. The data being assigned is passed to the set accessor automatically by using the value variable.
	* You can't declar properties by using const.
	
1. Invoking an *bject initializer* causes the C# compiler to generate code that calls the default constructor and then calls the set accessor of each named
property to initialize it with the value specified. 
Syntax: a = 42;
a.set(42);
var WhatAmI = { Name: "Joe", Age = 101, IQ = 123.456 }; 