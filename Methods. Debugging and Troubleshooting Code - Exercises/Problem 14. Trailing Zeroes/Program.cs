using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Problem_14.Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            int zeroCount = 0;

            while (factorial % 10 == 0)
            {
                zeroCount++;
                factorial = factorial / 10;
            }
            Console.WriteLine(zeroCount);
        }
    }
}
