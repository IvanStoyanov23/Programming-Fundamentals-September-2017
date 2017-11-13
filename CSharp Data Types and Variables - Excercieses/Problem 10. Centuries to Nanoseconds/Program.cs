using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var century = int.Parse(Console.ReadLine());

            int year = century * 100;
            int days = (int)(year * 365.2422);
            int hours = days * 24;
            decimal minutes = hours * 60;
            decimal seconds = minutes * 60;
            decimal milliseconds = seconds * 1000;
            decimal microseconds = seconds * 1000000;
            decimal nanoseconds =  seconds *1000000000;

            Console.WriteLine($"{century} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
