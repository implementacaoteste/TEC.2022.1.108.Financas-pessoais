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
            descricaoLabel = new System.Windows.Forms.Label();
            valorPagarLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            formaPagamentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(85, 317);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(82, 16);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "Descrição:";
            // 
            // valorPagarLabel
            // 
            valorPagarLabel.AutoSize = true;
            valorPagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorPagarLabel.Location = new System.Drawing.Point(12, 132);
            valorPagarLabel.Name = "valorPagarLabel";
            valorPagarLabel.Size = new System.Drawing.Size(107, 16);
            valorPagarLabel.TabIndex = 3;
            valorPagarLabel.Text = "Valor a Pagar:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(193, 314);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(400, 22);
            this.descricaoTextBox.TabIndex = 2;
            // 
            // contasPagarBindingSource
            // 
            this.contasPagarBindingSource.DataSource = typeof(Models.ContasPagar);
            // 
            // valorPagarTextBox
            // 
            this.valorPagarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "ValorPagar", true));
            this.valorPagarTextBox.Location = new System.Drawing.Point(120, 129);
            this.valorPagarTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valorPagarTextBox.Name = "valorPagarTextBox";
            this.valorPagarTextBox.Size = new System.Drawing.Size(119, 22);
            this.valorPagarTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastro de contas a pagar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // buttonCancelarCadastroContasPagar
            // 
            this.buttonCancelarCadastroContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastroContasPagar.Location = new System.Drawing.Point(490, 382);
            this.buttonCancelarCadastroContasPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelarCadastroContasPagar.Name = "buttonCancelarCadastroContasPagar";
            this.buttonCancelarCadastroContasPagar.Size = new System.Drawing.Size(103, 23);
            this.buttonCancelarCadastroContasPagar.TabIndex = 7;
            this.buttonCancelarCadastroContasPagar.Text = "Cancelar";
            this.buttonCancelarCadastroContasPagar.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastroContasPagar.Click += new System.EventHandler(this.buttonCancelarCadastroContasPagar_Click);
            // 
            // buttonSalvarCadastroContasPagar
            // 
            this.buttonSalvarCadastroContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroContasPagar.Location = new System.Drawing.Point(396, 382);
            this.buttonSalvarCadastroContasPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarCadastroContasPagar.Name = "buttonSalvarCadastroContasPagar";
            this.buttonSalvarCadastroContasPagar.Size = new System.Drawing.Size(77, 23);
            this.buttonSalvarCadastroContasPagar.TabIndex = 7;
            this.buttonSalvarCadastroContasPagar.Text = "Salvar";
            this.buttonSalvarCadastroContasPagar.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastroContasPagar.Click += new System.EventHandler(this.buttonSalvarCadastroContasPagar_Click);
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatoLabel.Location = new System.Drawing.Point(329, 131);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(71, 16);
            contatoLabel.TabIndex = 7;
            contatoLabel.Text = "Devedor:";
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Contato", true));
            this.contatoTextBox.Location = new System.Drawing.Point(391, 128);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(128, 22);
            this.contatoTextBox.TabIndex = 8;
            // 
            // buttonBuscarContatoContasPagar
            // 
            this.buttonBuscarContatoContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContatoContasPagar.Location = new System.Drawing.Point(526, 129);
            this.buttonBuscarContatoContasPagar.Name = "buttonBuscarContatoContasPagar";
            this.buttonBuscarContatoContasPagar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarContatoContasPagar.TabIndex = 9;
            this.buttonBuscarContatoContasPagar.Text = "Buscar";
            this.buttonBuscarContatoContasPagar.UseVisualStyleBackColor = true;
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancoLabel.Location = new System.Drawing.Point(12, 244);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(55, 16);
            bancoLabel.TabIndex = 10;
            bancoLabel.Text = "Banco:";
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "Banco", true));
            this.bancoTextBox.Location = new System.Drawing.Point(67, 241);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(130, 22);
            this.bancoTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formaPagamentoLabel
            // 
            formaPagamentoLabel.AutoSize = true;
            formaPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formaPagamentoLabel.Location = new System.Drawing.Point(328, 243);
            formaPagamentoLabel.Name = "formaPagamentoLabel";
            formaPagamentoLabel.Size = new System.Drawing.Size(138, 16);
            formaPagamentoLabel.TabIndex = 13;
            formaPagamentoLabel.Text = "Forma Pagamento:";
            // 
            // formaPagamentoTextBox
            // 
            this.formaPagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasPagarBindingSource, "FormaPagamento", true));
            this.formaPagamentoTextBox.Location = new System.Drawing.Point(456, 240);
            this.formaPagamentoTextBox.Name = "formaPagamentoTextBox";
            this.formaPagamentoTextBox.Size = new System.Drawing.Size(121, 22);
            this.formaPagamentoTextBox.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(583, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormCadastroContasPaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 455);
            this.Controls.Add(this.button2);
            this.Controls.Add(formaPagamentoLabel);
            this.Controls.Add(this.formaPagamentoTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(bancoLabel);
            this.Controls.Add(this.bancoTextBox);
            this.Controls.Add(this.buttonBuscarContatoContasPagar);
            this.Controls.Add(contatoLabel);
            this.Controls.Add(this.contatoTextBox);
            this.Controls.Add(this.buttonSalvarCadastroContasPagar);
            this.Controls.Add(this.buttonCancelarCadastroContasPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(valorPagarLabel);
            this.Controls.Add(this.valorPagarTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroContasPaga";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de contas a pagar";
            this.Load += new System.EventHandler(this.FormCadastroContasPaga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}