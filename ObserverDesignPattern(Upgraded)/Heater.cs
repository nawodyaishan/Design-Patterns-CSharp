namespace ObserverDesignPattern_;

public class Heater : IObserver
{
    // To Access Current Temperature from IObservable Interface 
    public void NotifyChange(int temperature)
    {
        Console.WriteLine($"\nCurrent Temperature of Heater is : {temperature}\n");
        Console.WriteLine($"____________\n");
    }
}