namespace CSharpOOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1 — Abstraction
            // a)  What is Abstraction in Object-Oriented Programming?
            // Answer: Abstraction is a fundamental concept in Object-Oriented Programming (OOP) that focuses on simplifying complex systems by modeling classes based on the essential properties and behaviors of objects while hiding unnecessary implementation details. It allows developers to create abstract classes and interfaces that define a blueprint for derived classes, enabling them to work with high-level concepts without needing to understand the underlying complexities.
            // b)  Why is abstraction considered one of the four pillars of OOP ?
            // Answer: Abstraction is considered one of the four pillars of OOP (along with Encapsulation, Inheritance, and Polymorphism) because it promotes modularity, reusability, and maintainability in software design. By allowing developers to focus on the essential features of an object while hiding implementation details, abstraction helps create a clear separation between the interface and implementation. This leads to more flexible and scalable code, as changes to the underlying implementation can be made without affecting the code that relies on the abstracted interface.
            #endregion

            #region Q2 — Abstract Classes vs. Interfaces
            // a)  What is the difference between an Abstract Class and an Interface?
            // Answer: An Abstract Class is a class that cannot be instantiated on its own and may contain both abstract methods (without implementation) and concrete methods (with implementation). It serves as a base class for other classes to inherit from, allowing them to share common functionality while enforcing the implementation of certain methods in derived classes. An Interface, on the other hand, is a contract that defines a set of methods and properties that a class must implement. Interfaces do not provide any implementation; they only specify the signatures of the methods and properties. A class can implement multiple interfaces, allowing for greater flexibility in design, while it can only inherit from one abstract class.
            // b)  When would you choose an Interface instead of an Abstract Class?
            // Answer: You would choose an Interface instead of an Abstract Class when you want to define a contract that multiple classes can implement, regardless of their position in the class hierarchy. Interfaces are ideal for scenarios where you need to enforce a specific set of behaviors across unrelated classes, allowing for greater flexibility and decoupling. Additionally, since C# supports multiple interface inheritance, using interfaces enables you to combine different sets of behaviors from various sources without being constrained by a single inheritance chain.
            // c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            // Answer: In C#, a class cannot inherit from multiple abstract classes due to the single inheritance model. However, a class can implement multiple interfaces, allowing it to inherit behaviors from various sources and providing greater flexibility in design.

            #endregion
            #endregion
        }
    }
}
