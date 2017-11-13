using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNums = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var sum = 0;

            for (int i = 0; i < listOfNums.Count; i++)
            {
                var charArray = listOfNums[i].ToCharArray();

                Array.Reverse(charArray);

                int number = int.Parse(new string(charArray));

                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
