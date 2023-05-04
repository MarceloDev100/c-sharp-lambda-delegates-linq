using Course.Entities;
using System.Net;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));


            /*
               Write a program that, from a list of products,
               increases the price of products by 10%
             */

            // Action
            // - Represents a delegate.
            // - It's a void method that receives zero or more arguments


            /* Inline lambda expression  */
            list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}