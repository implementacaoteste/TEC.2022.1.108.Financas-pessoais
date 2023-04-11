namespace Financas
{
    partial class FormCadastroReceita
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label contatoLabel;
            System.Windows.Forms.Label bancoLabel;
            System.Windows.Forms.Label formaPagamentoLabel;
            System.Windows.Forms.Label dataEmissaoLabel;
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxGanhos = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contatoTextBox = new System.Windows.Forms.TextBox();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.formaPagamentoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscarContatoReceita = new System.Windows.Forms.Button();
            this.buttonBuscarBancoReceita = new System.Windows.Forms.Button();
            this.buttonBuscarFormaPagamentoReceita = new System.Windows.Forms.Button();
            this.despesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataEmissaoTextBox = new System.Windows.Forms.TextBox();
            this.buttonDataEmissaoCadastroReceita = new System.Windows.Forms.Button();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            formaPagamentoLabel = new System.Windows.Forms.Label();
            dataEmissaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;

            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(58, 277);

            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(91, 20);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "Descrição:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;

            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(11, 120);

            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(53, 20);
            valorLabel.TabIndex = 3;
            valorLabel.Text = "Valor:";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;

            contatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatoLabel.Location = new System.Drawing.Point(316, 120);

            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(65, 20);
            contatoLabel.TabIndex = 13;
            contatoLabel.Text = "Credor:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;

            bancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancoLabel.Location = new System.Drawing.Point(6, 175);

            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(62, 20);
            bancoLabel.TabIndex = 14;
            bancoLabel.Text = "Banco:";



            // 
            // formaPagamentoLabel
            // 
            formaPagamentoLabel.AutoSize = true;

            formaPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formaPagamentoLabel.Location = new System.Drawing.Point(280, 177);

            formaPagamentoLabel.Name = "formaPagamentoLabel";
            formaPagamentoLabel.Size = new System.Drawing.Size(172, 20);
            formaPagamentoLabel.TabIndex = 15;

            formaPagamentoLabel.Text = "Forma de Pagamento:";
            

            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitaBindingSource, "Descricao", true));

            this.textBoxDescricao.Location = new System.Drawing.Point(157, 278);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(558, 22);
            this.textBoxDescricao.TabIndex = 2;
            // 
            // textBoxGanhos
            // 
            this.textBoxGanhos.Location = new System.Drawing.Point(65, 117);

            this.textBoxGanhos.Name = "textBoxGanhos";
            this.textBoxGanhos.Size = new System.Drawing.Size(133, 22);
            this.textBoxGanhos.TabIndex = 10;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(437, 376);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(538, 376);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 23);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";

            this.label1.Size = new System.Drawing.Size(670, 96);

            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastro de receita";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Contato", true));

            this.contatoTextBox.Location = new System.Drawing.Point(382, 117);

            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(154, 22);
            this.contatoTextBox.TabIndex = 14;
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Banco", true));

            this.bancoTextBox.Location = new System.Drawing.Point(65, 172);

            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(154, 22);
            this.bancoTextBox.TabIndex = 15;
            // 
            // formaPagamentoTextBox
            // 
            this.formaPagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "FormaPagamento", true));

            this.formaPagamentoTextBox.Location = new System.Drawing.Point(442, 175);

            this.formaPagamentoTextBox.Name = "formaPagamentoTextBox";
            this.formaPagamentoTextBox.Size = new System.Drawing.Size(187, 22);
            this.formaPagamentoTextBox.TabIndex = 16;
            // 
            // buttonBuscarContatoReceita
            // 
            this.buttonBuscarContatoReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContatoReceita.Location = new System.Drawing.Point(545, 136);
            this.buttonBuscarContatoReceita.Name = "buttonBuscarContatoReceita";
            this.buttonBuscarContatoReceita.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarContatoReceita.TabIndex = 17;
            this.buttonBuscarContatoReceita.Text = "Buscar";
            this.buttonBuscarContatoReceita.UseVisualStyleBackColor = true;
            this.buttonBuscarContatoReceita.Click += new System.EventHandler(this.buttonBuscarContatoReceita_Click);
            // 
            // buttonBuscarBancoReceita
            // 
            this.buttonBuscarBancoReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.buttonBuscarBancoReceita.Location = new System.Drawing.Point(188, 172);

            this.buttonBuscarBancoReceita.Name = "buttonBuscarBancoReceita";
            this.buttonBuscarBancoReceita.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarBancoReceita.TabIndex = 18;
            this.buttonBuscarBancoReceita.Text = "Buscar";
            this.buttonBuscarBancoReceita.UseVisualStyleBackColor = true;
            this.buttonBuscarBancoReceita.Click += new System.EventHandler(this.buttonBuscarBancoReceita_Click);
            // 
            // buttonBuscarFormaPagamentoReceita
            // 
            this.buttonBuscarFormaPagamentoReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.buttonBuscarFormaPagamentoReceita.Location = new System.Drawing.Point(575, 174);

            this.buttonBuscarFormaPagamentoReceita.Name = "buttonBuscarFormaPagamentoReceita";
            this.buttonBuscarFormaPagamentoReceita.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarFormaPagamentoReceita.TabIndex = 19;
            this.buttonBuscarFormaPagamentoReceita.Text = "Buscar";
            this.buttonBuscarFormaPagamentoReceita.UseVisualStyleBackColor = true;
            this.buttonBuscarFormaPagamentoReceita.Click += new System.EventHandler(this.buttonBuscarFormaPagamentoReceita_Click);
            // 
            // despesasBindingSource
            // 
            this.despesasBindingSource.DataSource = typeof(Models.Despesas);
            // 
            // receitaBindingSource
            // 
            this.receitaBindingSource.DataSource = typeof(Models.Receita);
            // 
            // dataEmissaoLabel
            // 
            dataEmissaoLabel.AutoSize = true;
            dataEmissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataEmissaoLabel.Location = new System.Drawing.Point(11, 224);
            dataEmissaoLabel.Name = "dataEmissaoLabel";
            dataEmissaoLabel.Size = new System.Drawing.Size(108, 16);
            dataEmissaoLabel.TabIndex = 20;
            dataEmissaoLabel.Text = "Data Emissao:";
            // 
            // dataEmissaoTextBox
            // 
            this.dataEmissaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitaBindingSource, "DataEmissao", true));
            this.dataEmissaoTextBox.Location = new System.Drawing.Point(127, 221);
            this.dataEmissaoTextBox.Name = "dataEmissaoTextBox";
            this.dataEmissaoTextBox.Size = new System.Drawing.Size(154, 22);
            this.dataEmissaoTextBox.TabIndex = 21;
            // 
            // buttonDataEmissaoCadastroReceita
            // 
            this.buttonDataEmissaoCadastroReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataEmissaoCadastroReceita.Location = new System.Drawing.Point(288, 224);
            this.buttonDataEmissaoCadastroReceita.Name = "buttonDataEmissaoCadastroReceita";
            this.buttonDataEmissaoCadastroReceita.Size = new System.Drawing.Size(75, 23);
            this.buttonDataEmissaoCadastroReceita.TabIndex = 22;
            this.buttonDataEmissaoCadastroReceita.Text = "Buscar";
            this.buttonDataEmissaoCadastroReceita.UseVisualStyleBackColor = true;
            this.buttonDataEmissaoCadastroReceita.Click += new System.EventHandler(this.buttonDataEmissaoCadastroReceita_Click);
            // 
            // FormCadastroReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(670, 391);
            this.Controls.Add(this.buttonDataEmissaoCadastroReceita);
            this.Controls.Add(dataEmissaoLabel);
            this.Controls.Add(this.dataEmissaoTextBox);

            this.Controls.Add(this.buttonBuscarFormaPagamentoReceita);
            this.Controls.Add(this.buttonBuscarBancoReceita);
            this.Controls.Add(this.buttonBuscarContatoReceita);
            this.Controls.Add(formaPagamentoLabel);
            this.Controls.Add(this.formaPagamentoTextBox);
            this.Controls.Add(bancoLabel);
            this.Controls.Add(this.bancoTextBox);
            this.Controls.Add(contatoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxGanhos);
            this.Controls.Add(valorLabel);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.textBoxDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroReceita";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de receita";
            this.Load += new System.EventHandler(this.FormCadastroReceita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource receitaBindingSource;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxGanhos;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource despesasBindingSource;
        private System.Windows.Forms.TextBox contatoTextBox;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.TextBox formaPagamentoTextBox;
        private System.Windows.Forms.Button buttonBuscarContatoReceita;
        private System.Windows.Forms.Button buttonBuscarBancoReceita;
        private System.Windows.Forms.Button buttonBuscarFormaPagamentoReceita;
        private System.Windows.Forms.TextBox dataEmissaoTextBox;
        private System.Windows.Forms.Button buttonDataEmissaoCadastroReceita;
    }
}