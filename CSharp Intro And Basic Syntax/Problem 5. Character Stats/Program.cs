using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var Name = Console.ReadLine();
            var CurrentHealth = int.Parse(Console.ReadLine());
            var TotalHealth = int.Parse(Console.ReadLine());
            var CurrentEnergy = int.Parse(Console.ReadLine());
            var TotalEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("|{0}{1}|",new string('|', CurrentHealth), new string('.', TotalHealth - CurrentHealth));
            Console.WriteLine("|{0}{1}|", new string('|', CurrentHealth), new string('.', TotalEnergy - CurrentEnergy));
        }
    }
}
