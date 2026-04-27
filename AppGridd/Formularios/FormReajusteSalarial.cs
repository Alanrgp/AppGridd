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
    public partial class FormReajusteSalarial : Form
    {
        public FormReajusteSalarial()
        {
            InitializeComponent();
            //bloqueia os campos para não serem editados
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtSalario.Enabled = false;
            txtReajuste.Enabled = false;
            txtSalarioReajustado.Enabled = false;
            txtMediaSalarial.Enabled = false;
            //habilita os botões e desabilita os outros
            btAdd.Enabled = true;
            btDeletar.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtSalario.Enabled = true;
            txtReajuste.Enabled = true;
            txtSalarioReajustado.Enabled = true;
            txtMediaSalarial.Enabled = true;
            //habilita os botões e desabilita os outros
            btAdd.Enabled = false;
            btDeletar.Enabled = false;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtSalario.Clear();
            txtReajuste.Clear();
            txtSalarioReajustado.Clear();

            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtSalario.Enabled = false;
            txtReajuste.Enabled = false;
            txtSalarioReajustado.Enabled = false;
            txtMediaSalarial.Enabled = false;

            btAdd.Enabled = true;
            btDeletar.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add
                (
                txtNome.Text,
                Convert.ToDouble(txtCpf.Text),
                Convert.ToDouble(txtSalario.Text.Substring(3)),
                Convert.ToDouble(txtReajuste.Text),
                Convert.ToDouble(txtSalarioReajustado.Text.Substring(3))
                );
            MediaSalarial();
            // limpara a pós salvar
            txtNome.Clear();
            txtCpf.Clear();
            txtSalario.Clear();
            txtReajuste.Clear();
            txtSalarioReajustado.Clear();

            // Bloqueia campos
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtSalario.Enabled = false;
            txtReajuste.Enabled = false;
            txtSalarioReajustado.Enabled = false;
            //Ativar e desativar
            btAdd.Enabled = true;
            btDeletar.Enabled = true;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
        }

        private void txtReajuste_Leave(object sender, EventArgs e)
        {
            
            double salario = Convert.ToDouble(txtSalario.Text.Substring(3));
            double taxa = Convert.ToDouble(txtReajuste.Text) / 100;
            double SalarioReajustado = (salario * taxa) + salario;
            txtSalarioReajustado.Text = SalarioReajustado.ToString("C2");

        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtSalario.Text);
            txtSalario.Text = valor.ToString("C2");
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int linha = dgvTabela.CurrentRow.Index;
            int quantLinhas = dgvTabela.RowCount;

            if (quantLinhas > 1)
            {
                DialogResult resposta = MessageBox.Show
                    (
                        "Desejá Excluir a Linha ? ","Menssagem",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question

                        
                    );
                if(resposta == DialogResult.Yes)
                {
                    dgvTabela.Rows.RemoveAt(linha);
                    MediaSalarial();
                }
            }



        }

        private void MediaSalarial()
        {
            double media = 0;
            double total = 0;
            double linha = 0;
            for (int i = 0; i < dgvTabela.Rows.Count-1; i++)
            {
                total = Convert.ToDouble(dgvTabela[4, i].Value) + total;
                linha++;
            }
            media = total/linha;
            txtMediaSalarial.Text = media.ToString("C2");
        }

    }
}
