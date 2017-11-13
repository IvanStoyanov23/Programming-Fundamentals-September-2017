using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            int writeAfterP = int.Parse(Console.ReadLine());

            //const char Search = (char)112;
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;

                    int endIndex = writeAfterP + 1;

                    if (endIndex + i > text.Length)
                    {
                        endIndex = text.Length - i;
                    }

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += writeAfterP - 1;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
