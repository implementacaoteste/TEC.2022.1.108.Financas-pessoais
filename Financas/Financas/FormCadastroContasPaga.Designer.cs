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
            this.valorPagarTextBox = new System.Windows.Forms.TextBox();
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
            descricaoLabel.Location = new System.Drawing.Point(22, 194);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(75, 17);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "Descrição:";
            // 
            // valorPagarLabel
            // 
            valorPagarLabel.AutoSize = true;
            valorPagarLabel.BackColor = System.Drawing.SystemColors.Control;
            valorPagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorPagarLabel.Location = new System.Drawing.Point(23, 37);
            valorPagarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valorPagarLabel.Name = "valorPagarLabel";
            valorPagarLabel.Size = new System.Drawing.Size(98, 17);
            valorPagarLabel.TabIndex = 3;
            valorPagarLabel.Text = "Valor a pagar:";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.BackColor = System.Drawing.SystemColors.Control;
            contatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatoLabel.Location = new System.Drawing.Point(211, 37);
            contatoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(55, 17);
            contatoLabel.TabIndex = 7;
            contatoLabel.Text = "Credor:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.BackColor = System.Drawing.SystemColors.Control;
            bancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancoLabel.Location = new System.Drawing.Point(22, 104);
            bancoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(52, 17);
            bancoLabel.TabIndex = 10;
            bancoLabel.Text = "Banco:";
            // 
            // formaPagamentoLabel
            // 
            formaPagamentoLabel.AutoSize = true;
            formaPagamentoLabel.BackColor = System.Drawing.SystemColors.Control;
            formaPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formaPagamentoLabel.Location = new System.Drawing.Point(211, 104);
            formaPagamentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            formaPagamentoLabel.Name = "formaPagamentoLabel";
            formaPagamentoLabel.Size = new System.Drawing.Size(147, 17);
            formaPagamentoLabel.TabIndex = 13;
            formaPagamentoLabel.Text = "Forma de pagamento:";
            // 
            // dataEmissaoLabel
            // 
            dataEmissaoLabel.AutoSize = true;
            dataEmissaoLabel.BackColor = System.Drawing.SystemColors.Control;
            dataEmissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataEmissaoLabel.Location = new System.Drawing.Point(211, 194);
            dataEmissaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataEmissaoLabel.Name = "dataEmissaoLabel";
            dataEmissaoLabel.Size = new System.Drawing.Size(119, 17);
            dataEmissaoLabel.TabIndex = 16;
            dataEmissaoLabel.Text = "Data de Emissão:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(22, 218);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(160, 20);
            this.descricaoTextBox.TabIndex = 5;
            this.descricaoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descricaoTextBox_KeyDown);
            // 
            // contasPagarBindingSource
            // 
            this.contasPagarBindingSource.DataSource = typeof(Models.ContasPagar);
            // 
            // valorPagarTextBox
            // 
            this.valorPagarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "ValorPagar", true));
            this.valorPagarTextBox.Location = new System.Drawing.Point(22, 57);
            this.valorPagarTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valorPagarTextBox.Name = "valorPagarTextBox";
            this.valorPagarTextBox.Size = new System.Drawing.Size(124, 20);
            this.valorPagarTextBox.TabIndex = 1;
            this.valorPagarTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valorPagarTextBox_KeyDown);
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
            this.label1.Size = new System.Drawing.Size(508, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastro de contas a pagar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // buttonCancelarCadastroContasPagar
            // 
            this.buttonCancelarCadastroContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastroContasPagar.Location = new System.Drawing.Point(412, 468);
            this.buttonCancelarCadastroContasPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelarCadastroContasPagar.Name = "buttonCancelarCadastroContasPagar";
            this.buttonCancelarCadastroContasPagar.Size = new System.Drawing.Size(77, 29);
            this.buttonCancelarCadastroContasPagar.TabIndex = 7;
            this.buttonCancelarCadastroContasPagar.Text = "Cancelar";
            this.buttonCancelarCadastroContasPagar.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastroContasPagar.Click += new System.EventHandler(this.buttonCancelarCadastroContasPagar_Click);
            // 
            // buttonSalvarCadastroContasPagar
            // 
            this.buttonSalvarCadastroContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroContasPagar.Location = new System.Drawing.Point(350, 468);
            this.buttonSalvarCadastroContasPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalvarCadastroContasPagar.Name = "buttonSalvarCadastroContasPagar";
            this.buttonSalvarCadastroContasPagar.Size = new System.Drawing.Size(58, 29);
            this.buttonSalvarCadastroContasPagar.TabIndex = 6;
            this.buttonSalvarCadastroContasPagar.Text = "Salvar";
            this.buttonSalvarCadastroContasPagar.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastroContasPagar.Click += new System.EventHandler(this.buttonSalvarCadastroContasPagar_Click);
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Contato", true));
            this.contatoTextBox.Location = new System.Drawing.Point(211, 56);
            this.contatoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(164, 20);
            this.contatoTextBox.TabIndex = 2;
            this.contatoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contatoTextBox_KeyDown);
            // 
            // buttonBuscarContatoContasPagar
            // 
            this.buttonBuscarContatoContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContatoContasPagar.Location = new System.Drawing.Point(378, 51);
            this.buttonBuscarContatoContasPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarContatoContasPagar.Name = "buttonBuscarContatoContasPagar";
            this.buttonBuscarContatoContasPagar.Size = new System.Drawing.Size(63, 29);
            this.buttonBuscarContatoContasPagar.TabIndex = 9;
            this.buttonBuscarContatoContasPagar.Text = "Buscar";
            this.buttonBuscarContatoContasPagar.UseVisualStyleBackColor = true;
            this.buttonBuscarContatoContasPagar.Click += new System.EventHandler(this.buttonBuscarContatoContasPagar_Click);
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Banco", true));
            this.bancoTextBox.Location = new System.Drawing.Point(22, 123);
            this.bancoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(99, 20);
            this.bancoTextBox.TabIndex = 3;
            this.bancoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bancoTextBox_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formaPagamentoTextBox
            // 
            this.formaPagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "FormaPagamento", true));
            this.formaPagamentoTextBox.Location = new System.Drawing.Point(211, 123);
            this.formaPagamentoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formaPagamentoTextBox.Name = "formaPagamentoTextBox";
            this.formaPagamentoTextBox.Size = new System.Drawing.Size(164, 20);
            this.formaPagamentoTextBox.TabIndex = 4;
            this.formaPagamentoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formaPagamentoTextBox_KeyDown);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(378, 116);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataEmissaoDateTimePicker
            // 
            this.dataEmissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasPagarBindingSource, "DataEmissao", true));
            this.dataEmissaoDateTimePicker.Location = new System.Drawing.Point(255, 218);
            this.dataEmissaoDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataEmissaoDateTimePicker.Name = "dataEmissaoDateTimePicker";
            this.dataEmissaoDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dataEmissaoDateTimePicker.TabIndex = 17;
            this.dataEmissaoDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataEmissaoDateTimePicker_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(dataEmissaoLabel);
            this.panel1.Controls.Add(this.descricaoTextBox);
            this.panel1.Controls.Add(this.dataEmissaoDateTimePicker);
            this.panel1.Controls.Add(descricaoLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.valorPagarTextBox);
            this.panel1.Controls.Add(formaPagamentoLabel);
            this.panel1.Controls.Add(valorPagarLabel);
            this.panel1.Controls.Add(this.formaPagamentoTextBox);
            this.panel1.Controls.Add(this.contatoTextBox);
            this.panel1.Controls.Add(contatoLabel);
            this.panel1.Controls.Add(bancoLabel);
            this.panel1.Controls.Add(this.buttonBuscarContatoContasPagar);
            this.panel1.Controls.Add(this.bancoTextBox);
            this.panel1.Location = new System.Drawing.Point(31, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 288);
            this.panel1.TabIndex = 18;
            // 
            // FormCadastroContasPaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(508, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSalvarCadastroContasPagar);
            this.Controls.Add(this.buttonCancelarCadastroContasPagar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox valorPagarTextBox;
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
    }
}