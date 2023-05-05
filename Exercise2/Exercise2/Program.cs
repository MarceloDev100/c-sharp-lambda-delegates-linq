using Exercise2.Entities;
using System.Globalization;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double informedSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] field = sr.ReadLine().Split(',');
                        string name = field[0];
                        string email = field[1];
                        double salary = double.Parse(field[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }

                Console.WriteLine("Email of people whose salary is higher than " + informedSalary.ToString("F2", CultureInfo.InvariantCulture) +  ": ");
                var emails = list.Where(e => e.Salary > informedSalary).OrderBy(e => e.Email).Select(e => e.Email);
                foreach(string email in emails)
                {
                    Console.WriteLine(email);
                }

                Console.Write("Salaries sum of people whose name starts with 'M': ");
                //double sum = list.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Aggregate(0.0, (x, y) => x + y);
                double sum = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}