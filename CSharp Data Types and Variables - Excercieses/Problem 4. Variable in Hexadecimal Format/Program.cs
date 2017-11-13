using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main()
        {
            string value = Convert.ToString(Console.ReadLine());

            try
            {
                int number = Convert.ToInt32(value, 16);
                Console.WriteLine($"{number}");
            }
            catch (OverflowException)
            {
            
            }
        }
    }
}
