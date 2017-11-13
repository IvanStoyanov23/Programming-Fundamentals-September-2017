using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var line = Console.ReadLine();


            while (line != "print")
            {
                var tokens = line.Split(' ');

                var command = tokens[0];

                if (command == "add")
                {
                    var index = int.Parse(tokens[1]);
                    var element = int.Parse(tokens[2]);

                    nums.Insert(index, element);
                }
                else if (command == "addMany")
                {
                    var index = int.Parse(tokens[1]);
                    var elements = new List<int>();

                    for (int i = 2; i < tokens.Length; i++)
                    {
                        var currentItem = int.Parse(tokens[i]);
                        elements.Add(currentItem);
                    }

                    nums.InsertRange(index, elements);
                }
                else if (command == "contains")
                {
                    var element = int.Parse(tokens[1]);
                    var index = -1;
                    if (nums.Contains(element))
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] == element)
                            {
                                index = i;
                                break;
                            }
                        }
                    }

                    Console.WriteLine(index);
                }
                else if (command == "remove")
                {
                    var index = int.Parse(tokens[1]);

                    nums.Remove(nums[index]);
                }
                else if (command == "shift")
                {
                    var position = int.Parse(tokens[1]) % nums.Count;

                    for (int i = 0; i < position; i++)
                    {
                        nums.Add(nums[0]);
                        nums.Remove(nums[0]);
                    }
                }
                else if (command == "sumPairs")
                {
                    var result = new List<int>();

                    for (int i = 0; i < nums.Count; i += 2)
                    {
                        var currentIndex = nums[i];
                        var nextIndex = 0;

                        if (i < nums.Count - 1)
                        {
                            nextIndex = nums[i + 1];
                        }

                        var elementSum = currentIndex + nextIndex;

                        result.Add(elementSum);
                    }

                    nums = result;
                }
                line = Console.ReadLine();

            }

            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }
    }
}
