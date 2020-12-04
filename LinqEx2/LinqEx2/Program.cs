using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using LinqEx2.Entities;
using System.IO;

namespace LinqEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\henri\Documents\GitHub\Exercicios\LinqEx2\LinqEx2\text.txt";
            List<Client> list = new List<Client>();

            try
            {
                using (StreamReader str = File.OpenText(path))
                {
                    while (!str.EndOfStream)
                    {
                        string[] line = str.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
                        list.Add(new Client(name, email, salary));
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
                
            Console.Write("Enter salary: ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("Email of people whose salary is more than " + s);

            var q1 = list.Where(p => p.Salary > s).OrderBy(p => p.Email).Select(p => p.Email);
            var q2 = list.Where(p=> p.Name[0] == 'M').Sum(p => p.Salary);  

            foreach(string name in q1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine("Sum of salary of people whose name starts with 'M': "+ q2.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
