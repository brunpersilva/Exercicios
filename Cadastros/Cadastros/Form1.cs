using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastros.Entities;

namespace Cadastros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string nome = textBoxName.Text;
            char sexo = char.Parse(textBoxSexo.Text);
            int idade = int.Parse(textBoxSexo.Text);
            Cliente judeu = new Cliente(nome,sexo,idade);

            labelresultado.Text = judeu;


        }
    }
}
