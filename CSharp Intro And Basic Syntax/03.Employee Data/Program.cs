using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var Name = Console.ReadLine();
            var Age = int.Parse(Console.ReadLine());
            var ID = int.Parse(Console.ReadLine());
            var Salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Employee ID: {ID:D8}");
            Console.WriteLine($"Salary : {Salary:f2}");
        }
    }
}
