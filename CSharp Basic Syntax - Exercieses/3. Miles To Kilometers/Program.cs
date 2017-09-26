using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Miles_To_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var Miles = double.Parse(Console.ReadLine());
            var Kilometers = Miles * 1.60934;

            Console.WriteLine($"{Kilometers:f2}");
        }
    }
}
