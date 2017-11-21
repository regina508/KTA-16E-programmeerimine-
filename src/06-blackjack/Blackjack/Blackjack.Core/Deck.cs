using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Deck

    {
        private readonly List<Card> _cards;

        public Deck(List<Card> cards)
        {
            _cards = cards;
        }

        public static Deck C36()

        {

            throw new NotImplementedException();
        }

        public static Deck C52()
        {
            throw new NotImplementedException();
        }

            //var deck = Deck.C36
            //var deck = Deck.C52

        public Card Next()
        {
            var card = _cards.ElementAt(0);

            _cards.RemoveAt(0);

            return card;
        }



    }
}
