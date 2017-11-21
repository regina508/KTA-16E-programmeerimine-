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
        //All aces are 11 points. In real life, one can choose whether it is 1 or 11
        //When user draws a card, house always draws one as-well. In real life, house can decide based on some rule
        {
            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            var cards = new List<Card>
            {
                new Card("4", Suite.Club, 4, false),
                new Card("6", Suite.Heart, 6, false),
                new Card("8", Suite.Spade, 8, false),
                new Card("J", Suite.Diamond, 10, true),
                new Card("4", Suite.Spade, 4, false),
                new Card("T", Suite.Heart, 10, true),
             };

            var Deck = new Deck(cards);

            //4C = card.Rank + card.Suite
            //4C = card.GetDescription()
            //4C = card.Description

            Console.WriteLine($"You have been dealt: {GetCardDescription(Deck.Next())}, {GetCardDescription(Deck.Next())}");
            Console.WriteLine($"House has been dealt: {GetCardDescription(Deck.Next())}, {GetCardDescription(Deck.Next())}");
            Console.WriteLine();


            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 1");
            Console.WriteLine();

            //var s4 = new Card("4", Suite.Spade, 4, false);
            //var hT = new Card("T", Suite.Heart, 10, true);

            Console.WriteLine("You have been dealt: 45");
            Console.WriteLine("House has been dealt: [?]");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 2");
            Console.WriteLine();

            Console.WriteLine("You have 14 points vs house 17 points");
            Console.WriteLine("House wins!");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        

        public static string GetCardDescription(Card card)
        {
           
                return card.Hidden ? "[?]" : card.Description;
            
        }
    }
}