using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.FirstOrDefault().ToString() + "\n");
            Console.WriteLine(card);
            // Write cards to text file as they are dealt
            using (StreamWriter file = new StreamWriter(@"C:\\Users\\nates\\Documents\\Tech Academy Projects\\C-Sharp-Projects\\BlackJackGame\\IO\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0); 
        }
    }
}
