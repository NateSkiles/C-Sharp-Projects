using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    // Abstract class -- you can not instantiate one directly but can but used to
    // set a template for any type of game.
    public abstract class Game
    {
        // Properties of Game class
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        // When derived class inherits abstract method Play(), it must override it
        public abstract void Play();


        public virtual void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }

    }
}
