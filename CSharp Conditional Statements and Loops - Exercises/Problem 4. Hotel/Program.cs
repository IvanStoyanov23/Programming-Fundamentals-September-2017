using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var Month = Console.ReadLine().ToLower();
            var Nights = int.Parse(Console.ReadLine());

            var Studio = 0.00;
            var DoublePrice = 0.00;
            var Suite = 0.00;

            if (Month == "may" || Month == "october")
            {
                Studio = 50 * Nights;
                DoublePrice = 65 * Nights;
                Suite = 75 * Nights;
                if (Nights > 7)
                {
                    Studio = Studio - (Studio * 0.05);
                }
                if (Month == "october" && Nights > 7)
                {                  
                    Studio = (Studio / Nights) * (Nights - 1);
                }
            }
            if (Month == "june" || Month == "september")
            {
                Studio = 60 * Nights;
                DoublePrice = 72 * Nights;
                Suite = 82 * Nights;
                if (Nights > 14)
                {
                    DoublePrice = DoublePrice - (DoublePrice * 0.1);
                }
                if (Month == "september" && Nights > 7)
                {
                    Studio = (Studio / Nights) * (Nights - 1);
                }
            }
            if (Month == "july" || Month == "august" || Month == "december")
            {
                Studio = 68 * Nights;
                DoublePrice = 77 * Nights;
                Suite = 89 * Nights;
                if (Nights > 14)
                {
                    Suite = Suite - (Suite * 0.15);
                }
            }
            Console.WriteLine($"Studio: {Studio:f2} lv.");
            Console.WriteLine($"Double: {DoublePrice:f2} lv.");
            Console.WriteLine($"Suite: {Suite:f2} lv.");
        }
    }
}
