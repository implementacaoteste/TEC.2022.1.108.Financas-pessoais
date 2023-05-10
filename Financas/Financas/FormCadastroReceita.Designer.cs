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
            this.receitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.dataEmissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            formaPagamentoLabel = new System.Windows.Forms.Label();
            dataEmissaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.BackColor = System.Drawing.SystemColors.Control;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(14, 200);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(91, 20);
            descricaoLabel.TabIndex = 12;
            descricaoLabel.Text = "Descrição:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.SystemColors.Control;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(18, 20);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(53, 20);
            valorLabel.TabIndex = 1;
            valorLabel.Text = "Valor:";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.BackColor = System.Drawing.SystemColors.Control;
            contatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatoLabel.Location = new System.Drawing.Point(342, 20);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(77, 20);
            contatoLabel.TabIndex = 3;
            contatoLabel.Text = "Devedor:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.BackColor = System.Drawing.SystemColors.Control;
            bancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancoLabel.Location = new System.Drawing.Point(14, 104);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(62, 20);
            bancoLabel.TabIndex = 6;
            bancoLabel.Text = "Banco:";
            // 
            // formaPagamentoLabel
            // 
            formaPagamentoLabel.AutoSize = true;
            formaPagamentoLabel.BackColor = System.Drawing.SystemColors.Control;
            formaPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formaPagamentoLabel.Location = new System.Drawing.Point(339, 104);
            formaPagamentoLabel.Name = "formaPagamentoLabel";
            formaPagamentoLabel.Size = new System.Drawing.Size(172, 20);
            formaPagamentoLabel.TabIndex = 9;
            formaPagamentoLabel.Text = "Forma de pagamento:";
            // 
            // dataEmissaoLabel
            // 
            dataEmissaoLabel.AutoSize = true;
            dataEmissaoLabel.BackColor = System.Drawing.SystemColors.Control;
            dataEmissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataEmissaoLabel.Location = new System.Drawing.Point(343, 200);
            dataEmissaoLabel.Name = "dataEmissaoLabel";
            dataEmissaoLabel.Size = new System.Drawing.Size(118, 20);
            dataEmissaoLabel.TabIndex = 14;
            dataEmissaoLabel.Text = "Data emissao:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitaBindingSource, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(14, 231);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(188, 22);
            this.textBoxDescricao.TabIndex = 13;
            this.textBoxDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDescricao_KeyDown);
            // 
            // receitaBindingSource
            // 
            this.receitaBindingSource.DataSource = typeof(Models.Receita);
            // 
            // textBoxGanhos
            // 
            this.textBoxGanhos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitaBindingSource, "Valor", true));
            this.textBoxGanhos.Location = new System.Drawing.Point(18, 41);
            this.textBoxGanhos.Name = "textBoxGanhos";
            this.textBoxGanhos.Size = new System.Drawing.Size(133, 22);
            this.textBoxGanhos.TabIndex = 2;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(436, 298);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(84, 36);
            this.buttonSalvar.TabIndex = 16;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(526, 298);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(106, 36);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de receita";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitaBindingSource, "Contato", true));
            this.contatoTextBox.Location = new System.Drawing.Point(342, 41);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.ReadOnly = true;
            this.contatoTextBox.Size = new System.Drawing.Size(200, 22);
            this.contatoTextBox.TabIndex = 4;
            this.contatoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contatoTextBox_KeyDown);
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitaBindingSource, "Banco", true));
            this.bancoTextBox.Location = new System.Drawing.Point(14, 129);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.ReadOnly = true;
            this.bancoTextBox.Size = new System.Drawing.Size(159, 22);
            this.bancoTextBox.TabIndex = 7;
            // 
            // formaPagamentoTextBox
            // 
            this.formaPagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitaBindingSource, "FormaPagamento", true));
            this.formaPagamentoTextBox.Location = new System.Drawing.Point(339, 129);
            this.formaPagamentoTextBox.Name = "formaPagamentoTextBox";
            this.formaPagamentoTextBox.ReadOnly = true;
            this.formaPagamentoTextBox.Size = new System.Drawing.Size(204, 22);
            this.formaPagamentoTextBox.TabIndex = 10;
            // 
            // buttonBuscarContatoReceita
            // 
            this.buttonBuscarContatoReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContatoReceita.Location = new System.Drawing.Point(548, 33);
            this.buttonBuscarContatoReceita.Name = "buttonBuscarContatoReceita";
            this.buttonBuscarContatoReceita.Size = new System.Drawing.Size(84, 36);
            this.buttonBuscarContatoReceita.TabIndex = 5;
            this.buttonBuscarContatoReceita.Text = "Buscar";
            this.buttonBuscarContatoReceita.UseVisualStyleBackColor = true;
            this.buttonBuscarContatoReceita.Click += new System.EventHandler(this.buttonBuscarContatoReceita_Click);
            // 
            // buttonBuscarBancoReceita
            // 
            this.buttonBuscarBancoReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarBancoReceita.Location = new System.Drawing.Point(179, 120);
            this.buttonBuscarBancoReceita.Name = "buttonBuscarBancoReceita";
            this.buttonBuscarBancoReceita.Size = new System.Drawing.Size(84, 36);
            this.buttonBuscarBancoReceita.TabIndex = 8;
            this.buttonBuscarBancoReceita.Text = "Buscar";
            this.buttonBuscarBancoReceita.UseVisualStyleBackColor = true;
            this.buttonBuscarBancoReceita.Click += new System.EventHandler(this.buttonBuscarBancoReceita_Click);
            // 
            // buttonBuscarFormaPagamentoReceita
            // 
            this.buttonBuscarFormaPagamentoReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarFormaPagamentoReceita.Location = new System.Drawing.Point(548, 120);
            this.buttonBuscarFormaPagamentoReceita.Name = "buttonBuscarFormaPagamentoReceita";
            this.buttonBuscarFormaPagamentoReceita.Size = new System.Drawing.Size(84, 36);
            this.buttonBuscarFormaPagamentoReceita.TabIndex = 11;
            this.buttonBuscarFormaPagamentoReceita.Text = "Buscar";
            this.buttonBuscarFormaPagamentoReceita.UseVisualStyleBackColor = true;
            this.buttonBuscarFormaPagamentoReceita.Click += new System.EventHandler(this.buttonBuscarFormaPagamentoReceita_Click);
            // 
            // dataEmissaoDateTimePicker
            // 
            this.dataEmissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receitaBindingSource, "DataEmissao", true));
            this.dataEmissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitaBindingSource, "DataEmissao", true));
            this.dataEmissaoDateTimePicker.Location = new System.Drawing.Point(343, 227);
            this.dataEmissaoDateTimePicker.Name = "dataEmissaoDateTimePicker";
            this.dataEmissaoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataEmissaoDateTimePicker.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.contatoTextBox);
            this.panel1.Controls.Add(dataEmissaoLabel);
            this.panel1.Controls.Add(this.textBoxDescricao);
            this.panel1.Controls.Add(this.dataEmissaoDateTimePicker);
            this.panel1.Controls.Add(descricaoLabel);
            this.panel1.Controls.Add(valorLabel);
            this.panel1.Controls.Add(this.buttonBuscarFormaPagamentoReceita);
            this.panel1.Controls.Add(this.textBoxGanhos);
            this.panel1.Controls.Add(this.buttonBuscarBancoReceita);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.buttonBuscarContatoReceita);
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(formaPagamentoLabel);
            this.panel1.Controls.Add(contatoLabel);
            this.panel1.Controls.Add(this.formaPagamentoTextBox);
            this.panel1.Controls.Add(this.bancoTextBox);
            this.panel1.Controls.Add(bancoLabel);
            this.panel1.Location = new System.Drawing.Point(33, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 351);
            this.panel1.TabIndex = 18;
            // 
            // FormCadastroReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(737, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroReceita";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de receita";
            this.Load += new System.EventHandler(this.FormCadastroReceita_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroReceita_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource receitaBindingSource;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxGanhos;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contatoTextBox;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.TextBox formaPagamentoTextBox;
        private System.Windows.Forms.Button buttonBuscarContatoReceita;
        private System.Windows.Forms.Button buttonBuscarBancoReceita;
        private System.Windows.Forms.Button buttonBuscarFormaPagamentoReceita;
        private System.Windows.Forms.DateTimePicker dataEmissaoDateTimePicker;
        private System.Windows.Forms.Panel panel1;
    }
}