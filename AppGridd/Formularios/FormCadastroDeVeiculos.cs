using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGridd.Formularios
{
    public partial class FormCadastroDeVeiculos : Form
    {
        public FormCadastroDeVeiculos()
        {
            InitializeComponent();

            // botões ligados e desligados
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btDeletar.Enabled = true;
            //textbox desativados
            txtNome.Enabled = false;
            txtModelo.Enabled = false;
            txtPlaca.Enabled = false;
            txtAno.Enabled = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add(
                txtNome.Text,
                txtModelo.Text,
                txtPlaca.Text,
                Convert.ToInt32(txtAno.Text)
                );
            txtNome.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
            txtAno.Clear();


            //textbox desativados
            txtNome.Enabled = false;
            txtModelo.Enabled = false;
            txtPlaca.Enabled = false;
            txtAno.Enabled = false;

            // botões ligados e desligados
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btDeletar.Enabled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
            txtAno.Clear();

            txtNome.Enabled = false;
            txtModelo.Enabled = false;
            txtPlaca.Enabled = false;
            txtAno.Enabled = false;

            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btDeletar.Enabled = true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            //textbox desativados
            txtNome.Enabled = true;
            txtModelo.Enabled = true;
            txtPlaca.Enabled = true;
            txtAno.Enabled = true;

            // botões ligados e desligados
            btAdd.Enabled = false;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
            btDeletar.Enabled = false;
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int linhas = dgvTabela.CurrentRow.Index;//Selecionar linha
            int quantLinhas = dgvTabela.RowCount; // quantidade de linhas

            if(quantLinhas > 1)
            {
                DialogResult resposta = MessageBox.Show(
                    "Desejá realmente excluir? ", "Excluir ?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                
                if(resposta == DialogResult.Yes)
                {
                    dgvTabela.Rows.RemoveAt(linhas);
                }

            }
           


        }
    }
}
