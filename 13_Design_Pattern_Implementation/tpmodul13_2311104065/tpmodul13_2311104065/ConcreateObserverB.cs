using System;

namespace tpmodul13_2311104065
{
    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is Subject concreteSubject)
            {
                if (concreteSubject.State == 0 || concreteSubject.State >= 2)
                {
                    Console.WriteLine("ConcreteObserverB: Reacted to the event.");
                }
            }
        }
    }
}
