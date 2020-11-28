using System;
using System.Collections.Generic;
using System.IO;
using Ex2Danilo.Entities;
using System.Globalization;

namespace Ex2Danilo
{
    class Program
    {
        static void Main(string[] args)
        {

            string line;
            List<Emploeeys> list = new List<Emploeeys>();

            // Le o arquivo//
            StreamReader file =
                new StreamReader(@"C:\Users\Bruno\source\repos\Ex2Danilo\Ex2Danilo\Entities\Employees.txt");
            while ((line = file.ReadLine()) != null)
            {
                //Salva dados do arquivo em lista//
                string[] words = line.Split(',');
                list.Add(new Emploeeys(words[0], DateTime.Parse(words[1]), Double.Parse(words[2], CultureInfo.InvariantCulture), words[3]));
            }
            //Imprime no console conteudo da lista//
            file.Close();
            foreach (Emploeeys emploey in list)
            {
                Console.WriteLine(emploey);
            }
        }


      
    }
}
