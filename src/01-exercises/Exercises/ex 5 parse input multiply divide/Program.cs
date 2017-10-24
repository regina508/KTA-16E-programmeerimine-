using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5_parse_input_multiply_divide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaatori programm.");
            Console.WriteLine("Ütle mulle 2 numbrit ja ma ütlen sulle nende korrutise ja jagatise");
            Console.WriteLine();

            Console.Write("Esimene number: ");
            String input1 = Console.ReadLine();

            Console.Write("Teine number: ");
            String input2 = Console.ReadLine();

            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);

            Console.WriteLine("Korrutis on: " + (number1 * number2));
            Console.WriteLine("Jagatis on: " + (number1 / number2));

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();


        }
    }
}
