#### C# Chapter 17 Homework
#### Austin Stiffler
#### 09 March, 2021
---
1. A *type parameter* specifies the type of object that a generic class or method operates. You indicate that a class is a generic class by providing a *type parameter* in angle brackets.

1. A *type parameter* specializes a class.

1. A generic class can have multiple type parameters; there is no specific limit.

1. A generic class that uses type parameters is different from a generalized
class designed to take parameters that can be cast to different types.

1. 
    * By using a *constraint*, you can limit the type parameters of a generic class to those that implement a particular set of interfaces and therefore provide the methods defined by those interfaces.
    * public class PrintableCollection<T> where T : IPrintable

1. 
    * With a *generic method*, you can specify the types of the parameters and the return type by using a type parameter like that used when you define a generic class.
    * You define generic methods by using the same type parameter syntax you use when you create generic classes.

1. *Invariant* means that you can use only the type originally specified.

1. *Covariant* enables you to use a more derived type than originally specified.

1. Only reference types can be declared as *covariant*.

1. *Contravariant* enables you to use a more generic (less derived) type than originally specified.