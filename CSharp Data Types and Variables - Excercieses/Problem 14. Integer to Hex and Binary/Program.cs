using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());

            string hexValue = Number.ToString("X");
            string binaryValue = Convert.ToString(Number, 2);

            Console.WriteLine(hexValue);
            Console.WriteLine(binaryValue);
        }
    }
}
