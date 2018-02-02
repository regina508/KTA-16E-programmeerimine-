using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Client.console
{
    using System;
    using Blackjack.Core;

    public class Program
    {
        public static void Main(string[] args)
        
        {
            Console.Title = "Welcome to the game of Blackjack!";
            Console.WriteLine();
            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            var deck = new Deck();
            var player = new Player();
            var dealer = new Dealer();

           
            deck.Deal(player.PlayerHand);
            deck.Deal(player.PlayerHand);
            deck.Deal(dealer.DealerHand);
            deck.Deal(dealer.DealerHand);


                     
            while (true)
            {
                if (player.PlayerHand.ShowPoints() > 21)
                {
                    Console.WriteLine();
                    Console.WriteLine("SORRY, YOU LOST");
                    Console.WriteLine();
                    Console.WriteLine($"Your cards: {player.PlayerHand.ShowCards()} ({player.PlayerHand.ShowPoints()} points)");
                    player.PlayerHand.ClearHand();
                    deck.Deal(player.PlayerHand);
                    deck.Deal(player.PlayerHand);

                    dealer.DealerHand.ClearHand();
                    deck.Deal(dealer.DealerHand);
                    deck.Deal(dealer.DealerHand);
                    Console.WriteLine();
                    Console.WriteLine("..........................................................................");
                    Console.WriteLine();
                    Console.WriteLine("NEW GAME");
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine($"Your cards: {player.PlayerHand.ShowCards()} ({player.PlayerHand.ShowPoints()} points)");
                Console.WriteLine("Do you want to take another card?");
                Console.WriteLine("If yes - choose 'Y' ");
                Console.WriteLine("If no - choose 'N'");
                Console.Write("Your choice: ");

                var answer = Console.ReadKey();
                Console.WriteLine();

                if (answer.Key == ConsoleKey.Y)
                {
                    deck.Deal(player.PlayerHand);
                }

                if (answer.Key == ConsoleKey.N)
                {
                    //If dealer have <= 16 points, he must take a card.
                    while (dealer.DealerHand.ShowPoints() <= 16)
                    {
                        deck.Deal(dealer.DealerHand);
                    }

                    if (dealer.DealerHand.ShowPoints() < player.PlayerHand.ShowPoints() && player.PlayerHand.ShowPoints() == 21)
                    {
                        Console.WriteLine();
                        Console.WriteLine("CONGRATULATIONS! YOU WON!");
                        Console.WriteLine();
                        Console.WriteLine($"Your cards: {player.PlayerHand.ShowCards()} ({player.PlayerHand.ShowPoints()} points)");
                        Console.WriteLine($"Dealer cards: {dealer.DealerHand.ShowCards()} ({dealer.DealerHand.ShowPoints()} points)");
                        }
                        if (dealer.DealerHand.ShowPoints() > 21 || dealer.DealerHand.ShowPoints() < player.PlayerHand.ShowPoints())
                        {
                        Console.WriteLine();
                        Console.WriteLine("CONGRATULATIONS! YOU WON!");
                        Console.WriteLine();
                        Console.WriteLine($"Your cards: {player.PlayerHand.ShowCards()} ({player.PlayerHand.ShowPoints()} points)");
                        Console.WriteLine($"Dealer cards: {dealer.DealerHand.ShowCards()} ({dealer.DealerHand.ShowPoints()} points)");
                    }
                    if (dealer.DealerHand.ShowPoints() == player.PlayerHand.ShowPoints())
                    {
                        Console.WriteLine();
                        Console.WriteLine("DEAT HEAT - PLAYER AND DEALER HAVE EQUAL NUMBER OF POINTS");
                        Console.WriteLine();
                        Console.WriteLine($"Your cards: {player.PlayerHand.ShowCards()} ({player.PlayerHand.ShowPoints()} points)");
                        Console.WriteLine($"Dealer cards: {dealer.DealerHand.ShowCards()} ({dealer.DealerHand.ShowPoints()} points)");
                    }

                    if (dealer.DealerHand.ShowPoints() <= 21 && dealer.DealerHand.ShowPoints() > player.PlayerHand.ShowPoints())
                    {
                        Console.WriteLine();
                        Console.WriteLine("SORRY, YOU LOST");
                        Console.WriteLine();
                        Console.WriteLine($"Your cards: {player.PlayerHand.ShowCards()} ({player.PlayerHand.ShowPoints()} points)");
                        Console.WriteLine($"Dealer cards: {dealer.DealerHand.ShowCards()} ({dealer.DealerHand.ShowPoints()} points)");
                    }

                    player.PlayerHand.ClearHand();
                    deck.Deal(player.PlayerHand);
                    deck.Deal(player.PlayerHand);

                    dealer.DealerHand.ClearHand();
                    deck.Deal(dealer.DealerHand);
                    deck.Deal(dealer.DealerHand);
                    Console.WriteLine();
                    Console.WriteLine("..........................................................................");
                    Console.WriteLine();
                    Console.WriteLine("NEW GAME");
                    Console.WriteLine();


                }


            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
                   
    }
}