using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var Product = Console.ReadLine();
            var Volume = int.Parse(Console.ReadLine());
            var Kal = int.Parse(Console.ReadLine());
            var Sugar = int.Parse(Console.ReadLine());

            var TotalKal = (Volume * Kal) / 100;
            var TotalSugar = (Volume * Sugar) / 100;

            Console.WriteLine($"{Volume}ml {Product}:");
            Console.WriteLine($"{TotalKal}kcal, {Sugar}g sugars");
        }
    }
}
