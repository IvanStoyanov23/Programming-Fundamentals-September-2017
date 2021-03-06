﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= Number; i++)
            {
                bool isPrime = true;
                for (int x = 2; x <= Math.Sqrt(i) ; x++)
                {
                    if (i % x == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
