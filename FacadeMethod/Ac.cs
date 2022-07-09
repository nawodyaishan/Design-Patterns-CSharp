using System.Net;

namespace FacadeMethod;

public class Ac
{
    public Ac()
    {
        Temp = 27;
    }

    public int Temp { get; }

    public void TurnOnAc()
    {
        Console.WriteLine("Turning on AC Machine!!\n");
    }

    public void IncrementAcTemp()
    {
        int nowTemp = this.Temp + 6;
        Console.WriteLine($"Current Temperature is {nowTemp}\n");
    }

    public void DecrementAcTemp()
    {
        int nowTemp = this.Temp - 6;
        Console.WriteLine($"Current Temperature is {nowTemp}\n");
    }
}