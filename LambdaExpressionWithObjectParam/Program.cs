using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionWithObjectParam
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }




    class Program
    {

        static void AdjustPrice( Book b, Func<Book, decimal> adjust)
        {
            adjust(b);
        }

        static void Main(string[] args)
        {

            Book oliver = new Book
            {
                Author = "Charles Dickens",
                Title = "Oliver Twist",
                Price = 14.95M,
                Date = new DateTime(1838)
            };

            // Show the regular price
            Console.WriteLine("Regular price: {0:C}", oliver.Price);

            // Reduce the price by 20% and show it again
            AdjustPrice(oliver, b => b.Price *= (decimal)(1.0 - 0.20));
            Console.WriteLine("Discount price: {0:C}", oliver.Price);
            // Set the price back to the regular price
            oliver.Price = 14.95M;

            // Reduce the price by 4 dollars and show it again
            AdjustPrice(oliver, b => b.Price -= 4.0M);
            Console.WriteLine("Discount price: {0:C}", oliver.Price);

        }
    }
}
