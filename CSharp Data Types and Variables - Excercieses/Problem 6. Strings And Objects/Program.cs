using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var StringOne = Console.ReadLine();
            var StringTwo = Console.ReadLine();

            var Conc = String.Concat(StringOne, " ", StringTwo);

            Console.WriteLine(Conc);
        }
    }
}
