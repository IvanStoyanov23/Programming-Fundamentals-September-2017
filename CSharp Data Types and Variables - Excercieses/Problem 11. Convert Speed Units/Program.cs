using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float Meters = float.Parse(Console.ReadLine());
            float Hour = float.Parse(Console.ReadLine());
            float Minutes = float.Parse(Console.ReadLine());
            float Seconds = float.Parse(Console.ReadLine());

            float Time = (Hour * 3600 + Minutes * 60 + Seconds);

            float meterPerSec = Meters / Time;
            float kilometersPerHour = (Meters / 1000) / (Time / 3600);
            float milesPerHour = (Meters / 1609) / (Time / 3600);

            Console.WriteLine("{0:0.#######}", meterPerSec);
            Console.WriteLine("{0:0.#######}", kilometersPerHour);
            Console.WriteLine("{0:0.#######}", milesPerHour);
        }
    }
}
