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
            System.Windows.Forms.Label bancoLabel;
            System.Windows.Forms.Label formaPagamentoLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.despesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxGastos = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.contatoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscarContatoDespesas = new System.Windows.Forms.Button();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.formaPagamentoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscarFormaPagamentoDespesas = new System.Windows.Forms.Button();
            valorLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            formaPagamentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(58, 112);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(53, 20);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(58, 277);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(91, 20);
            descricaoLabel.TabIndex = 9;
            descricaoLabel.Text = "Descrição:";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatoLabel.Location = new System.Drawing.Point(381, 112);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(65, 20);
            contatoLabel.TabIndex = 10;
            contatoLabel.Text = "Credor:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancoLabel.Location = new System.Drawing.Point(381, 190);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(62, 20);
            bancoLabel.TabIndex = 12;
            bancoLabel.Text = "Banco:";
            // 
            // formaPagamentoLabel
            // 
            formaPagamentoLabel.AutoSize = true;
            formaPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formaPagamentoLabel.Location = new System.Drawing.Point(58, 190);
            formaPagamentoLabel.Name = "formaPagamentoLabel";
            formaPagamentoLabel.Size = new System.Drawing.Size(174, 20);
            formaPagamentoLabel.TabIndex = 14;
            formaPagamentoLabel.Text = "Forma de Pagamento:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de despesas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(538, 376);
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
            this.buttonSalvar.Location = new System.Drawing.Point(437, 376);
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
            this.textBoxGastos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Valor", true));
            this.textBoxGastos.Location = new System.Drawing.Point(62, 135);
            this.textBoxGastos.Name = "textBoxGastos";
            this.textBoxGastos.Size = new System.Drawing.Size(133, 22);
            this.textBoxGastos.TabIndex = 9;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(62, 300);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(558, 22);
            this.textBoxDescricao.TabIndex = 10;
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Contato", true));
            this.contatoTextBox.Location = new System.Drawing.Point(385, 135);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(154, 22);
            this.contatoTextBox.TabIndex = 11;
            // 
            // buttonBuscarContatoDespesas
            // 
            this.buttonBuscarContatoDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContatoDespesas.Location = new System.Drawing.Point(545, 135);
            this.buttonBuscarContatoDespesas.Name = "buttonBuscarContatoDespesas";
            this.buttonBuscarContatoDespesas.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarContatoDespesas.TabIndex = 12;
            this.buttonBuscarContatoDespesas.Text = "Buscar";
            this.buttonBuscarContatoDespesas.UseVisualStyleBackColor = true;
            this.buttonBuscarContatoDespesas.Click += new System.EventHandler(this.buttonBuscarContatoDespesas_Click);
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Banco", true));
            this.bancoTextBox.Location = new System.Drawing.Point(385, 212);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(154, 22);
            this.bancoTextBox.TabIndex = 13;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(545, 211);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 14;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // formaPagamentoTextBox
            // 
            this.formaPagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "FormaPagamento", true));
            this.formaPagamentoTextBox.Location = new System.Drawing.Point(62, 213);
            this.formaPagamentoTextBox.Name = "formaPagamentoTextBox";
            this.formaPagamentoTextBox.Size = new System.Drawing.Size(187, 22);
            this.formaPagamentoTextBox.TabIndex = 15;
            // 
            // buttonBuscarFormaPagamentoDespesas
            // 
            this.buttonBuscarFormaPagamentoDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarFormaPagamentoDespesas.Location = new System.Drawing.Point(255, 213);
            this.buttonBuscarFormaPagamentoDespesas.Name = "buttonBuscarFormaPagamentoDespesas";
            this.buttonBuscarFormaPagamentoDespesas.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarFormaPagamentoDespesas.TabIndex = 16;
            this.buttonBuscarFormaPagamentoDespesas.Text = "Buscar";
            this.buttonBuscarFormaPagamentoDespesas.UseVisualStyleBackColor = true;
            this.buttonBuscarFormaPagamentoDespesas.Click += new System.EventHandler(this.buttonBuscarFormaPagamentoDespesas_Click);
            // 
            // FormCadastroDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(705, 424);
            this.Controls.Add(this.buttonBuscarFormaPagamentoDespesas);
            this.Controls.Add(formaPagamentoLabel);
            this.Controls.Add(this.formaPagamentoTextBox);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(bancoLabel);
            this.Controls.Add(this.bancoTextBox);
            this.Controls.Add(this.buttonBuscarContatoDespesas);
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
        private System.Windows.Forms.Button buttonBuscarContatoDespesas;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox formaPagamentoTextBox;
        private System.Windows.Forms.Button buttonBuscarFormaPagamentoDespesas;
    }
}