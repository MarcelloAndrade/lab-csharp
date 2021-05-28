using System;

class NotifierSMS : NotifierDecorator
{
    public NotifierSMS(Notifier notifier) : base(notifier)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"Send SMS {message}");
        Console.WriteLine();
    }
}