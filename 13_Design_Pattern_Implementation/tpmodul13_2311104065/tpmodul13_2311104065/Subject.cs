using System;
using System.Collections.Generic;
using System.Threading;

namespace tpmodul13_2311104065
{
    public class Subject : ISubject
    {
        // State of the subject
        public int State { get; set; } = 0;

        // List of subscribers
        private readonly List<IObserver> _observers = [];

        // Attach an observer
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            _observers.Add(observer);
        }

        // Detach an observer
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        // Notify all observers
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        // Simulate some business logic
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            State = Random.Shared.Next(0, 10); // Disarankan sejak C# 9.0

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + State);
            Notify();
        }
    }
}
