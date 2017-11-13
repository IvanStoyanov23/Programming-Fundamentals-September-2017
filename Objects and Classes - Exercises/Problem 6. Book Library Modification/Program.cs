using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Book_Library_Modification
{
    class Program
    {
        class Books
        {
            public string title { get; set; }
            public string author { get; set; }
            public string publisher { get; set; }
            public DateTime releseDate { get; set; }
            public long ISBN { get; set; }
            public decimal price { get; set; }
        }
        class Library
        {
            public string Name { get; set; }
            public List<Books> Books { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var library = new Library()
            {
                Name = "Chicho Mitko's Library",
                Books = new List<Books>()
            };


            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();

                var Title = tokens[0];
                var Author = tokens[1];
                var Publisher = tokens[2];
                var ReleaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var Isbn = int.Parse(tokens[4]);
                var Price = decimal.Parse(tokens[5]);

                Books book = new Books
                {
                    title = Title,
                    author = Author,
                    publisher = Publisher,
                    releseDate = ReleaseDate,
                    ISBN = Isbn,
                    price = Price
                };
                library.Books.Add(book);

            }
            var afterThisDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var releseDate = new Dictionary<string, DateTime>();

            foreach (var book in library.Books)
            {
                releseDate[book.title] = book.releseDate;
            }

            releseDate = releseDate.Where(x => DateTime.Compare(x.Value, afterThisDate) > 0).OrderBy(date => date.Value).ThenBy(title => title.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var book in releseDate)
            {
                Console.WriteLine("{0} -> {1:F2}", book.Key,  book.Value.ToString("dd.MM.yyyy"));
            }
        }
    }
}
