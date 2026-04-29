namespace AppGridd
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastroDeProdutos = new System.Windows.Forms.Button();
            this.btCadastrarVeiculos = new System.Windows.Forms.Button();
            this.btRegistraNotas = new System.Windows.Forms.Button();
            this.btUsabilidade = new System.Windows.Forms.Button();
            this.btRegistroNotas = new System.Windows.Forms.Button();
            this.btReajuste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMULÁRIOS COM VETORES E USABILIDADE";
            // 
            // btCadastroDeProdutos
            // 
            this.btCadastroDeProdutos.BackColor = System.Drawing.Color.Coral;
            this.btCadastroDeProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroDeProdutos.Location = new System.Drawing.Point(128, 139);
            this.btCadastroDeProdutos.Name = "btCadastroDeProdutos";
            this.btCadastroDeProdutos.Size = new System.Drawing.Size(521, 47);
            this.btCadastroDeProdutos.TabIndex = 1;
            this.btCadastroDeProdutos.Text = "CADASTRO DE PRODUTOS";
            this.btCadastroDeProdutos.UseVisualStyleBackColor = false;
            this.btCadastroDeProdutos.Click += new System.EventHandler(this.btCadastroDeProdutos_Click);
            // 
            // btCadastrarVeiculos
            // 
            this.btCadastrarVeiculos.BackColor = System.Drawing.Color.Gold;
            this.btCadastrarVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarVeiculos.Location = new System.Drawing.Point(128, 192);
            this.btCadastrarVeiculos.Name = "btCadastrarVeiculos";
            this.btCadastrarVeiculos.Size = new System.Drawing.Size(521, 47);
            this.btCadastrarVeiculos.TabIndex = 2;
            this.btCadastrarVeiculos.Text = "CADASTRO DE VEÍCULOS";
            this.btCadastrarVeiculos.UseVisualStyleBackColor = false;
            this.btCadastrarVeiculos.Click += new System.EventHandler(this.btCadastrarVeiculos_Click);
            // 
            // btRegistraNotas
            // 
            this.btRegistraNotas.BackColor = System.Drawing.Color.LimeGreen;
            this.btRegistraNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistraNotas.Location = new System.Drawing.Point(128, 245);
            this.btRegistraNotas.Name = "btRegistraNotas";
            this.btRegistraNotas.Size = new System.Drawing.Size(521, 47);
            this.btRegistraNotas.TabIndex = 3;
            this.btRegistraNotas.Text = "REGISTRAR NOTAS";
            this.btRegistraNotas.UseVisualStyleBackColor = false;
            this.btRegistraNotas.Click += new System.EventHandler(this.btRegistraNotas_Click);
            // 
            // btUsabilidade
            // 
            this.btUsabilidade.BackColor = System.Drawing.Color.Tan;
            this.btUsabilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsabilidade.Location = new System.Drawing.Point(128, 298);
            this.btUsabilidade.Name = "btUsabilidade";
            this.btUsabilidade.Size = new System.Drawing.Size(521, 47);
            this.btUsabilidade.TabIndex = 4;
            this.btUsabilidade.Text = "EXEMPLO COM USABILIDADE";
            this.btUsabilidade.UseVisualStyleBackColor = false;
            this.btUsabilidade.Click += new System.EventHandler(this.btUsabilidade_Click);
            // 
            // btRegistroNotas
            // 
            this.btRegistroNotas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btRegistroNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistroNotas.Location = new System.Drawing.Point(128, 351);
            this.btRegistroNotas.Name = "btRegistroNotas";
            this.btRegistroNotas.Size = new System.Drawing.Size(521, 47);
            this.btRegistroNotas.TabIndex = 5;
            this.btRegistroNotas.Text = "REGISTRO DE NOTAS";
            this.btRegistroNotas.UseVisualStyleBackColor = false;
            this.btRegistroNotas.Click += new System.EventHandler(this.btRegistroNotas_Click);
            // 
            // btReajuste
            // 
            this.btReajuste.BackColor = System.Drawing.Color.Crimson;
            this.btReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReajuste.Location = new System.Drawing.Point(128, 404);
            this.btReajuste.Name = "btReajuste";
            this.btReajuste.Size = new System.Drawing.Size(521, 47);
            this.btReajuste.TabIndex = 6;
            this.btReajuste.Text = "REAJUSTE SALÁRIAL";
            this.btReajuste.UseVisualStyleBackColor = false;
            this.btReajuste.Click += new System.EventHandler(this.btReajuste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.btReajuste);
            this.Controls.Add(this.btRegistroNotas);
            this.Controls.Add(this.btUsabilidade);
            this.Controls.Add(this.btRegistraNotas);
            this.Controls.Add(this.btCadastrarVeiculos);
            this.Controls.Add(this.btCadastroDeProdutos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MENU INICIAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastroDeProdutos;
        private System.Windows.Forms.Button btCadastrarVeiculos;
        private System.Windows.Forms.Button btRegistraNotas;
        private System.Windows.Forms.Button btUsabilidade;
        private System.Windows.Forms.Button btRegistroNotas;
        private System.Windows.Forms.Button btReajuste;
    }
}

