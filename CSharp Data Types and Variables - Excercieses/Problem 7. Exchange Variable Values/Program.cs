using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int a = secondNumber;
            int b = firstNumber;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstNumber}");
            Console.WriteLine($"b = {secondNumber}");

            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
