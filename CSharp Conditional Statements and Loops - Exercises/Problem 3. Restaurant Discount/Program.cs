using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var People = int.Parse(Console.ReadLine());
            var Package = Console.ReadLine();
            var Price = 0.00;
            var discount = 0.00;

            if (People <= 50 && Package == "Normal")
            {
                Price = (2500 + 500);
                discount = Price * 0.05;
                Price = (Price - discount) / People;
                Console.WriteLine($"We can offer you the Small Hall The price per person is { Price:f2}$");
            }
            else if (People <= 50 && Package == "Gold")
            {
                Price = (2500 + 750);
                discount = Price * 0.1;
                Price = (Price - discount) / People;
                Console.WriteLine($"We can offer you the Small Hall The price per person is { Price:f2}$");
            }
            else if (People <= 50 && Package == "Platinum")
            {
                Price = (2500 + 1000);
                discount = Price * 0.15;
                Price = (Price - discount) / People;
                Console.WriteLine($"We can offer you the Small Hall The price per person is { Price:f2}$");
            }
            if (People > 50  && People <= 100 && Package == "Normal")
            {
                Price = (5000 + 500);
                discount = Price * 0.05;
                Price = (Price - discount) / People;
                Console.WriteLine($"We can offer you the Terrace The price per person is { Price:f2}$");
            }
            else if (People > 50 && People <= 100 && Package == "Gold")
            {
                Price = (5000 + 750);
                discount = Price * 0.1;
                Price = (Price - discount) / People;
                Console.WriteLine($"We can offer you the Terrace The price per person is { Price:f2}$");
            }
            else if (People > 50 && People <= 100 && Package == "Platinum")
            {
                Price = (5000 + 1000);
                discount = Price * 0.15;
                Price = (Price - discount) / People;
                Console.WriteLine($"We can offer you the Terrace The price per person is { Price:f2}$");
            }
            if (People > 100 && People <= 120 && Package == "Normal")
            {
                Price = (5000 + 500);
                discount = Price * 0.05;
                Price = (Price - discount) / People;
                Console.WriteLine($"We can offer you the Great Hall The price per person is { Price:f2}$");
            }
            else if (People > 100 && People <= 120 && Package == "Gold")
            {
                Price = (5000 + 750);
                discount = Price * 0.1;
                Price = (Price - discount) / People;
                Console.WriteLine($"We can offer you the Great Hall The price per person is { Price:f2}$");
            }
            else if (People > 100 && People <= 120 && Package == "Platinum")
            {
                Price = (5000 + 1000);
                discount = Price * 0.15;
                Price = (Price - discount) / People;
                Console.WriteLine($"We can offer you the Great Hall The price per person is { Price:f2}$");
            }
            if (People > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
