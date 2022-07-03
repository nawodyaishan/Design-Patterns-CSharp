namespace ObserverDesignPattern;

public interface IObserver
{
    public void NotifyChange(int temperature);
}