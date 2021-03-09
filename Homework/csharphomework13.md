# C# Homework Chapter 13
## Austin Stiffler
### 23 February, 2021


1. An *interface* does not contain any code or data; it just specifies the methods and properties that a class that inherits from the interface must provide.

1. You define an interface by using the *interface* keyword.

1. An interface cannot hold any data; you cannot add fields (not even private ones) to an interface.

1. Define a method interface by including a return type, the name of the method, a parameter, and the semicolon..

1. Yes.

1. Yes.

1. 
	* An object can inherit from multiple interfaces.
	* A class can have at most one base class, but it is allowed to implement an unlimited number of
 interfaces. A class must implement all the methods declared by these interfaces.
 
1. When you *explicitly* implement an interface, the methods defined by the interface are available only by creating a reference to that interface.

1. 
	* You’re not allowed to define any fields in an interface, not even static fields. A field is an implementation detail of a class or structure.
	* You’re not allowed to define any constructors in an interface. A constructor is also considered to be an implementation detail of a class or structure.
	* You’re not allowed to define a destructor in an interface. A destructor contains the statements used to destroy an object instance. 
	* You cannot specify an access modifier for any method. All methods in an interface are implicitly public.
	* You cannot nest any types (such as enumerations, structures, classes, or interfaces) inside an interface.
	* An interface is not allowed to inherit from a structure or a class, although an interface can inherit from another interface. Structures and classes contain 
implementation; if an interface were allowed to inherit from either, it would be inheriting some implementation.

1. An abstract class can contain implementation. An interface may not.

1. An abstract method is similar to a virtual method, except it does not contain a body. A derived class must override it. It also cannot be private.

1. A *sealed* class cannot be used as a base class, therefore cannot be inherited from; using the *sealed* keyword.

1. You would use a *sealed* method in an *unsealed* class. This would mean that a derived class cannot override this method.