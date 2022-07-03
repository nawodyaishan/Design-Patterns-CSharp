namespace ObserverDesignPattern;

public class AC : IObserver
{
    // To Access Current Temperature from IObservable Interface 
    public void NotifyChange(int temperature)
    {
        Console.WriteLine($"\nCurrent Temperature of AC is : {temperature}\n");
        Console.WriteLine($"____________\n");
    }
}