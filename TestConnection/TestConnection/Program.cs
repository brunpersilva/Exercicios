using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            string connstring = "Data Source=ares\\sqlexpress;Initial Catalog=exercicio;Integrated Security=True";

            SqlConnection qry = new SqlConnection(connstring);
            SqlCommand cmd = qry.CreateCommand();

            qry.Open();
            
            cmd.CommandText = "insert cliente (nome, idade, sexo) values ('Henrique', 26, 'M')";
            cmd.ExecuteNonQuery();
        }
    }
}
