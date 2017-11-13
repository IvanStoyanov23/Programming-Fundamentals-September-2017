using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine();

            double result = 0;

            switch (figureType)
            {
                case "triangle":
                    var triangleSide = double.Parse(Console.ReadLine());
                    var triangleHeight = double.Parse(Console.ReadLine());

                    result = AreaOfTriangle(triangleSide, triangleHeight);

                    break;

                case "square":
                    var squareSide = double.Parse(Console.ReadLine());

                    result = AreaOfSquare(squareSide);

                    break;
                case "rectangle":
                    var rectangleWidth = double.Parse(Console.ReadLine());
                    var rectangleHeight = double.Parse(Console.ReadLine());
                
                    result = AreaOfRectangle(rectangleWidth, rectangleHeight);
                
                    break;

                case "circle":
                    var circleRadius = double.Parse(Console.ReadLine());

                    result = AreaOfCircle(circleRadius);

                    break;
            }
            
            Console.WriteLine($"{result:f2}");
        }

        static double AreaOfTriangle(double triangleSide, double triangleHeight)
        {
            return (triangleSide * triangleHeight) / 2;
        }

        static double AreaOfSquare(double squareSide)
        {
            return squareSide * squareSide;
        }

        static double AreaOfRectangle(double rectangleWidth, double rectangleHeight)
        {
            return rectangleWidth * rectangleHeight;
        }

        static double AreaOfCircle(double circleRadius)
        {
            return Math.PI * circleRadius * circleRadius;
        }
    }
}
