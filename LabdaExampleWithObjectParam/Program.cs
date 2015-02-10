using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabdaExampleWithObjectParam
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public decimal Price {get; set;}
        public void AdjustPrice(double x, Func<decimal, double, decimal> adjust)
        {
            Price = adjust(Price, x);
        }
    }




    class Program
    {
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
            oliver.AdjustPrice(0.20, (p, a) => {return p * (decimal)(1.0 - a);} );
            Console.WriteLine("Discount price: {0:C}", oliver.Price );
            // Set the price back to the regular price
            oliver.Price = 14.95M;

            // Reduce the price by 4 dollars and show it again
            oliver.AdjustPrice(4.0, (p, a) => { return p - (decimal)a; });
            Console.WriteLine("Discount price: {0:C}", oliver.Price);

        }
    }
}
