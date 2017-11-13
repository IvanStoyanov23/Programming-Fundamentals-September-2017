using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Boolean = Convert.ToBoolean(Console.ReadLine());

            if (Boolean)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
