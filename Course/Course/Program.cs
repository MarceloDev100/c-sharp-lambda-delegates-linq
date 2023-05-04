using Course.Entities;

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
               removes from the list only those whose minimum price is 100.00
             */

            
            // Predicate
            // - Predicate is a delegate (a reference to a function).
            // - The function must return a boolean and receives an object as parameter.
            // - The function may also be a lambda expression.


            // Using lambda expression as predicate
            // list.RemoveAll(p => p.Price >= 100.00);

            list.RemoveAll(ProductTest);

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}