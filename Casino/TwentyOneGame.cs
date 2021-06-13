using System;
using System.Collections.Generic;
using System.Linq;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play()
        {
            // Game Logic
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                // Empty player's hands
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            // Reset dealer and deck
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            // Get bet from each player
            foreach (Player player in Players)
            {
                // Place bet
                bool validAnser = false;
                int bet = 0;
                while (!validAnser)
                {
                    Console.WriteLine("Place your bet!");
                    validAnser = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnser) Console.WriteLine("Please enter only digits.");
                }
                if (bet < 0)
                {
                    throw new FraudException("Security! Kick this person out.");
                }
                bool succesfullyBet = player.Bet(bet);
                if (!succesfullyBet)
                {
                    return;
                }
                // Use game property Bets to make a dictionary item of each bet.
                Bets[player] = bet;
            }

            // Deal hands to players
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if ( i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            // If player gets blackjack on the deal, return them their bet and the bet * 1.5. 
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            // Remove from active bets before rest of game is player
                            Bets.Remove(player);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    // Check dealer for blackjack
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach(Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("--------------------------------------------------\n\nDealer cards are: ");
                    foreach (Card card in Dealer.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }
                    Console.WriteLine("\nYour cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay" || answer == "s")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit" || answer == "h")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.isBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! Your lose your bet of ${1}. Your balance is now ${2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah" || answer == "y")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.isBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.isBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won ${1}!", entry.Key.Name, entry.Value);
                    // From the list players, where name matches bettors Key.Name, add the amount that player won back to their balance.
                    Players.Where(x => x.Name == entry.Key.Name).FirstOrDefault().Balance += (entry.Value * 2); // .Where() produces a list, get item with .First()
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                // null-able boolean
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                    Bets.Remove(player);
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won ${1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];
                }

                Console.WriteLine("\n--------------------------------------------------\n\nYour balance is :${0} \nPlay again?", player.Balance);
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah" || answer == "y")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
