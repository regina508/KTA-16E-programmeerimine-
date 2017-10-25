using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._2_dice_roller_random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" /roll 3d6 2d8");
            Console.WriteLine();

            Random number = new Random();

            int diceroll = number.Next(1, 6);
            
            Console.WriteLine("1d6: " + diceroll);


            diceroll = number.Next(1, 6);
            Console.WriteLine("1d6: ");

            diceroll = number.Next(1, 6);
            Console.WriteLine("1d6: ");

            diceroll = number.Next(1, 8);
            Console.WriteLine("1d8: ");

            diceroll = number.Next(1, 8);
            Console.WriteLine("1d8: ");


            Console.WriteLine();

            Console.WriteLine("Roll total: 20");

            Console.ReadLine();
        }
}
