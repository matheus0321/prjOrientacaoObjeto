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
        public BindingSource dados = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dados.DataSource = Cliente.Todos();
            dataGridView1.DataSource = dados;

            txtCodigo.DataBindings.Add("Text", dados, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNome.DataBindings.Add("Text", dados, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTipo.DataBindings.Add("Text", dados, "Tipo", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpDataCadastro.DataBindings.Add("Text", dados, "DataCadastro", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ((Cliente)dados.Current).Gravar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            dados.Add(new Cliente());
            dados.MoveLast();
        }
    }
}