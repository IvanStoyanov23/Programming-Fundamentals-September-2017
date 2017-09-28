using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine();
            var counter = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Adding ingredient {ingredients}.");
                counter++;

                ingredients = Console.ReadLine();
                if (ingredients == "Bake!")
                {
                    break;
                }
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
