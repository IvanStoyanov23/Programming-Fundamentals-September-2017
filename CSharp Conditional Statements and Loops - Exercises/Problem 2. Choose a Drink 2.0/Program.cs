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
            var Job = Console.ReadLine(); ;
            var Quantity = int.Parse(Console.ReadLine());

            var water = 0.70;
            var coffee = 1.00;
            var beer = 1.70;
            var tea = 1.20;

            if (Job == "Athlete")
            {
                Console.WriteLine($"The Athlete has to pay {water * Quantity:f2}.");
            }
            else if (Job == "Businessman")
            {
                Console.WriteLine($"The Businessman has to pay {coffee * Quantity:f2}.");
            }
            else if (Job == "Businesswoman")
            {
                Console.WriteLine($"The Businesswoman has to pay {coffee * Quantity:f2}.");
            }
            else if (Job == "SoftUni Student")
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
