using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    class Deck
    {
        // Constructor Class that is method that's called when an object is created
        public Deck()
        {
            // Instantiate  List Cards, an emptyList of Card objects
            Cards = new List<Card>();
            // Instantiates two string lists of all of the Suits and Faces that a card can be
            List<string> Suits = new List<string>() { "Clubs", "hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            // Loop through each Face value
            foreach (string face in Faces)
            {
                // For each suit, create a card and add it to Cards list with suit and face
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }

        public List<Card> Cards { get; set; }

    }
}
