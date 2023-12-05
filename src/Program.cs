using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    // Chain of Responsibility Pattern
    public abstract class Handler
    {
        protected Handler _successor;

        public void SetSuccessor(Handler successor)
        {
            _successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{this.GetType().Name} handled the request {request}");
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{this.GetType().Name} handled the request {request}");
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(request);
            }
        }
    }

    // Command Pattern
    public interface ICommand
    {
        void Execute();
    }

    public class ConcreteCommand : ICommand
    {
        private Receiver _receiver;

        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Action();
        }
    }

    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Receiver: Execute Action");
        }
    }

    // Observer Pattern
    public interface IObserver
    {
        void Update(string message);
    }

    public class ConcreteObserver : IObserver
    {
        private string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"Observer {_name} received message: {message}");
        }
    }

    public class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Chain of Responsibility pattern
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();
            handler1.SetSuccessor(handler2);

            handler1.HandleRequest(5);
            handler1.HandleRequest(15);

            // Command pattern
            var receiver = new Receiver();
            ICommand command = new ConcreteCommand(receiver);
            command.Execute();

            // Observer pattern
            var subject = new Subject();
            var observer1 = new ConcreteObserver("Observer1");
            var observer2 = new ConcreteObserver("Observer2");
            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.Notify("Hello World!");
        }
    }
}

