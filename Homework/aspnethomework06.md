#### ASP.NET Chapter 6 Homework
#### Austin Stiffler
#### 08 March, 2021


1. *Unit testing* is a form of testing in which individual components are isolated from the rest of the application so their behavior can be thoroughly validated.

1.  Use the dotnet new command with the project template for your preferred test 
framework

1. 
    * mstest
    * nunit
    * xunit

1. The naming convention is to name the unit test project <ApplicationName>.

1. 
    * The name of the test class describes what is being tested
    * The name of the test method describes what the test does

1. 
    * The Fact attribute in xUnit is used to denote a parameterless unit test, which tests invariatns in your code.
    * The Theory attribute in xUnit denotes a parameterised test that is true for a subset of data.

1. 
    * *Arrange* - setup made in order to test the code. Usually consists in creating variables for input data needed to inject into test code.
    * *Act* - Testing that you actually invoke your testing code. Inject the data prepared in previous step and call the actual method.
    * *Assert* - Verify the result of the method under test.

1. Asserts that the result is equal to the expected outcome. Parameters are 'expected, result'.

1. The key to isolating components is to use C# interfaces.

1. *Mocking packages* make it easy to create fake—or mock—objects for tests.

1. 
    * Setup() can be used for mocking a method or a property.
    * SetupGet() is specifically for mocking the getter of a property.