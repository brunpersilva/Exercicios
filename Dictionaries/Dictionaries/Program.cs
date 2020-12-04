using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> votos = new Dictionary<string, int>();
            string path = @"C:\Users\henri\Documents\GitHub\Exercicios\Dictionaries\Dictionaries\text.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                       
                        string candidate = line[0];
                        int votes = int.Parse(line[1]);

                        if (votos.ContainsKey(candidate))
                        {
                            votos[candidate] += votes;
                        }
                        else
                        {
                            votos[candidate] = votes;
                        }
                    }
                    
                }
                Console.WriteLine("Candidato e votos: ");
                foreach(var item in votos)
                {
                    Console.WriteLine(item.Key +": " + item.Value);
                }
            }


            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
