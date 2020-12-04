using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary.Entities;
using System.Data.SqlClient;

namespace Veterinary
{
    public partial class Form1 : Form
    {
        SqlConnection query = new SqlConnection(@"Data Source = ares\sqlexpress; Initial Catalog = veterinary; Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            Breeds breed = new Breeds();
            Dog dog1 = new Dog(textBoxName.Text, dateTimePickerBirth.Value, breed);
            dog1.Salvar(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = query.CreateCommand();
            //command.Parameters.


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
