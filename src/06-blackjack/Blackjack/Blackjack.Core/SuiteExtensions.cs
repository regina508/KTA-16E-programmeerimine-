﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public static class SuiteExtensions
    {
        public static char GetShortName(this Suite suite)
        {
            switch (suite)
            {
                case Suite.Club: return 'C';
                case Suite.Spade: return 'S';
                case Suite.Heart: return 'H';
                case Suite.Diamond: return 'D';
                default: throw new InvalidOperationException();
            }

        }
    }
}
