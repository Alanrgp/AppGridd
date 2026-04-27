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
    public partial class FormCadastroDeProduto : Form
    {
        public FormCadastroDeProduto()
        {
            InitializeComponent();
            btSalvar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text.Substring(3); // Remove o símbolo de moeda (R$) do total
            dgvTabela.Rows.Add(
                txtDescricao.Text,
                Convert.ToDouble(txtValorUnitario.Text),
                Convert.ToInt32(txtQuantidade.Text),
                Convert.ToDouble(txtTotal.Text)
                );

            // Limpar os campos
            txtDescricao.Clear();
            txtValorUnitario.Clear();
            txtQuantidade.Clear();
            txtTotal.Clear();
            txtTotalGeral.Clear();
            txtDescricao.Select();
            Totalizar();
            btSalvar.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtValorUnitario.Clear();
            txtQuantidade.Clear();
            txtTotal.Clear();
            txtTotalGeral.Clear();
            txtDescricao.Select();
            btSalvar.Enabled = false;

        }// Limpar os campos

        private void button3_Click(object sender, EventArgs e)
        {
            int linhas = dgvTabela.CurrentRow.Index; //linha selecionada
            int quantLinhas = dgvTabela.Rows.Count; //quantidade de linhas

            if(quantLinhas > 1)
            {
                DialogResult resposta = 
                MessageBox.Show("DESEJÁ MESMO DELETAR A LINHA SELECIONADA?","EXCLUIR LINHA",// messagem e título
                MessageBoxButtons.YesNo,// opções de resposta sim ou não
                MessageBoxIcon.Question);// ícone de interrogação

                if (resposta == DialogResult.Yes)// se a resposta for sim
                {
                    dgvTabela.Rows.RemoveAt(linhas);// remove a linha selecionada
                    Totalizar();
                }
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {   // Calcular o total quando o campo de quantidade digitado
            txtValorUnitario.Text = txtValorUnitario.Text.Substring(3); // Remove o símbolo de moeda (R$) do valor unitário
            double valorUnitario = Convert.ToDouble(txtValorUnitario.Text);
            double quantidade = Convert.ToInt32(txtQuantidade.Text);
            double total = valorUnitario * quantidade;
            txtTotal.Text = total.ToString("C2");
            btSalvar.Enabled = true;
        }

        private void txtValorUnitario_Leave(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValorUnitario.Text);
            txtValorUnitario.Text = valor.ToString("C2");
        }

        private void Totalizar()
        {
            double total = 0;
            for (int i = 0; i < dgvTabela.RowCount; i++)
            {
                total = Convert.ToDouble(dgvTabela[3,i].Value ) + total;
            }
            txtTotalGeral.Text = total.ToString("C2");
        }


    }
}
