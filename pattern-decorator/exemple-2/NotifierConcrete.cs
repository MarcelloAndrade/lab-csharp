using System;

class NotifierConcrete : Notifier
{
    public override void Send(string message)
    {
        Console.WriteLine($"Send Basic {message}");
        Console.WriteLine();
    }
}