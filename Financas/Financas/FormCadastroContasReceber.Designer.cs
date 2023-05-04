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
            this.panel1 = new System.Windows.Forms.Panel();
            valorReceberLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            formaPagamentoLabel = new System.Windows.Forms.Label();
            dataEmissaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valorReceberLabel
            // 
            valorReceberLabel.AutoSize = true;
            valorReceberLabel.BackColor = System.Drawing.SystemColors.Control;
            valorReceberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorReceberLabel.Location = new System.Drawing.Point(40, 11);
            valorReceberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valorReceberLabel.Name = "valorReceberLabel";
            valorReceberLabel.Size = new System.Drawing.Size(110, 17);
            valorReceberLabel.TabIndex = 1;
            valorReceberLabel.Text = "Valor a receber:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.BackColor = System.Drawing.SystemColors.Control;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(40, 163);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(75, 17);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descrição:";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.BackColor = System.Drawing.SystemColors.Control;
            contatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatoLabel.Location = new System.Drawing.Point(224, 11);
            contatoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(66, 17);
            contatoLabel.TabIndex = 10;
            contatoLabel.Text = "Devedor:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.BackColor = System.Drawing.SystemColors.Control;
            bancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancoLabel.Location = new System.Drawing.Point(40, 77);
            bancoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(52, 17);
            bancoLabel.TabIndex = 12;
            bancoLabel.Text = "Banco:";
            // 
            // formaPagamentoLabel
            // 
            formaPagamentoLabel.AutoSize = true;
            formaPagamentoLabel.BackColor = System.Drawing.SystemColors.Control;
            formaPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formaPagamentoLabel.Location = new System.Drawing.Point(224, 77);
            formaPagamentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            formaPagamentoLabel.Name = "formaPagamentoLabel";
            formaPagamentoLabel.Size = new System.Drawing.Size(148, 17);
            formaPagamentoLabel.TabIndex = 13;
            formaPagamentoLabel.Text = "Forma de Pagamento:";
            // 
            // dataEmissaoLabel
            // 
            dataEmissaoLabel.AutoSize = true;
            dataEmissaoLabel.BackColor = System.Drawing.SystemColors.Control;
            dataEmissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataEmissaoLabel.Location = new System.Drawing.Point(224, 162);
            dataEmissaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataEmissaoLabel.Name = "dataEmissaoLabel";
            dataEmissaoLabel.Size = new System.Drawing.Size(119, 17);
            dataEmissaoLabel.TabIndex = 16;
            dataEmissaoLabel.Text = "Data de Emissão:";
            // 
            // valorReceberTextBoxContasReceber
            // 
            this.valorReceberTextBoxContasReceber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "ValorReceber", true));
            this.valorReceberTextBoxContasReceber.Location = new System.Drawing.Point(39, 29);
            this.valorReceberTextBoxContasReceber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valorReceberTextBoxContasReceber.Name = "valorReceberTextBoxContasReceber";
            this.valorReceberTextBoxContasReceber.Size = new System.Drawing.Size(124, 20);
            this.valorReceberTextBoxContasReceber.TabIndex = 1;
            this.valorReceberTextBoxContasReceber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valorReceberTextBoxContasReceber_KeyDown);
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(Models.ContasReceber);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 66);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro de contas a receber";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // descricaoTextBoxContasReceber
            // 
            this.descricaoTextBoxContasReceber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Descricao", true));
            this.descricaoTextBoxContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBoxContasReceber.Location = new System.Drawing.Point(39, 181);
            this.descricaoTextBoxContasReceber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descricaoTextBoxContasReceber.Name = "descricaoTextBoxContasReceber";
            this.descricaoTextBoxContasReceber.Size = new System.Drawing.Size(136, 19);
            this.descricaoTextBoxContasReceber.TabIndex = 5;
            this.descricaoTextBoxContasReceber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descricaoTextBoxContasReceber_KeyDown);
            // 
            // buttonBuscarContatoContasReceber
            // 
            this.buttonBuscarContatoContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContatoContasReceber.Location = new System.Drawing.Point(391, 18);
            this.buttonBuscarContatoContasReceber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarContatoContasReceber.Name = "buttonBuscarContatoContasReceber";
            this.buttonBuscarContatoContasReceber.Size = new System.Drawing.Size(63, 29);
            this.buttonBuscarContatoContasReceber.TabIndex = 7;
            this.buttonBuscarContatoContasReceber.Text = "Buscar";
            this.buttonBuscarContatoContasReceber.UseVisualStyleBackColor = true;
            this.buttonBuscarContatoContasReceber.Click += new System.EventHandler(this.buttonBuscarContatoContasReceber_Click);
            // 
            // buttonSalvarCadastroContasReceber
            // 
            this.buttonSalvarCadastroContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroContasReceber.Location = new System.Drawing.Point(314, 236);
            this.buttonSalvarCadastroContasReceber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalvarCadastroContasReceber.Name = "buttonSalvarCadastroContasReceber";
            this.buttonSalvarCadastroContasReceber.Size = new System.Drawing.Size(58, 29);
            this.buttonSalvarCadastroContasReceber.TabIndex = 6;
            this.buttonSalvarCadastroContasReceber.Text = "Salvar";
            this.buttonSalvarCadastroContasReceber.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastroContasReceber.Click += new System.EventHandler(this.buttonSalvarCadastroContasReceber_Click);
            // 
            // buttonCancelarCadastroContasReceber
            // 
            this.buttonCancelarCadastroContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastroContasReceber.Location = new System.Drawing.Point(381, 236);
            this.buttonCancelarCadastroContasReceber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelarCadastroContasReceber.Name = "buttonCancelarCadastroContasReceber";
            this.buttonCancelarCadastroContasReceber.Size = new System.Drawing.Size(73, 29);
            this.buttonCancelarCadastroContasReceber.TabIndex = 7;
            this.buttonCancelarCadastroContasReceber.Text = "Cancelar";
            this.buttonCancelarCadastroContasReceber.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastroContasReceber.Click += new System.EventHandler(this.buttonCancelarCadastroContasReceber_Click);
            // 
            // textBoxBuscarContato
            // 
            this.textBoxBuscarContato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource, "Nome", true));
            this.textBoxBuscarContato.Location = new System.Drawing.Point(224, 29);
            this.textBoxBuscarContato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBuscarContato.Name = "textBoxBuscarContato";
            this.textBoxBuscarContato.Size = new System.Drawing.Size(164, 20);
            this.textBoxBuscarContato.TabIndex = 2;
            this.textBoxBuscarContato.TextChanged += new System.EventHandler(this.textBoxBuscarContato_TextChanged);
            this.textBoxBuscarContato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscarContato_KeyDown);
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataSource = typeof(Models.Contato);
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Banco", true));
            this.bancoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bancoTextBox.Location = new System.Drawing.Point(39, 96);
            this.bancoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(99, 19);
            this.bancoTextBox.TabIndex = 3;
            this.bancoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bancoTextBox_KeyDown);
            // 
            // formaPagamentoTextBox
            // 
            this.formaPagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "FormaPagamento", true));
            this.formaPagamentoTextBox.Location = new System.Drawing.Point(224, 96);
            this.formaPagamentoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formaPagamentoTextBox.Name = "formaPagamentoTextBox";
            this.formaPagamentoTextBox.Size = new System.Drawing.Size(164, 20);
            this.formaPagamentoTextBox.TabIndex = 4;
            this.formaPagamentoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formaPagamentoTextBox_KeyDown);
            // 
            // buttonBuscarBanco
            // 
            this.buttonBuscarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarBanco.Location = new System.Drawing.Point(142, 88);
            this.buttonBuscarBanco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarBanco.Name = "buttonBuscarBanco";
            this.buttonBuscarBanco.Size = new System.Drawing.Size(63, 29);
            this.buttonBuscarBanco.TabIndex = 15;
            this.buttonBuscarBanco.Text = "Buscar";
            this.buttonBuscarBanco.UseVisualStyleBackColor = true;
            this.buttonBuscarBanco.Click += new System.EventHandler(this.buttonBuscarBanco_Click);
            // 
            // buttonBuscarFormaPagamento
            // 
            this.buttonBuscarFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarFormaPagamento.Location = new System.Drawing.Point(391, 87);
            this.buttonBuscarFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarFormaPagamento.Name = "buttonBuscarFormaPagamento";
            this.buttonBuscarFormaPagamento.Size = new System.Drawing.Size(63, 29);
            this.buttonBuscarFormaPagamento.TabIndex = 16;
            this.buttonBuscarFormaPagamento.Text = "Buscar";
            this.buttonBuscarFormaPagamento.UseVisualStyleBackColor = true;
            this.buttonBuscarFormaPagamento.Click += new System.EventHandler(this.buttonBuscarFormaPagamento_Click);
            // 
            // dataEmissaoDateTimePicker
            // 
            this.dataEmissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "DataEmissao", true));
            this.dataEmissaoDateTimePicker.Location = new System.Drawing.Point(224, 181);
            this.dataEmissaoDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataEmissaoDateTimePicker.Name = "dataEmissaoDateTimePicker";
            this.dataEmissaoDateTimePicker.Size = new System.Drawing.Size(162, 20);
            this.dataEmissaoDateTimePicker.TabIndex = 17;
            this.dataEmissaoDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataEmissaoDateTimePicker_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(contatoLabel);
            this.panel1.Controls.Add(dataEmissaoLabel);
            this.panel1.Controls.Add(this.valorReceberTextBoxContasReceber);
            this.panel1.Controls.Add(this.dataEmissaoDateTimePicker);
            this.panel1.Controls.Add(valorReceberLabel);
            this.panel1.Controls.Add(this.buttonBuscarFormaPagamento);
            this.panel1.Controls.Add(this.descricaoTextBoxContasReceber);
            this.panel1.Controls.Add(this.buttonBuscarBanco);
            this.panel1.Controls.Add(descricaoLabel);
            this.panel1.Controls.Add(formaPagamentoLabel);
            this.panel1.Controls.Add(this.buttonBuscarContatoContasReceber);
            this.panel1.Controls.Add(this.formaPagamentoTextBox);
            this.panel1.Controls.Add(this.buttonSalvarCadastroContasReceber);
            this.panel1.Controls.Add(bancoLabel);
            this.panel1.Controls.Add(this.buttonCancelarCadastroContasReceber);
            this.panel1.Controls.Add(this.bancoTextBox);
            this.panel1.Controls.Add(this.textBoxBuscarContato);
            this.panel1.Location = new System.Drawing.Point(27, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 280);
            this.panel1.TabIndex = 18;
            // 
            // FormCadastroContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(520, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroContasReceber";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro contas de contas a receber";
            this.Load += new System.EventHandler(this.FormCadastroContasReceber_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroContasReceber_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}