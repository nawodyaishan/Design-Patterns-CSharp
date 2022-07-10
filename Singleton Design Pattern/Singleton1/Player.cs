namespace Singleton1;

public class Player
{
    private int Id;
    private Random rnd = new Random();
    private static Player myPlayer;
    
    private Player()
    {
        this.Id = rnd.Next(1, 1000);
    }

    public static Player CreatePlayer()
    {
        if (myPlayer == null)
            myPlayer = new Player();

        return myPlayer;
    }

    public void IdPrint()
    {
        Console.WriteLine($"My ID is : {Id}");
    }
}