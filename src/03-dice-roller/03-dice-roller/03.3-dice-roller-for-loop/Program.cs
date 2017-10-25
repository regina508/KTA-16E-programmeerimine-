using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._3_dice_roller_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {


            Random rnd = new Random();
            int randomDiceRoll;


            Console.WriteLine(" /roll 3d6 2d8");
            Console.WriteLine();

            for (int i = 1; i <= 3; i++)
            {
                randomDiceRoll = rnd.Next(1, 6);
                Console.WriteLine("1d6: " + randomDiceRoll);

            }

            for (int i = 1; i <= 2; i++)
            {
                randomDiceRoll = rnd.Next(1, 8);
                Console.WriteLine("1d8: " + randomDiceRoll);
            }

                

            Console.WriteLine();

            Console.WriteLine("Roll total: 20");

            Console.ReadLine();
        }
    }
}
