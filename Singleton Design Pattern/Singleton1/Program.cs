namespace Singleton1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer1 = Player.CreatePlayer();
            Player myPlayer2 = Player.CreatePlayer();
            Player myPlayer3 = Player.CreatePlayer();
            Player myPlayer4 = Player.CreatePlayer();

            myPlayer1.IdPrint();
            myPlayer2.IdPrint();
            myPlayer3.IdPrint();
            myPlayer4.IdPrint();
        }
    }
}