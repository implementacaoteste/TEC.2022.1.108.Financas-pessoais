namespace Financas
{
    partial class FormCadastroContasReceber
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
            System.Windows.Forms.Label valorReceberLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label contatoLabel;
            System.Windows.Forms.Label bancoLabel;
            System.Windows.Forms.Label formaPagamentoLabel;
            System.Windows.Forms.Label dataEmissaoLabel;
            this.valorReceberTextBoxContasReceber = new System.Windows.Forms.TextBox();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.descricaoTextBoxContasReceber = new System.Windows.Forms.TextBox();
            this.buttonBuscarContatoContasReceber = new System.Windows.Forms.Button();
            this.buttonSalvarCadastroContasReceber = new System.Windows.Forms.Button();
            this.buttonCancelarCadastroContasReceber = new System.Windows.Forms.Button();
            this.textBoxBuscarContato = new System.Windows.Forms.TextBox();
            this.contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.formaPagamentoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscarBanco = new System.Windows.Forms.Button();
            this.buttonBuscarFormaPagamento = new System.Windows.Forms.Button();
            this.dataEmissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            valorReceberLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            formaPagamentoLabel = new System.Windows.Forms.Label();
            dataEmissaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valorReceberLabel
            // 
            valorReceberLabel.AutoSize = true;
            valorReceberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorReceberLabel.Location = new System.Drawing.Point(65, 111);
            valorReceberLabel.Name = "valorReceberLabel";
            valorReceberLabel.Size = new System.Drawing.Size(129, 20);
            valorReceberLabel.TabIndex = 1;
            valorReceberLabel.Text = "Valor a receber:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(66, 299);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(91, 20);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descrição:";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatoLabel.Location = new System.Drawing.Point(311, 111);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(77, 20);
            contatoLabel.TabIndex = 10;
            contatoLabel.Text = "Devedor:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancoLabel.Location = new System.Drawing.Point(65, 193);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(62, 20);
            bancoLabel.TabIndex = 12;
            bancoLabel.Text = "Banco:";
            // 
            // formaPagamentoLabel
            // 
            formaPagamentoLabel.AutoSize = true;
            formaPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formaPagamentoLabel.Location = new System.Drawing.Point(311, 193);
            formaPagamentoLabel.Name = "formaPagamentoLabel";
            formaPagamentoLabel.Size = new System.Drawing.Size(174, 20);
            formaPagamentoLabel.TabIndex = 13;
            formaPagamentoLabel.Text = "Forma de Pagamento:";
            // 
            // dataEmissaoLabel
            // 
            dataEmissaoLabel.AutoSize = true;
            dataEmissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataEmissaoLabel.Location = new System.Drawing.Point(352, 296);
            dataEmissaoLabel.Name = "dataEmissaoLabel";
            dataEmissaoLabel.Size = new System.Drawing.Size(143, 20);
            dataEmissaoLabel.TabIndex = 16;
            dataEmissaoLabel.Text = "Data de Emissâo:";
            // 
            // valorReceberTextBoxContasReceber
            // 
            this.valorReceberTextBoxContasReceber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "ValorReceber", true));
            this.valorReceberTextBoxContasReceber.Location = new System.Drawing.Point(69, 134);
            this.valorReceberTextBoxContasReceber.Name = "valorReceberTextBoxContasReceber";
            this.valorReceberTextBoxContasReceber.Size = new System.Drawing.Size(164, 22);
            this.valorReceberTextBoxContasReceber.TabIndex = 2;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(Models.ContasReceber);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro de contas a receber";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descricaoTextBoxContasReceber
            // 
            this.descricaoTextBoxContasReceber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Descricao", true));
            this.descricaoTextBoxContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBoxContasReceber.Location = new System.Drawing.Point(69, 321);
            this.descricaoTextBoxContasReceber.Name = "descricaoTextBoxContasReceber";
            this.descricaoTextBoxContasReceber.Size = new System.Drawing.Size(180, 22);
            this.descricaoTextBoxContasReceber.TabIndex = 4;
            // 
            // buttonBuscarContatoContasReceber
            // 
            this.buttonBuscarContatoContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContatoContasReceber.Location = new System.Drawing.Point(538, 120);
            this.buttonBuscarContatoContasReceber.Name = "buttonBuscarContatoContasReceber";
            this.buttonBuscarContatoContasReceber.Size = new System.Drawing.Size(84, 36);
            this.buttonBuscarContatoContasReceber.TabIndex = 7;
            this.buttonBuscarContatoContasReceber.Text = "Buscar";
            this.buttonBuscarContatoContasReceber.UseVisualStyleBackColor = true;
            this.buttonBuscarContatoContasReceber.Click += new System.EventHandler(this.buttonBuscarContatoContasReceber_Click);
            // 
            // buttonSalvarCadastroContasReceber
            // 
            this.buttonSalvarCadastroContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroContasReceber.Location = new System.Drawing.Point(408, 389);
            this.buttonSalvarCadastroContasReceber.Name = "buttonSalvarCadastroContasReceber";
            this.buttonSalvarCadastroContasReceber.Size = new System.Drawing.Size(77, 36);
            this.buttonSalvarCadastroContasReceber.TabIndex = 8;
            this.buttonSalvarCadastroContasReceber.Text = "Salvar";
            this.buttonSalvarCadastroContasReceber.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastroContasReceber.Click += new System.EventHandler(this.buttonSalvarCadastroContasReceber_Click);
            // 
            // buttonCancelarCadastroContasReceber
            // 
            this.buttonCancelarCadastroContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastroContasReceber.Location = new System.Drawing.Point(505, 389);
            this.buttonCancelarCadastroContasReceber.Name = "buttonCancelarCadastroContasReceber";
            this.buttonCancelarCadastroContasReceber.Size = new System.Drawing.Size(87, 36);
            this.buttonCancelarCadastroContasReceber.TabIndex = 9;
            this.buttonCancelarCadastroContasReceber.Text = "Cancelar";
            this.buttonCancelarCadastroContasReceber.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastroContasReceber.Click += new System.EventHandler(this.buttonCancelarCadastroContasReceber_Click);
            // 
            // textBoxBuscarContato
            // 
            this.textBoxBuscarContato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource, "Nome", true));
            this.textBoxBuscarContato.Location = new System.Drawing.Point(315, 134);
            this.textBoxBuscarContato.Name = "textBoxBuscarContato";
            this.textBoxBuscarContato.Size = new System.Drawing.Size(217, 22);
            this.textBoxBuscarContato.TabIndex = 10;
            this.textBoxBuscarContato.TextChanged += new System.EventHandler(this.textBoxBuscarContato_TextChanged);
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataSource = typeof(Models.Contato);
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Banco", true));
            this.bancoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bancoTextBox.Location = new System.Drawing.Point(69, 216);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(131, 22);
            this.bancoTextBox.TabIndex = 13;
            // 
            // formaPagamentoTextBox
            // 
            this.formaPagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "FormaPagamento", true));
            this.formaPagamentoTextBox.Location = new System.Drawing.Point(315, 216);
            this.formaPagamentoTextBox.Name = "formaPagamentoTextBox";
            this.formaPagamentoTextBox.Size = new System.Drawing.Size(217, 22);
            this.formaPagamentoTextBox.TabIndex = 14;
            // 
            // buttonBuscarBanco
            // 
            this.buttonBuscarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarBanco.Location = new System.Drawing.Point(206, 206);
            this.buttonBuscarBanco.Name = "buttonBuscarBanco";
            this.buttonBuscarBanco.Size = new System.Drawing.Size(84, 36);
            this.buttonBuscarBanco.TabIndex = 15;
            this.buttonBuscarBanco.Text = "Buscar";
            this.buttonBuscarBanco.UseVisualStyleBackColor = true;
            this.buttonBuscarBanco.Click += new System.EventHandler(this.buttonBuscarBanco_Click);
            // 
            // buttonBuscarFormaPagamento
            // 
            this.buttonBuscarFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarFormaPagamento.Location = new System.Drawing.Point(538, 205);
            this.buttonBuscarFormaPagamento.Name = "buttonBuscarFormaPagamento";
            this.buttonBuscarFormaPagamento.Size = new System.Drawing.Size(84, 36);
            this.buttonBuscarFormaPagamento.TabIndex = 16;
            this.buttonBuscarFormaPagamento.Text = "Buscar";
            this.buttonBuscarFormaPagamento.UseVisualStyleBackColor = true;
            this.buttonBuscarFormaPagamento.Click += new System.EventHandler(this.buttonBuscarFormaPagamento_Click);
            // 
            // dataEmissaoDateTimePicker
            // 
            this.dataEmissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "DataEmissao", true));
            this.dataEmissaoDateTimePicker.Location = new System.Drawing.Point(356, 321);
            this.dataEmissaoDateTimePicker.Name = "dataEmissaoDateTimePicker";
            this.dataEmissaoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataEmissaoDateTimePicker.TabIndex = 17;
            // 
            // FormCadastroContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 455);
            this.Controls.Add(dataEmissaoLabel);
            this.Controls.Add(this.dataEmissaoDateTimePicker);
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.buttonBuscarFormaPagamento);
            this.Controls.Add(this.buttonBuscarBanco);
            this.Controls.Add(formaPagamentoLabel);
            this.Controls.Add(this.formaPagamentoTextBox);
            this.Controls.Add(bancoLabel);
            this.Controls.Add(this.bancoTextBox);
            this.Controls.Add(contatoLabel);
            this.Controls.Add(this.textBoxBuscarContato);
            this.Controls.Add(this.buttonCancelarCadastroContasReceber);
            this.Controls.Add(this.buttonSalvarCadastroContasReceber);
            this.Controls.Add(this.buttonBuscarContatoContasReceber);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBoxContasReceber);
            this.Controls.Add(this.label1);
            this.Controls.Add(valorReceberLabel);
            this.Controls.Add(this.valorReceberTextBoxContasReceber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroContasReceber";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro contas de contas a receber";
            this.Load += new System.EventHandler(this.FormCadastroContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.TextBox valorReceberTextBoxContasReceber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descricaoTextBoxContasReceber;
        private System.Windows.Forms.Button buttonBuscarContatoContasReceber;
        private System.Windows.Forms.Button buttonSalvarCadastroContasReceber;
        private System.Windows.Forms.Button buttonCancelarCadastroContasReceber;
        private System.Windows.Forms.BindingSource contatoBindingSource;
        private System.Windows.Forms.TextBox textBoxBuscarContato;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.TextBox formaPagamentoTextBox;
        private System.Windows.Forms.Button buttonBuscarBanco;
        private System.Windows.Forms.Button buttonBuscarFormaPagamento;
        private System.Windows.Forms.DateTimePicker dataEmissaoDateTimePicker;
    }
}