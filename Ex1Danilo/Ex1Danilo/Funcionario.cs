using System.Globalization;
using System;

namespace Ex1Danilo
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioMensal { get; set; }

        public int DiasTrabalhados { get; set; }

        public double SalarioReceber()
        {
            return (SalarioMensal / 30) * DiasTrabalhados;
        }

        public Funcionario(string nome, double salarioMensal, int diasTrabalhados)
        {
            Nome = nome;
            SalarioMensal = salarioMensal;
            DiasTrabalhados = diasTrabalhados;
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + SalarioMensal.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + DiasTrabalhados
                + " dias trabalhados , Total A pagar: $ "
                + SalarioReceber().ToString("F2", CultureInfo.InvariantCulture);
        }
        

    }
}
