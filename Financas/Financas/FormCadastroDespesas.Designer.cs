namespace Financas
{
    partial class FormCadastroDespesas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label contatoLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.despesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxGastos = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.contatoTextBox = new System.Windows.Forms.TextBox();
            valorLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(34, 123);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(48, 16);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(116, 294);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(82, 16);
            descricaoLabel.TabIndex = 9;
            descricaoLabel.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de despesas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(389, 348);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(88, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(254, 348);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(78, 23);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // despesasBindingSource
            // 
            this.despesasBindingSource.DataSource = typeof(Models.Despesas);
            // 
            // textBoxGastos
            // 
            this.textBoxGastos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Gastos", true));
            this.textBoxGastos.Location = new System.Drawing.Point(93, 120);
            this.textBoxGastos.Name = "textBoxGastos";
            this.textBoxGastos.Size = new System.Drawing.Size(113, 22);
            this.textBoxGastos.TabIndex = 9;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(194, 291);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(352, 22);
            this.textBoxDescricao.TabIndex = 10;
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.Location = new System.Drawing.Point(538, 124);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(56, 16);
            contatoLabel.TabIndex = 10;
            contatoLabel.Text = "Contato:";
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Contato", true));
            this.contatoTextBox.Location = new System.Drawing.Point(600, 121);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(100, 22);
            this.contatoTextBox.TabIndex = 11;
            // 
            // FormCadastroDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 455);
            this.Controls.Add(contatoLabel);
            this.Controls.Add(this.contatoTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.textBoxGastos);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDespesas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de despesas";
            this.Load += new System.EventHandler(this.FormCadastroDespesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.BindingSource despesasBindingSource;
        private System.Windows.Forms.TextBox textBoxGastos;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox contatoTextBox;
    }
}