using System;

class NotifierEmail : NotifierDecorator
{
    public NotifierEmail(Notifier notifier) : base(notifier)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"Send Email {message}");
        Console.WriteLine();
    }
}