using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Prime_In_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            Console.WriteLine(PrimeList(startNum, endNum));
        }

        static bool PrimeChecker(long number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static string PrimeList(int start, int finish)
        {
            string primedNumbers = string.Empty;

            for (int i = start; i <= finish; i++)
            {
                bool number = PrimeChecker(i);
                bool isPrime = false;
                if (number == true)
                {

                    primedNumbers += i;
                    isPrime = true;
                }
                if (isPrime)
                {
                    primedNumbers += ", ";
                }

            }
            primedNumbers = primedNumbers.Remove(primedNumbers.Length - 2);
            return primedNumbers;

        }
        
    }
}
