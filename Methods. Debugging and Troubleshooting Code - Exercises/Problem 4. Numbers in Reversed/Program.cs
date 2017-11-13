using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Numbers_in_reversedNumberd
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            ReversedNumber(number);
        }

        static void ReversedNumber(double number)
        {
            string numberAsString = number.ToString();

            var reverseNumber = string.Join("", numberAsString.Reverse());

            Console.WriteLine(reverseNumber);
        }
    }
}
