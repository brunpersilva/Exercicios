using System;
using System.Collections.Generic;
using System.Linq;
using LinqEx.Entities;
using System.IO;
using System.Globalization;

namespace LinqEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\henri\Documents\GitHub\Exercicios\LinqEx\LinqEx\text.txt";
            List<Product> list = new List<Product>();
            try
            {
                using (StreamReader srr = File.OpenText(path))
                {
                    while (!(srr.EndOfStream))
                    {
                        string[] line = srr.ReadLine().Split(',');
                        string name = line[0];
                        double price = double.Parse(line[1]);
                        list.Add(new Product(name, price));

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
                
            }
        }
    }
}
