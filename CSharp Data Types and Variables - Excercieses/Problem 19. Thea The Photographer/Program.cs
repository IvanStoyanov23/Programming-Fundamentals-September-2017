using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int takenPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            double filterPercentage = double.Parse(Console.ReadLine());
            int neededToUploadTime = int.Parse(Console.ReadLine());

            double usefulPictures = Math.Ceiling((takenPictures * filterPercentage) / 100);
            double Time = (double)takenPictures * filterTime;
            double uploadTime = usefulPictures * neededToUploadTime;

            var totalTime = Time + uploadTime;
            TimeSpan total = TimeSpan.FromSeconds(totalTime);

            string timeToString = total.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(timeToString);
        }
    }
}
