﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Card
    {
        public string Description => _rank + _suite.GetShortName();

        public bool Hidden { get; set; }

        private readonly string _rank;

        private readonly Suite _suite;

        private readonly int _points;

        public Card(string rank, Suite suite, int points, bool hidden = true)
        {
            _rank = rank;
            _suite = suite;
            _points = points;

            this.Hidden = hidden;

        }

      




            
        

    }
}
