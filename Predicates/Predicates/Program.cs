using System;
using System.Collections.Generic;
using Predicates.Entities;
using System.Linq;
namespace Predicates
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


            Func<Product, string> func = NameUpper;
            List<String> result = list.Select(func).ToList();

            foreach(string p in result)
            {
                Console.WriteLine(p);
            }
            

            //Action<Product> act = UpdatePrice;

            //list.ForEach(act);
                
            //foreach (Product p in result)
            //{
            //    Console.WriteLine(p);
            //}

            //list.RemoveAll(Test);
            //foreach (Product item in list)
            //{
            //    Console.WriteLine(item);
            //}


        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
        //public static bool Test(Product p)
        //{
        //    return p.Price >= 100.0;

        //}


        //static void UpdatePrice(Product p)
        //{
        //    p.Price += p.Price * 0.1;
        //}
    }
}
