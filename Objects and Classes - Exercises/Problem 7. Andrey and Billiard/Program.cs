using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Andrey_and_Billiard
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> BoughtItems { get; set; }
            public decimal Bill { get; set; }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var shop = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split('-');

                string product = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                if (!shop.ContainsKey(product))
                {
                    shop.Add(product, price);
                }
                else
                {
                    shop[product] = price;
                }
            }

            var line = Console.ReadLine();

            var clientsList = new List<Customer>();

            while (line != "end of clients")
            {
                var tokens = line.Split('-', ',').ToArray();

                var name = tokens[0];
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                var boughtItems = new Dictionary<string, int>();

                if (shop.ContainsKey(product))
                {
                    boughtItems[product] = 0;
                    boughtItems[product] += quantity;

                    var customer = new Customer()
                    {
                        Name = name,
                        BoughtItems = boughtItems,
                        Bill = shop[product] * quantity
                    };
                    clientsList.Add(customer);

                }
                line = Console.ReadLine();
            }

            clientsList = clientsList.OrderBy(client => client.Name).ToList();

            var totalBill = 0.0m;

            foreach (var client in clientsList)
            {
                Console.WriteLine("{0}", client.Name);

                foreach (var item in client.BoughtItems)
                {
                    Console.WriteLine("-- {0} - {1}", item.Key, item.Value);
                }
                Console.WriteLine("Bill: {0:f2}", client.Bill);
                totalBill += client.Bill;
            }
            Console.WriteLine("Total bill: {0:f2}", totalBill);
        }
    }
}
