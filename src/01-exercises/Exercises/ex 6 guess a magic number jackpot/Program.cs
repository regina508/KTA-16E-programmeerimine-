using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6_guess_a_magic_number_jackpot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin ühe suvalise numbri [1-100]. Proovi see ära arvata :)");

            int magicNumber = 57;

            Console.Write("Sina pakud: ");


            string input = Console.ReadLine();
            int value = int.Parse(input);

            if (value > magicNumber)
            {
                Console.WriteLine("Minu valitud number on väiksem");
            }

            if (value < magicNumber)
            {
                Console.WriteLine("Minu valitud number on suurem");

            }

            if (value == magicNumber)
            {
                Console.WriteLine("Woot! You guessed it!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();


        }
    }
}
