namespace ObserverDesignPattern_;

public interface IObservable
{
    public void Subscribe(IObserver observer);

    public void NotifyAll();
}