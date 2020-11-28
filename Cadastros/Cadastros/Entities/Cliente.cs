using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.Entities
{
    class Cliente
    {
        public string Nome { get; set; }

        public char Sexo { get; set; }

        public int Idade { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, char sexo, int idade)
        {
            Nome = nome;
            Sexo = sexo;
            Idade = idade;
        }
        public override string ToString()
        {
            return "Nome: "
                + Nome
                + ", Sexo: "
                + Sexo
                + ", Idade: "
                + Idade;
        }



    }

}
