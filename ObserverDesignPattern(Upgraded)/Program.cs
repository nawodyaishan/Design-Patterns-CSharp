namespace ObserverDesignPattern_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempSensor myTempSensor = new TempSensor();

            AC myAC = new AC();
            AC myAC1 = new AC();
            Heater myHeater = new Heater();
            Heater myHeater1 = new Heater();

            myTempSensor.Subscribe(myHeater);

            myTempSensor.SetTemp(45);

            myTempSensor.Subscribe(myAC);
            
            myTempSensor.SetTemp(67);

        }
    }
}