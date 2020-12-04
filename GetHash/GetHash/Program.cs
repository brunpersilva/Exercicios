using System;
using GetHash.Entities;
namespace GetHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client() { Name = "Maria", Email = "maria@gmail" };
            Client b = new Client() { Name = "Alex", Email = "maria@gmail" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}
