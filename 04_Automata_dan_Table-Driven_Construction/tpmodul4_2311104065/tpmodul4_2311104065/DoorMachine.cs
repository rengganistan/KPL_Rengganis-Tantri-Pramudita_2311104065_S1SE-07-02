using System;

public class DoorMachine
{
    private enum State
    {
        Terkunci,
        Terbuka
    }

    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void Toggle()
    {
        if (currentState == State.Terkunci)
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}
