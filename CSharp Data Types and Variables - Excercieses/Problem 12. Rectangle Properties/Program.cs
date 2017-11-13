using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double Height = double.Parse(Console.ReadLine());
            double Width = double.Parse(Console.ReadLine());

            double Area = Height * Width;
            double Perimeter = 2 * ( Height + Width);
            double squareHeight = Math.Pow(Height, 2);
            double squareWidth = Math.Pow(Width, 2);
            double Diagonal = Math.Sqrt(squareHeight + squareWidth);

            Console.WriteLine(Perimeter);
            Console.WriteLine(Area);
            Console.WriteLine(Diagonal);
        }
    }
}
