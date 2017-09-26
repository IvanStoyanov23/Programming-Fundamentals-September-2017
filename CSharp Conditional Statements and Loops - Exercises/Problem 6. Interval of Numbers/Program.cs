using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstNum = int.Parse(Console.ReadLine());
            var SecondNum = int.Parse(Console.ReadLine());

            var row = Math.Abs(FirstNum - SecondNum);
            if (FirstNum < SecondNum)
            {
                for (int i = 0; i <= row; i++)
                {
                    Console.WriteLine(FirstNum);
                    FirstNum++;
                }
            }
            else
            {
                for (int i = 0; i <= row; i++)
                {
                    Console.WriteLine(SecondNum);
                    SecondNum++;
                }
            }
        
        }
    }
}
