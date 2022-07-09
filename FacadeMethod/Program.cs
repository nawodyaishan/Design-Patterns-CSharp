namespace FacadeMethod
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            HomeAppliances myHome = new HomeAppliances();

            Console.WriteLine("Hi Smith!!");

            Console.WriteLine("Please enter the scenario of the day\n");
            Console.WriteLine("Press 1 for morning routine");
            Console.WriteLine("Press 2 for Mid Day routine");
            Console.WriteLine("Press 3 for Night routine");

            string scenario = Console.ReadLine() ?? throw new InvalidOperationException();

            if (scenario == "1")
                myHome.MorningRoutine();
            if (scenario == "2")
                myHome.MidDayRoutine();
            if (scenario == "3")
                myHome.NightRoutine();
        }
    }
}