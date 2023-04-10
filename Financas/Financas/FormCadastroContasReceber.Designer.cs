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
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorReceberTextBoxContasReceber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descricaoTextBoxContasReceber = new System.Windows.Forms.TextBox();
            this.buttonBuscarContatoContasReceber = new System.Windows.Forms.Button();
            this.buttonSalvarCadastroContasReceber = new System.Windows.Forms.Button();
            this.buttonCancelarCadastroContasReceber = new System.Windows.Forms.Button();
            this.contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscarContato = new System.Windows.Forms.TextBox();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.formaPagamentoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscarBanco = new System.Windows.Forms.Button();
            this.buttonBuscarFormaPagamento = new System.Windows.Forms.Button();
            valorReceberLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            formaPagamentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valorReceberLabel
            // 
            valorReceberLabel.AutoSize = true;
            valorReceberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorReceberLabel.Location = new System.Drawing.Point(40, 112);
            valorReceberLabel.Name = "valorReceberLabel";
            valorReceberLabel.Size = new System.Drawing.Size(125, 16);
            valorReceberLabel.TabIndex = 1;
            valorReceberLabel.Text = "Valor a Receber:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(92, 327);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(82, 16);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descrição:";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatoLabel.Location = new System.Drawing.Point(316, 113);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(71, 16);
            contatoLabel.TabIndex = 10;
            contatoLabel.Text = "Devedor:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancoLabel.Location = new System.Drawing.Point(59, 235);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(55, 16);
            bancoLabel.TabIndex = 12;
            bancoLabel.Text = "Banco:";
            // 
            // formaPagamentoLabel
            // 
            formaPagamentoLabel.AutoSize = true;
            formaPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formaPagamentoLabel.Location = new System.Drawing.Point(316, 234);
            formaPagamentoLabel.Name = "formaPagamentoLabel";
            formaPagamentoLabel.Size = new System.Drawing.Size(138, 16);
            formaPagamentoLabel.TabIndex = 13;
            formaPagamentoLabel.Text = "Forma Pagamento:";
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(Models.ContasReceber);
            // 
            // valorReceberTextBoxContasReceber
            // 
            this.valorReceberTextBoxContasReceber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "ValorReceber", true));
            this.valorReceberTextBoxContasReceber.Location = new System.Drawing.Point(171, 109);
            this.valorReceberTextBoxContasReceber.Name = "valorReceberTextBoxContasReceber";
            this.valorReceberTextBoxContasReceber.Size = new System.Drawing.Size(103, 22);
            this.valorReceberTextBoxContasReceber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro de contas a receber";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descricaoTextBoxContasReceber
            // 
            this.descricaoTextBoxContasReceber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Descricao", true));
            this.descricaoTextBoxContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBoxContasReceber.Location = new System.Drawing.Point(180, 327);
            this.descricaoTextBoxContasReceber.Name = "descricaoTextBoxContasReceber";
            this.descricaoTextBoxContasReceber.Size = new System.Drawing.Size(411, 22);
            this.descricaoTextBoxContasReceber.TabIndex = 4;
            // 
            // buttonBuscarContatoContasReceber
            // 
            this.buttonBuscarContatoContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContatoContasReceber.Location = new System.Drawing.Point(581, 108);
            this.buttonBuscarContatoContasReceber.Name = "buttonBuscarContatoContasReceber";
            this.buttonBuscarContatoContasReceber.Size = new System.Drawing.Size(78, 23);
            this.buttonBuscarContatoContasReceber.TabIndex = 7;
            this.buttonBuscarContatoContasReceber.Text = "Buscar";
            this.buttonBuscarContatoContasReceber.UseVisualStyleBackColor = true;
            this.buttonBuscarContatoContasReceber.Click += new System.EventHandler(this.buttonBuscarContatoContasReceber_Click);
            // 
            // buttonSalvarCadastroContasReceber
            // 
            this.buttonSalvarCadastroContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroContasReceber.Location = new System.Drawing.Point(396, 406);
            this.buttonSalvarCadastroContasReceber.Name = "buttonSalvarCadastroContasReceber";
            this.buttonSalvarCadastroContasReceber.Size = new System.Drawing.Size(78, 23);
            this.buttonSalvarCadastroContasReceber.TabIndex = 8;
            this.buttonSalvarCadastroContasReceber.Text = "Salvar";
            this.buttonSalvarCadastroContasReceber.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastroContasReceber.Click += new System.EventHandler(this.buttonSalvarCadastroContasReceber_Click);
            // 
            // buttonCancelarCadastroContasReceber
            // 
            this.buttonCancelarCadastroContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastroContasReceber.Location = new System.Drawing.Point(488, 406);
            this.buttonCancelarCadastroContasReceber.Name = "buttonCancelarCadastroContasReceber";
            this.buttonCancelarCadastroContasReceber.Size = new System.Drawing.Size(103, 23);
            this.buttonCancelarCadastroContasReceber.TabIndex = 9;
            this.buttonCancelarCadastroContasReceber.Text = "Cancelar";
            this.buttonCancelarCadastroContasReceber.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastroContasReceber.Click += new System.EventHandler(this.buttonCancelarCadastroContasReceber_Click);
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataSource = typeof(Models.Contato);
            // 
            // textBoxBuscarContato
            // 
            this.textBoxBuscarContato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource, "Nome", true));
            this.textBoxBuscarContato.Location = new System.Drawing.Point(393, 109);
            this.textBoxBuscarContato.Name = "textBoxBuscarContato";
            this.textBoxBuscarContato.Size = new System.Drawing.Size(182, 22);
            this.textBoxBuscarContato.TabIndex = 10;

            this.textBoxBuscarContato.TextChanged += new System.EventHandler(this.textBoxBuscarContato_TextChanged);

            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatoLabel.Location = new System.Drawing.Point(316, 113);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(71, 16);
            contatoLabel.TabIndex = 10;
            contatoLabel.Text = "Devedor:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancoLabel.Location = new System.Drawing.Point(23, 235);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(55, 16);
            bancoLabel.TabIndex = 12;
            bancoLabel.Text = "Banco:";

            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Banco", true));
            this.bancoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bancoTextBox.Location = new System.Drawing.Point(75, 232);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(131, 22);
            this.bancoTextBox.TabIndex = 13;
            // 

            // formaPagamentoLabel
            // 
            formaPagamentoLabel.AutoSize = true;
            formaPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formaPagamentoLabel.Location = new System.Drawing.Point(311, 234);
            formaPagamentoLabel.Name = "formaPagamentoLabel";
            formaPagamentoLabel.Size = new System.Drawing.Size(160, 16);
            formaPagamentoLabel.TabIndex = 13;
            formaPagamentoLabel.Text = "Forma de Pagamento:";
            // 

            // formaPagamentoTextBox
            // 
            this.formaPagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "FormaPagamento", true));
            this.formaPagamentoTextBox.Location = new System.Drawing.Point(471, 232);
            this.formaPagamentoTextBox.Name = "formaPagamentoTextBox";
            this.formaPagamentoTextBox.Size = new System.Drawing.Size(115, 22);
            this.formaPagamentoTextBox.TabIndex = 14;
            // 
            // buttonBuscarBanco
            // 
            this.buttonBuscarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarBanco.Location = new System.Drawing.Point(213, 232);
            this.buttonBuscarBanco.Name = "buttonBuscarBanco";
            this.buttonBuscarBanco.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarBanco.TabIndex = 15;
            this.buttonBuscarBanco.Text = "Buscar";
            this.buttonBuscarBanco.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarFormaPagamento
            // 
            this.buttonBuscarFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarFormaPagamento.Location = new System.Drawing.Point(599, 232);
            this.buttonBuscarFormaPagamento.Name = "buttonBuscarFormaPagamento";
            this.buttonBuscarFormaPagamento.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarFormaPagamento.TabIndex = 16;
            this.buttonBuscarFormaPagamento.Text = "Buscar";
            this.buttonBuscarFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // FormCadastroContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 455);
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
    }
}