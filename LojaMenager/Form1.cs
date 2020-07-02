using Loja.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaMenager
{
    public partial class Form1 : Form
    {
        private BindingSource dados = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dados.DataSource = Cliente.Todos();

            dataGridView1.DataSource = dados;
        }
    }
}