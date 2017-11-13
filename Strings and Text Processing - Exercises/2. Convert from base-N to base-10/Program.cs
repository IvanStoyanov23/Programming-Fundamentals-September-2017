﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split();
            var numBase = inputLine[0];
            var numberString = inputLine[1].Reverse().ToArray();
            BigInteger sum = 0;

            for (int i = 0; i < numberString.Length; i++)
            {
                sum += int.Parse(numberString[i].ToString()) * NotMathPow(numBase, i);
            }

            Console.WriteLine(sum);
        }

        static BigInteger NotMathPow(string num, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            var bigIntNum = BigInteger.Parse(num);
            BigInteger result = bigIntNum;
            for (int i = 1; i < power; i++)
            {
                result *= bigIntNum;
            }
            return result;
        }
    }
}
