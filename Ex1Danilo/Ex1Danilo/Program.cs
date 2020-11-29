using System;
using System.Globalization;
using System.Collections.Generic;
namespace Ex1Danilo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo para pagamento de funcionarios");
            Console.Write("Digite quantos funcionarios deseja cadastrar: ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> list = new List<Funcionario>();

            for (int c = 1; c <= n; c++)
            {
                Console.Write("Funcionario #" + c);
                Console.Write("Nome: ");               
                while (string.IsNullOrEmpty((Console.ReadLine())))
                {   
                    Console.Write("Digite algo por favor: ");
                }
                string name = Console.ReadLine();
                Console.Write("Salario Mensal: ");
                var salarioAsString = Console.ReadLine();
                double salario;
                while (!double.TryParse(salarioAsString, out salario) && salario < 0)
                {
                    Console.Write("Valor invalido: ");
                    salarioAsString = Console.ReadLine();
                }
                Console.Write("Dias Trabalhados: ");
                var diasAsString = Console.ReadLine();
                int dias;
                while (!int.TryParse(diasAsString, out dias) && dias < 0)
                {
                    Console.Write("Issonão é um numero, Tente novamente:  ");
                    diasAsString = Console.ReadLine();
                } 
                    
                list.Add(new Funcionario(name, salario, dias));

            }
            foreach (Funcionario funcionario in list)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}
