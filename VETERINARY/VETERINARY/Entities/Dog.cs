using System;
using System.Data;
using System.Data.SqlClient;
using Veterinary;

namespace Veterinary.Entities
{
    class Dog
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public Breeds Breed { get; set; }
        public Dog()
        {
        }

        public Dog(string name, DateTime birth, Breeds breed)
        {
            Name = name;
            Birth = birth;
            Breed = breed;
        }

        public void Salvar(SqlConnection query)
        {
            SqlCommand command = query.CreateCommand();
            query.Open();
            command.CommandText = "insert into dog values(@Name, @Birth, 1)";
            command.Parameters.Add("@Name", SqlDbType.VarChar);
            command.Parameters.Add("@Birth", SqlDbType.DateTime2);
            command.Parameters["@Name"].Value = Name;
            command.Parameters["@Birth"].Value = Birth;
            command.ExecuteNonQuery();        
            query.Close();
            query.Dispose();
        }

    }
}
