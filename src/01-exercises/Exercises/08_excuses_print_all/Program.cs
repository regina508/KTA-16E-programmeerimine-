using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_excuses_print_all
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] excuses = new[] { "Koer sõi kodutöö ära", "Ema ei luba arvutis tiksuda" };

            // use foreach instead

            for (int i = 0; i < excuses.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {excuses[i]}");
            }

            Console.ReadLine();
        }

    }
}
