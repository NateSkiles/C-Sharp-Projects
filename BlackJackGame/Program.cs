using System;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nate's Casino! Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                // TryParse returns a boolean value if it was able to parse, output to bank
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only.");
            }

            Console.WriteLine("Hello, {0} would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            // Instantiate player object
            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\\Users\\nates\\Documents\\Tech Academy Projects\\C-Sharp-Projects\\BlackJackGame\\IO\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Something you entered was incorrect");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your system administrator.");
                        Console.ReadLine();
                        return;
                    }
                }
            }

            Console.WriteLine("Feel free to look around the casino. -- Bye for now.");

            Console.Read();
        }
    }
}
