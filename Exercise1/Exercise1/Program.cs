using Exercise1.Entities;
using System.Globalization;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);

                        Product prod = new Product(name, price);
                        list.Add(prod);
                    }
                }

                double average = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Average price: " + average.ToString("F2", CultureInfo.InvariantCulture));

                var names = list.Where(p => p.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name);
                
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}