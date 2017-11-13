using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            FibonacciNumber(number);
        }

        static void FibonacciNumber(int number)
        {
            int fibNumber1 = 0;
            int fibNumber2 = 1;
            int fibonacciN = 1;

            for (int i = 0; i < number; i++)
            {
                fibonacciN = fibNumber1 + fibNumber2;
                fibNumber1 = fibNumber2;
                fibNumber2 = fibonacciN;
            }
            Console.WriteLine(fibonacciN);
        }
    }
}
