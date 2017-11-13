using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            // sbyte -128 .. 127
            // byte 0 .. 255
            // short -32,768 .. 32,767
            // ushort 0 .. 65,535
            // int -2,147,483,648 .. 2,147,483,647
            // uint 0 .. 4,294,967,295
            // long -9,223,372,036,854,775,808 .. 9,223,372,036,854,775,807

            string number = Console.ReadLine();
            long l;
            if (long.TryParse(number, out l))
            {
                Console.WriteLine($"{number} can fit in:");
                sbyte s;
                byte b;
                short sh;
                ushort us;
                int i;
                uint ui;

                if (sbyte.TryParse(number, out s))
                {
                    Console.WriteLine("* sbyte");
                }
                if (byte.TryParse(number, out b))
                {
                    Console.WriteLine("* byte");
                }
                if (short.TryParse(number, out sh))
                {
                    Console.WriteLine("* short");
                }
                if (ushort.TryParse(number, out us))
                {
                    Console.WriteLine("* ushort");
                }
                if
                    (int.TryParse(number, out i))
                {
                    Console.WriteLine("* int");
                }
                if
                    (uint.TryParse(number, out ui))
                {
                    Console.WriteLine("* uint");
                }
                Console.WriteLine("* long");
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
