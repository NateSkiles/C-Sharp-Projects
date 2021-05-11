using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackJackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nate's Casino! Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            decimal bank = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hello, {0} would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            // Instantiate player object
            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
            }

            Console.WriteLine("Feel free to look around the casino. -- Bye for now.");

            Console.Read();
        }
    }
}
