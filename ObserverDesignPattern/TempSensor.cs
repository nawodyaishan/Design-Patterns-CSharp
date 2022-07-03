namespace ObserverDesignPattern;

public class TempSensor : IObservable
{
    private int temperature;

    private List<IObserver> subcriberList = new List<IObserver>();

    public void SetTemp(int value)
    {
        temperature = value;
        NotifyAll();
    }

    public void Subscribe(IObserver observer)
    {
        // Adding IObserver (Subscriber) to the List
        subcriberList.Add(observer);
    }

    // Sending Temperature Change(Updated Value) to each subscriber's IObserver (Temperature) 
    public void NotifyAll()
    {
        foreach (IObserver observer in subcriberList)
        {
            observer.NotifyChange(temperature);
        }
    }
}