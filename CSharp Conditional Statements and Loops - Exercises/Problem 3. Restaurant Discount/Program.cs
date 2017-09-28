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
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var hallName = " ";
            var priceHall = 0.0;
            var pricePackage = 0.0;
            var p = 0.0;
            var totalPrice = 0.0;
            var price = 0.0;

            if (groupSize > 0 && groupSize < 50)
            {
                hallName = "Small Hall";
                priceHall = 2500;
                if (package == "Normal")

                {
                    p = 0.05;
                    pricePackage = 500;
                }
                else if (package == "Gold")
                {
                    p = 0.10;
                    pricePackage = 750;
                }
                else if (package == "Platinum")
                {
                    p = 0.15;
                    pricePackage = 1000;
                }

                totalPrice = (priceHall + pricePackage) - p * (pricePackage + priceHall);
                price = totalPrice / groupSize;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {price:F2}$");
            }
            else if (groupSize > 50 && groupSize < 100)
            {
                hallName = "Terrace";
                priceHall = 5000;
                if (package == "Normal")
                {
                    p = 0.05;
                    pricePackage = 500;
                }
                else if (package == "Gold")
                {
                    p = 0.10;
                    pricePackage = 750;
                }
                else if (package == "Platinum")
                {
                    p = 0.15;
                    pricePackage = 1000;
                }

                totalPrice = ((priceHall + pricePackage) - p * (pricePackage + priceHall));
                price = totalPrice / groupSize;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {price:F2}$");
            }
            else if (groupSize > 100 && groupSize < 120)
            {
                hallName = "Great Hall";
                priceHall = 7500;

                if (package == "Normal")
                {
                    p = 0.05;
                    pricePackage = 500;
                }
                else if (package == "Gold")
                {
                    p = 0.1;
                    pricePackage = 750;
                }
                else if (package == "Platinum")
                {
                    p = 0.15;
                    pricePackage = 1000;
                }

                totalPrice = ((priceHall + pricePackage) - p * (pricePackage + priceHall));
                price = totalPrice / groupSize;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {price:F2}$");
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
