using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var Name = Console.ReadLine();
            var Volume = int.Parse(Console.ReadLine());
            var Energy = int.Parse(Console.ReadLine());
            var Sugar = double.Parse(Console.ReadLine());

            var kcal = (Volume * Energy) / 100.00;
            var sugars = (Sugar * Volume) / 100.00;

            Console.WriteLine($"{Volume}ml {Name}:");
              Console.WriteLine($"{kcal}kcal, {sugars}g sugars");
        }
    }
}
