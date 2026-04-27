using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGridd.Formularios;


namespace AppGridd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastroDeProdutos_Click(object sender, EventArgs e)
        {
            FormCadastroDeProduto form = new FormCadastroDeProduto();
            form.ShowDialog();
        }

        private void btCadastrarVeiculos_Click(object sender, EventArgs e)
        {
            FormCadastroDeVeiculos form = new FormCadastroDeVeiculos();
            form.ShowDialog();
        }

        private void btRegistraNotas_Click(object sender, EventArgs e)
        {
            FormRegistrarNotas form = new FormRegistrarNotas();
            form.ShowDialog();
        }

        private void btUsabilidade_Click(object sender, EventArgs e)
        {
            FormUsabilidade form = new FormUsabilidade();
            form.ShowDialog();
        }

        private void btRegistroNotas_Click(object sender, EventArgs e)
        {
            FormRegistroNotas form = new FormRegistroNotas();
            form.ShowDialog();
        }

        private void btReajuste_Click(object sender, EventArgs e)
        {
            FormReajusteSalarial form = new FormReajusteSalarial();
            form.ShowDialog();
        }
    }
}
