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

            if (Job == "athlete")
            {
                Console.WriteLine("Water");
            }
            else if (Job == "businessman" || Job == "businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (Job == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
