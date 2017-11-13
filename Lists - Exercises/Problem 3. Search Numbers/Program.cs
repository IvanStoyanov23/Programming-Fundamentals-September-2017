using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Search_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var manipulations = Console.ReadLine()
                .Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var currentElements = new List<int>();

            var takeElement = manipulations[0];
            var deleteElement = manipulations[1];
            var searchElement = manipulations[2];

            for (int i = 0; i < takeElement; i++)
            {
                currentElements.Add(nums[i]);

            }
            for (int i = 0; i < deleteElement; i++)
            {
                currentElements[i] = 0;
            }
            //currentElements.Remove(currentElements[deleteElement]);

            bool isFound = false;

            for (int i = 0; i < currentElements.Count; i++)
            {
                if (currentElements[i] == searchElement)
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
