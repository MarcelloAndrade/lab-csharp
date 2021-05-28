abstract class NotifierDecorator : Notifier
{
    private Notifier _notifier;
    protected NotifierDecorator(Notifier notifier)
    {
        _notifier = notifier;
    }

    public override void Send(string message)
    {
        if (this._notifier != null)
        {
            this._notifier.Send(message);
        }
    }    
}