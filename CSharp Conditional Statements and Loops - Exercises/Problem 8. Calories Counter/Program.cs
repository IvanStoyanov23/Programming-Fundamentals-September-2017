using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = int.Parse(Console.ReadLine());
            var calories = 0;

            var Cheese = 500;
            var TomatoSauce = 150;
            var Salami = 600;
            var Pepper = 50;
            for (int i = 0; i < products; i++)
            {
                var ProductName = Console.ReadLine().ToLower();
                switch (ProductName)
                {
                    case "cheese":
                        calories = Cheese + calories;
                        break;
                    case "tomato sauce":
                        calories = TomatoSauce + calories;
                        break;
                    case "salami":
                        calories = Salami + calories;
                        break;
                    case "pepper":
                        calories = Pepper + calories;
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}