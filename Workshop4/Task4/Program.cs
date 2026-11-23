using Task4;
class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player();

        Player player2 = new Player("Dhawa", 10, 90);

        Console.WriteLine("\nPlayer 1 Details:");
        Console.WriteLine("Player Name: " + player1.playerName);
        Console.WriteLine("Level: " + player1.level);
        Console.WriteLine("Health: " + player1.health);

        Console.WriteLine("\nPlayer 2 Details:");
        Console.WriteLine("Player Name: " + player2.playerName);
        Console.WriteLine("Level: " + player2.level);
        Console.WriteLine("Health: " + player2.health);
    }
}