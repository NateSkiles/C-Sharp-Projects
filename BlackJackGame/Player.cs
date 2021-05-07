using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool MyProperty { get; set; }
    }
}
