using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin ühe suvalise numbri [1-100]. Proovi see ära arvata :)");

            int magicNumber = 33;

            Console.Write("Sina pakud: ");


            string input=Console.ReadLine();
            int value = int.Parse(input);

            if (value > magicNumber)
            {
                Console.WriteLine("Minu valitud number on väiksem");
            }

            if (value < magicNumber)
            {
                Console.WriteLine("Minu valitud number on suurem");

            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            
            Console.ReadLine();

        }
    }
}
