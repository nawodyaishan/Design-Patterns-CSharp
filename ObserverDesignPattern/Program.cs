namespace ObserverDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempSensor myTempSensor = new TempSensor();

            AC myAC = new AC();
            Heater myHeater = new Heater();

            myTempSensor.Subscribe(myHeater);
            myTempSensor.Subscribe(myAC);

            myTempSensor.SetTemp(45);
            myTempSensor.SetTemp(67);
            myTempSensor.SetTemp(65);
            myTempSensor.SetTemp(23);
        }
    }
}