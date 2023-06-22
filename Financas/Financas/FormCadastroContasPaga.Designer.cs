namespace Financas
{
    partial class FormCadastroContasPaga
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
            System.Windows.Forms.Label valorPagarLabel;
            System.Windows.Forms.Label contatoLabel;
            System.Windows.Forms.Label bancoLabel;
            System.Windows.Forms.Label formaPagamentoLabel;
            System.Windows.Forms.Label dataEmissaoLabel;
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.contasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelarCadastroContasPagar = new System.Windows.Forms.Button();
            this.buttonSalvarCadastroContasPagar = new System.Windows.Forms.Button();
            this.contatoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscarContatoContasPagar = new System.Windows.Forms.Button();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.formaPagamentoTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataEmissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDinheiro1 = new ComponentesDesktop.TextBoxDinheiro();
            descricaoLabel = new System.Windows.Forms.Label();
            valorPagarLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            formaPagamentoLabel = new System.Windows.Forms.Label();
            dataEmissaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.BackColor = System.Drawing.SystemColors.Control;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(29, 239);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(91, 20);
            descricaoLabel.TabIndex = 12;
            descricaoLabel.Text = "Descrição:";
            // 
            // valorPagarLabel
            // 
            valorPagarLabel.AutoSize = true;
            valorPagarLabel.BackColor = System.Drawing.SystemColors.Control;
            valorPagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorPagarLabel.Location = new System.Drawing.Point(31, 46);
            valorPagarLabel.Name = "valorPagarLabel";
            valorPagarLabel.Size = new System.Drawing.Size(114, 20);
            valorPagarLabel.TabIndex = 1;
            valorPagarLabel.Text = "Valor a pagar:";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.BackColor = System.Drawing.SystemColors.Control;
            contatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatoLabel.Location = new System.Drawing.Point(281, 46);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(65, 20);
            contatoLabel.TabIndex = 3;
            contatoLabel.Text = "Credor:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.BackColor = System.Drawing.SystemColors.Control;
            bancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancoLabel.Location = new System.Drawing.Point(29, 128);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(62, 20);
            bancoLabel.TabIndex = 6;
            bancoLabel.Text = "Banco:";
            // 
            // formaPagamentoLabel
            // 
            formaPagamentoLabel.AutoSize = true;
            formaPagamentoLabel.BackColor = System.Drawing.SystemColors.Control;
            formaPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formaPagamentoLabel.Location = new System.Drawing.Point(281, 128);
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
            dataEmissaoLabel.Location = new System.Drawing.Point(281, 239);
            dataEmissaoLabel.Name = "dataEmissaoLabel";
            dataEmissaoLabel.Size = new System.Drawing.Size(141, 20);
            dataEmissaoLabel.TabIndex = 14;
            dataEmissaoLabel.Text = "Data de emissão:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(29, 268);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(212, 22);
            this.descricaoTextBox.TabIndex = 13;
            this.descricaoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descricaoTextBox_KeyDown);
            // 
            // contasPagarBindingSource
            // 
            this.contasPagarBindingSource.DataSource = typeof(Models.ContasPagar);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(836, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de contas a pagar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // buttonCancelarCadastroContasPagar
            // 
            this.buttonCancelarCadastroContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastroContasPagar.Location = new System.Drawing.Point(466, 311);
            this.buttonCancelarCadastroContasPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelarCadastroContasPagar.Name = "buttonCancelarCadastroContasPagar";
            this.buttonCancelarCadastroContasPagar.Size = new System.Drawing.Size(103, 36);
            this.buttonCancelarCadastroContasPagar.TabIndex = 17;
            this.buttonCancelarCadastroContasPagar.Text = "Cancelar";
            this.buttonCancelarCadastroContasPagar.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastroContasPagar.Click += new System.EventHandler(this.buttonCancelarCadastroContasPagar_Click);
            // 
            // buttonSalvarCadastroContasPagar
            // 
            this.buttonSalvarCadastroContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroContasPagar.Location = new System.Drawing.Point(384, 311);
            this.buttonSalvarCadastroContasPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarCadastroContasPagar.Name = "buttonSalvarCadastroContasPagar";
            this.buttonSalvarCadastroContasPagar.Size = new System.Drawing.Size(77, 36);
            this.buttonSalvarCadastroContasPagar.TabIndex = 16;
            this.buttonSalvarCadastroContasPagar.Text = "Salvar";
            this.buttonSalvarCadastroContasPagar.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastroContasPagar.Click += new System.EventHandler(this.buttonSalvarCadastroContasPagar_Click);
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Contato", true));
            this.contatoTextBox.Location = new System.Drawing.Point(281, 69);
            this.contatoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(217, 22);
            this.contatoTextBox.TabIndex = 4;
            this.contatoTextBox.TextChanged += new System.EventHandler(this.contatoTextBox_TextChanged);
            this.contatoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contatoTextBox_KeyDown);
            // 
            // buttonBuscarContatoContasPagar
            // 
            this.buttonBuscarContatoContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContatoContasPagar.Location = new System.Drawing.Point(504, 63);
            this.buttonBuscarContatoContasPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarContatoContasPagar.Name = "buttonBuscarContatoContasPagar";
            this.buttonBuscarContatoContasPagar.Size = new System.Drawing.Size(84, 36);
            this.buttonBuscarContatoContasPagar.TabIndex = 5;
            this.buttonBuscarContatoContasPagar.TabStop = false;
            this.buttonBuscarContatoContasPagar.Text = "Buscar";
            this.buttonBuscarContatoContasPagar.UseVisualStyleBackColor = true;
            this.buttonBuscarContatoContasPagar.Click += new System.EventHandler(this.buttonBuscarContatoContasPagar_Click);
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Banco", true));
            this.bancoTextBox.Location = new System.Drawing.Point(29, 151);
            this.bancoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(131, 22);
            this.bancoTextBox.TabIndex = 7;
            this.bancoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bancoTextBox_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 36);
            this.button1.TabIndex = 8;
            this.button1.TabStop = false;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formaPagamentoTextBox
            // 
            this.formaPagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "FormaPagamento", true));
            this.formaPagamentoTextBox.Location = new System.Drawing.Point(281, 151);
            this.formaPagamentoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formaPagamentoTextBox.Name = "formaPagamentoTextBox";
            this.formaPagamentoTextBox.Size = new System.Drawing.Size(217, 22);
            this.formaPagamentoTextBox.TabIndex = 10;
            this.formaPagamentoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formaPagamentoTextBox_KeyDown);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(504, 143);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 36);
            this.button2.TabIndex = 11;
            this.button2.TabStop = false;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataEmissaoDateTimePicker
            // 
            this.dataEmissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasPagarBindingSource, "DataEmissao", true));
            this.dataEmissaoDateTimePicker.Location = new System.Drawing.Point(281, 268);
            this.dataEmissaoDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataEmissaoDateTimePicker.Name = "dataEmissaoDateTimePicker";
            this.dataEmissaoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataEmissaoDateTimePicker.TabIndex = 15;
            this.dataEmissaoDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataEmissaoDateTimePicker_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxDinheiro1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonSalvarCadastroContasPagar);
            this.panel1.Controls.Add(dataEmissaoLabel);
            this.panel1.Controls.Add(this.buttonCancelarCadastroContasPagar);
            this.panel1.Controls.Add(this.descricaoTextBox);
            this.panel1.Controls.Add(this.dataEmissaoDateTimePicker);
            this.panel1.Controls.Add(descricaoLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(formaPagamentoLabel);
            this.panel1.Controls.Add(valorPagarLabel);
            this.panel1.Controls.Add(this.formaPagamentoTextBox);
            this.panel1.Controls.Add(this.contatoTextBox);
            this.panel1.Controls.Add(contatoLabel);
            this.panel1.Controls.Add(bancoLabel);
            this.panel1.Controls.Add(this.buttonBuscarContatoContasPagar);
            this.panel1.Controls.Add(this.bancoTextBox);
            this.panel1.Location = new System.Drawing.Point(90, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 370);
            this.panel1.TabIndex = 1;
            // 
            // textBoxDinheiro1
            // 
            this.textBoxDinheiro1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "ValorPagar", true));
            this.textBoxDinheiro1.Location = new System.Drawing.Point(29, 71);
            this.textBoxDinheiro1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDinheiro1.Name = "textBoxDinheiro1";
            this.textBoxDinheiro1.Size = new System.Drawing.Size(164, 22);
            this.textBoxDinheiro1.TabIndex = 2;
            this.textBoxDinheiro1.Text = "0,00";
            this.textBoxDinheiro1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDinheiro1.TextChanged += new System.EventHandler(this.textBoxDinheiro1_TextChanged);
            this.textBoxDinheiro1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDinheiro1_KeyDown);
            // 
            // FormCadastroContasPaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(836, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroContasPaga";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de contas a pagar";
            this.Load += new System.EventHandler(this.FormCadastroContasPaga_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroContasPaga_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource contasPagarBindingSource;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelarCadastroContasPagar;
        private System.Windows.Forms.Button buttonSalvarCadastroContasPagar;
        private System.Windows.Forms.TextBox contatoTextBox;
        private System.Windows.Forms.Button buttonBuscarContatoContasPagar;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox formaPagamentoTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dataEmissaoDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private ComponentesDesktop.TextBoxDinheiro textBoxDinheiro1;
    }
}