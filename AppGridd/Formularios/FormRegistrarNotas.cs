using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGridd.Formularios
{
    public partial class FormRegistrarNotas : Form
    {
        public FormRegistrarNotas()//Inicio
        {
            InitializeComponent();
            //bloqueia os campos para não serem editados
            txtNome.Enabled = false;
            txtNota1.Enabled = false;
            txtNota2.Enabled = false;
            txtMedia.Enabled = false;
            txtMediaGeral.Enabled = false;
            //habilita os botões e desabilita os outros
            btAdd.Enabled = true;
            btDeletar.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)//adicionar uma nova linha
        {
            // desbloqueia os campos para serem editados
            txtNome.Enabled = true;
            txtNota1.Enabled = true;
            txtNota2.Enabled = true;
            txtMedia.Enabled = true;
            txtMediaGeral.Enabled = true;
            // habilita os botões e desabilita os outros
            btAdd.Enabled = false;
            btDeletar.Enabled = false;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)//limpar os campos
        {
            DialogResult resposta = MessageBox.Show("Desejá Cancelar ? ", "Menssagem",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );


            if (resposta == DialogResult.Yes)
            {
                //bloqueia os campos para não serem editados
                txtNome.Enabled = false;
                txtNota1.Enabled = false;
                txtNota2.Enabled = false;
                txtMedia.Enabled = false;
                txtMediaGeral.Enabled = false;
                //Limpar
                txtNome.Clear();
                txtNota1.Clear();
                txtNota2.Clear();
                txtMedia.Clear();
                // Ativa 
                btAdd.Enabled = true;
                btDeletar.Enabled = true;
                btCancelar.Enabled = false;
                btSalvar.Enabled = false;
            }

        }

        private void btDeletar_Click(object sender, EventArgs e)//deletar a linha selecionada
        {
            int linha = dgvTabela.CurrentRow.Index;//linha selecionada
            int quantLinhas = dgvTabela.Rows.Count;//quantidade de linhas

            if (quantLinhas > 1)
            {
                DialogResult resposta = 
                MessageBox.Show("DESEJÁ REALMENTE DELETAR ESSA LINHA", "MENSSAGEM",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
                if(resposta == DialogResult.Yes)
                {
                    dgvTabela.Rows.RemoveAt(linha);
                    MediaGeral();
                    btAdd.Enabled=true;
                }
            }

        }

        private void txtNota2_Leave(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double media = (nota1 + nota2) / 2;
            txtMedia.Text = media.ToString();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add(
                txtNome.Text,
                Convert.ToDouble(txtNota1.Text),
                Convert.ToDouble(txtNota2.Text),
                Convert.ToDouble(txtMedia.Text)
                );
            // Limpar os campos
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtMedia.Clear();
            btSalvar.Enabled = false;
            btDeletar.Enabled = true;
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            MediaGeral();

        }


        private void MediaGeral()
        {
            double total = 0;
            double media = 0;
            double linha = 0;
            for (int i = 0; i < dgvTabela.Rows.Count-1; i++)
            {
                total = Convert.ToDouble(dgvTabela[3, i].Value) + total;
                linha++;
            }
            media = total/ linha;
            txtMediaGeral.Text = media.ToString("F2");
        }
    }
}
