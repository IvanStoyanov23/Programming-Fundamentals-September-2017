using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            var strList = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                strList.Add(str[i]);
            }

            foreach (char c in strList)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }
            Console.WriteLine(sb);
        }
    }
}
