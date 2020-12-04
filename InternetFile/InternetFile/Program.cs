using System;
using System.Collections.Generic;
using System.IO;

namespace InternetFile
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string path = @"C:\Users\henri\Documents\GitHub\Exercicios\InternetFile\text.txt";
            HashSet<FileData> a = new HashSet<FileData>();
            try
            {
                using (StreamReader srr = File.OpenText(path))
                {
                    while (!srr.EndOfStream)
                    {
                        string[] line = srr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime date = DateTime.Parse(line[1]);
                        a.Add(new FileData(name, date));
                    }
                    foreach(FileData fil in a)
                    {
                        Console.WriteLine(fil);
                    }
                    Console.WriteLine(a.Count);
                }

            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            
        }
    }
}
