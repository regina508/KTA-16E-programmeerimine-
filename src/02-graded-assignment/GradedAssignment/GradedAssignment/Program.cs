using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It is a discount calculator. Please enter a sum and i will show price with discount");

            Console.Write("Enter sum: ");
            String input1 = Console.ReadLine();

            int value = int.Parse(input1);

            if (value > 49)
                {
                Console.WriteLine("Your discount is 5%");
            }

            }

        Console.Readline();

        
        }
    }
}
