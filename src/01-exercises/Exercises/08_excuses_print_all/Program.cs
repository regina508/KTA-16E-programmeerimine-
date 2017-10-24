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
            Console.WriteLine("Ma olen tegemate kodutööde vabanduste genereerimise programm. Prindin kõik vabandused välja.");
            Console.WriteLine();

            string[] excuses = new[] { "Koer sõi kodutöö ära", "Ema ei luba arvutis tiksuda", "Kallasin kohvi arvutile peale", "Unustasin", "Arvuti aku läks tühjaks" };

            // use foreach instead

            for (int i = 0; i < excuses.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {excuses[i]}");
            }

            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

    }
}
