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
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorReceberTextBoxContasReceber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descricaoTextBoxContasReceber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBuscarContatoContasReceber = new System.Windows.Forms.Button();
            this.buttonSalvarCadastroContasReceber = new System.Windows.Forms.Button();
            this.buttonCancelarCadastroContasReceber = new System.Windows.Forms.Button();
            valorReceberLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valorReceberLabel
            // 
            valorReceberLabel.AutoSize = true;
            valorReceberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorReceberLabel.Location = new System.Drawing.Point(108, 152);
            valorReceberLabel.Name = "valorReceberLabel";
            valorReceberLabel.Size = new System.Drawing.Size(112, 16);
            valorReceberLabel.TabIndex = 1;
            valorReceberLabel.Text = "Valor Receber:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(108, 213);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(82, 16);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descricao:";
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(Models.ContasReceber);
            // 
            // valorReceberTextBoxContasReceber
            // 
            this.valorReceberTextBoxContasReceber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "ValorReceber", true));
            this.valorReceberTextBoxContasReceber.Location = new System.Drawing.Point(226, 149);
            this.valorReceberTextBoxContasReceber.Name = "valorReceberTextBoxContasReceber";
            this.valorReceberTextBoxContasReceber.Size = new System.Drawing.Size(197, 22);
            this.valorReceberTextBoxContasReceber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro Contas a Receber";
            // 
            // descricaoTextBoxContasReceber
            // 
            this.descricaoTextBoxContasReceber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasReceberBindingSource, "Descricao", true));
            this.descricaoTextBoxContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBoxContasReceber.Location = new System.Drawing.Point(207, 213);
            this.descricaoTextBoxContasReceber.Name = "descricaoTextBoxContasReceber";
            this.descricaoTextBoxContasReceber.Size = new System.Drawing.Size(411, 22);
            this.descricaoTextBoxContasReceber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quem Vai Pagar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 6;
            // 
            // buttonBuscarContatoContasReceber
            // 
            this.buttonBuscarContatoContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContatoContasReceber.Location = new System.Drawing.Point(447, 276);
            this.buttonBuscarContatoContasReceber.Name = "buttonBuscarContatoContasReceber";
            this.buttonBuscarContatoContasReceber.Size = new System.Drawing.Size(78, 23);
            this.buttonBuscarContatoContasReceber.TabIndex = 7;
            this.buttonBuscarContatoContasReceber.Text = "Buscar";
            this.buttonBuscarContatoContasReceber.UseVisualStyleBackColor = true;
            // 
            // buttonSalvarCadastroContasReceber
            // 
            this.buttonSalvarCadastroContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroContasReceber.Location = new System.Drawing.Point(339, 371);
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
            this.buttonCancelarCadastroContasReceber.Location = new System.Drawing.Point(456, 371);
            this.buttonCancelarCadastroContasReceber.Name = "buttonCancelarCadastroContasReceber";
            this.buttonCancelarCadastroContasReceber.Size = new System.Drawing.Size(103, 23);
            this.buttonCancelarCadastroContasReceber.TabIndex = 9;
            this.buttonCancelarCadastroContasReceber.Text = "Cancelar";
            this.buttonCancelarCadastroContasReceber.UseVisualStyleBackColor = true;
            // 
            // FormCadastroContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 455);
            this.Controls.Add(this.buttonCancelarCadastroContasReceber);
            this.Controls.Add(this.buttonSalvarCadastroContasReceber);
            this.Controls.Add(this.buttonBuscarContatoContasReceber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBoxContasReceber);
            this.Controls.Add(this.label1);
            this.Controls.Add(valorReceberLabel);
            this.Controls.Add(this.valorReceberTextBoxContasReceber);
            this.Name = "FormCadastroContasReceber";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormCadastroContasReceber";
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.TextBox valorReceberTextBoxContasReceber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descricaoTextBoxContasReceber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscarContatoContasReceber;
        private System.Windows.Forms.Button buttonSalvarCadastroContasReceber;
        private System.Windows.Forms.Button buttonCancelarCadastroContasReceber;
    }
}