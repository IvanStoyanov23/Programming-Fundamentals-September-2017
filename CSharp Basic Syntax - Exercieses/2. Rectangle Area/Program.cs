using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var Width = double.Parse(Console.ReadLine());
            var Height = double.Parse(Console.ReadLine());

            var Area = Width * Height;

            Console.WriteLine($"{Area:f2}");
        }
    }
}
