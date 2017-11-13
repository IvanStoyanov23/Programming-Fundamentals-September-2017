using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Name_оf_the_Last_Digit
{
    class Program
    {
        static void Main()
        {
            long Number = Math.Abs(long.Parse(Console.ReadLine()));

            PrintLastNumberName(Number);
        }

        static void PrintLastNumberName(long Number)
        {
            Number = Number % 10;

            if (Number == 0)
            {
                Console.WriteLine("zero");
            }
            else if (Number == 1)
            {
                Console.WriteLine("one");
            }
            else if (Number == 2)
            {
                Console.WriteLine("two");
            }
            else if (Number == 3)
            {
                Console.WriteLine("three");
            }
            else if (Number == 4)
            {
                Console.WriteLine("four");
            }
            else if (Number == 5)
            {
                Console.WriteLine("five");
            }
            else if (Number == 6)
            {
                Console.WriteLine("six");
            }
            else if (Number == 7)
            {
                Console.WriteLine("seven");
            }
            else if (Number == 8)
            {
                Console.WriteLine("eight");
            }
            else if (Number == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}
