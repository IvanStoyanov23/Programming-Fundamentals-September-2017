using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var CurrentHealth = int.Parse(Console.ReadLine());
            var MaxHealth = int.Parse(Console.ReadLine());
            var CurrentEnergy = int.Parse(Console.ReadLine());
            var MaxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|', CurrentHealth)}{new string('.', MaxHealth - CurrentHealth)}|");
            Console.WriteLine($"Energy: |{new string('|', CurrentEnergy)}{new string('.', MaxEnergy - CurrentEnergy)}|");
        }
    }
}
