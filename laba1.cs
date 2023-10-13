using System;
using System.Collections.Generic;
namespace MyProject.Utilities{

class Program
{
    static void Main(string[] args)
    {
        GameAccount player1 = new GameAccount("Petya");
        GameAccount player2 = new GameAccount("Boris");

        // імітація гри
        player1.WinGame("Boris", 20);
        player2.LoseGame("Petya", 10);
        player1.LoseGame("Boris", 15);
        player2.WinGame("Petya", 25);
        player1.WinGame("Boris", 30);
        player2.LoseGame("Petya", 20);

        // стата
        player1.GetStats();
        player2.GetStats();
    }
}
}