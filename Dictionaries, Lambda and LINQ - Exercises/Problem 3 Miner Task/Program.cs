using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resource = new Dictionary<string, int>();

            var goldQuantity = 0;
            var silverQuantity = 0;
            var copperQuantity = 0;

            var line = Console.ReadLine();

            while (line != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());

                if (resource.ContainsKey(line))
                {
                    resource[line] += quantity;
                }
                else
                {
                    resource[line] = quantity;
                }
                

                line = Console.ReadLine();
            }

            foreach (var item in resource)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
