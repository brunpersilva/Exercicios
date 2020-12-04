using System;
using HashSets.Entities;
using System.Collections.Generic;

namespace HashSets

{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();

            a.Add(new Product("TV0", 900.0));
            a.Add(new Product("Notebook", 1200));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(3, 4);
            Console.WriteLine(b.Contains(p));

        }
    }
}
