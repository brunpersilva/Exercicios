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
            string connstring = "Data Source=ares\\sqlexpress;Initial Catalog=exercicio;Integrated Security=True";

            SqlConnection qry = new SqlConnection(connstring);

            qry.Open();
            string insert = "insert cliente (nome, idade, sexo) values ('Bruno', 25, 'M')";

            SqlCommand cmd = new SqlCommand(insert, qry);
            
            cmd.ExecuteNonQuery();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
