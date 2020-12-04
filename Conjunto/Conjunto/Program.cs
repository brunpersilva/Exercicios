using System;
using System.Collections.Generic;
using System.Linq;

namespace Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> alunos = new HashSet<int>();
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                alunos.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("How many students for course B? ");
             n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                alunos.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                alunos.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Total de alunos: " + alunos.Count());
        }
    }
}
