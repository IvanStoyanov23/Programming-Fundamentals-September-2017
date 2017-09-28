using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Integer_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;

            try
            {
                while (true)
                {
                    var i = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);
            }
            
        }
    }
}
