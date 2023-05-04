﻿using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));


            /*
              Write a program that, from a products list, 
              generates a new list containing the names of products in uppercase.
             */

            // Func (System)
            // - Represents a delegate
            // - It's a method that returns a value and receives zero or more arguments.

           
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string p in result)
            {
                Console.WriteLine(p);
            }
        }
    }
}