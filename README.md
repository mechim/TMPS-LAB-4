# TMPS-LAB-4
# Design Patterns Implementation in C#

This project demonstrates the implementation of three design patterns: Chain of Responsibility, Command, and Observer in C#. Each of these patterns serves a specific purpose and provides a solution to particular design problems.

## Chain of Responsibility Pattern

The Chain of Responsibility pattern allows a request to be passed through a chain of handlers. If one handler cannot handle the request, it is passed to the next handler in the chain. In this project, we implemented this pattern using the `Handler` abstract class, with concrete handler classes `ConcreteHandler1` and `ConcreteHandler2`. These handlers are linked in a chain, and the `HandleRequest` method is used to process the request based on certain conditions.

## Command Pattern

The Command pattern encapsulates a request as an object, thereby allowing us to parameterize clients with queues, requests, and operations. In this project, we created the `ICommand` interface and the `ConcreteCommand` class, which encapsulates the receiver's action. The `Receiver` class contains the action to be performed, which is then executed through the `Execute` method in the `ConcreteCommand` class.

## Observer Pattern

The Observer pattern establishes a one-to-many dependency between objects, where the change in one object triggers the update in other dependent objects. In this project, we implemented this pattern using the `IObserver` interface and the `ConcreteObserver` class. The `Subject` class maintains a list of observers and notifies them of any state changes. The `Attach`, `Detach`, and `Notify` methods in the `Subject` class manage the list of observers and notify them accordingly.

## Running the Code

To see the implementation in action, simply run the `Program.cs` file in any C# compatible environment. The main method contains instances and usage examples of the implemented design patterns. 
