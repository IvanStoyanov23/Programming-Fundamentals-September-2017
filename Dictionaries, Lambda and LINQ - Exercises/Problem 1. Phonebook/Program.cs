using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();

            var line = Console.ReadLine();


            while (line != "END")
            {
                var tokens = line.Split();

                var command = tokens[0];

                // ADDS ENTRY
                if (command == "A")
                {
                    var key = tokens[1];
                    var value = tokens[2];
                    phonebook[key] = value;
                }

                //SEARCH FOR 
                else if (command == "S")
                {
                    var key = tokens[1];

                    if (phonebook.ContainsKey(key))
                    {
                        Console.WriteLine("{0} -> {1}", key, phonebook[key]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", key);
                    }
                }
                else if (command == "ListAll")
                {
                    

                    foreach (var item in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                    }
                }

                line = Console.ReadLine();
            }
        }
    }
}
