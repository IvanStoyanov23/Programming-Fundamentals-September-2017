using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var property = Console.ReadLine();

            double result = 0;

           if (property == "face")
           {
             result = FaceOfCube(length);
           }
            else if (property == "space")
           {
               result = SpaceOfCube(length);
           }
           else if (property == "volume")
           {
               result = VolumeOfCube(length);
           }
           else if (property == "area")
           {
               result = AreaOfCube(length);
           }

            Console.WriteLine($"{result:f2}");
        }

        static double FaceOfCube(double length)
        {
            return Math.Sqrt(length * length * 2);
        }

        static double SpaceOfCube( double length)
        {
            return Math.Sqrt(3 * Math.Pow(length, 2));
        }

        static double VolumeOfCube(double length)
        {
           return Math.Pow(length, 3);
        }

        static double AreaOfCube(double length)
        {
            return 6 * Math.Pow(length, 2);
        }
    }
}
