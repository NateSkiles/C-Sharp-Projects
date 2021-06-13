using System;
using System.Collections.Generic;

namespace Casino
{
    public abstract class Game
    {
        // Instantiate players list
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        // Dictionary of player bets. The key is the player and the value is their bet
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }

    }
}
