using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailsDict = new Dictionary<string, string>();

            var name = Console.ReadLine();

            while (name != "stop")
            {
                var email = Console.ReadLine();
                var emailSplit = email.Split('.');

                var domain = (emailSplit[1] != "us" && emailSplit[1] != "uk");

                if (domain)
                {
                    emailsDict.Add(name, email);
                }

                name = Console.ReadLine();
            }

            foreach (var item in emailsDict)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
