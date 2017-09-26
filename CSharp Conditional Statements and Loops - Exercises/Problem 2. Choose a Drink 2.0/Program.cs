using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peoblem_1.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            var Job = Console.ReadLine().ToLower(); ;
            var Quantity = int.Parse(Console.ReadLine());

            var water = 0.70;
            var coffee = 1.00;
            var beer = 1.70;
            var tea = 1.20;

            if (Job == "athlete")
            {
                Console.WriteLine($"The Athlete has to pay {water * Quantity:f2}.");
            }
            else if (Job == "businessman")
            {
                Console.WriteLine($"The Businessman has to pay {coffee * Quantity:f2}.");
            }
            else if (Job == "businesswoman")
            {
                Console.WriteLine($"The Businesswoman has to pay {coffee * Quantity:f2}.");
            }
            else if (Job == "softuni student")
            {
                Console.WriteLine($"The SoftUni Student has to pay {beer * Quantity:f2}.");
            }
            else
            {
                Console.WriteLine($"The {Job} has to pay {tea * Quantity:f2}.");
            }
        }
    }
}
