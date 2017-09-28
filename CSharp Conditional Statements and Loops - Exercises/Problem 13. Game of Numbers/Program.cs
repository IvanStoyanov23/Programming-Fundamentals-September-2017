using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var KindOfMagic = false;
            string lastMagic = "";
            var combinationsCount = 0;
            for (int i = number1; i <= number2; i++)
            {
                for (int j = number1; j <= number2; j++)
                {
                    combinationsCount++;
                    if (i + j == magicNumber)
                    {
                        lastMagic = $"Number found! {i} + {j} = {magicNumber}";
                        KindOfMagic = true;
                    }
                }
            }

            if (KindOfMagic)
            {
                Console.WriteLine(lastMagic);
            }
            else
            {
                Console.WriteLine($"{combinationsCount} combinations - neither equals {magicNumber}");
            }
        }
    }
}
