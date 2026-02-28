using System.Numerics;



public abstract class Handler<T>
{
    protected Handler<T> _nextHandler;
    
    public void SetNext(Handler<T> handler)
    {
        _nextHandler = handler;
    }
    public virtual T? Handle(T input)
    {
        if (_nextHandler != null)
        {
            return _nextHandler.Handle(input);
        }
        return default(T);
    }
}