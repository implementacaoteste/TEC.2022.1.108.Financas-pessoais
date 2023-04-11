namespace Financas
{
    partial class FormCadastroBanco
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label poupancaLabel;
            System.Windows.Forms.Label saldoLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.bancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.poupancaTextBox = new System.Windows.Forms.TextBox();
            this.saldoTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvarCadBanco = new System.Windows.Forms.Button();
            this.buttonCancelarCadBanco = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            poupancaLabel = new System.Windows.Forms.Label();
            saldoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(37, 108);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(58, 20);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // poupancaLabel
            // 
            poupancaLabel.AutoSize = true;
            poupancaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            poupancaLabel.Location = new System.Drawing.Point(37, 188);
            poupancaLabel.Name = "poupancaLabel";
            poupancaLabel.Size = new System.Drawing.Size(88, 20);
            poupancaLabel.TabIndex = 4;
            poupancaLabel.Text = "Poupança:";
            // 
            // saldoLabel
            // 
            saldoLabel.AutoSize = true;
            saldoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            saldoLabel.Location = new System.Drawing.Point(374, 108);
            saldoLabel.Name = "saldoLabel";
            saldoLabel.Size = new System.Drawing.Size(56, 20);
            saldoLabel.TabIndex = 6;
            saldoLabel.Text = "Saldo:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro do banco";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataSource = typeof(Models.Banco);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bancoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(40, 128);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(270, 22);
            this.nomeTextBox.TabIndex = 3;
            // 
            // poupancaTextBox
            // 
            this.poupancaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bancoBindingSource, "Poupanca", true));
            this.poupancaTextBox.Location = new System.Drawing.Point(40, 215);
            this.poupancaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.poupancaTextBox.Name = "poupancaTextBox";
            this.poupancaTextBox.Size = new System.Drawing.Size(270, 22);
            this.poupancaTextBox.TabIndex = 5;
            // 
            // saldoTextBox
            // 
            this.saldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bancoBindingSource, "Saldo", true));
            this.saldoTextBox.Location = new System.Drawing.Point(378, 128);
            this.saldoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saldoTextBox.Name = "saldoTextBox";
            this.saldoTextBox.Size = new System.Drawing.Size(194, 22);
            this.saldoTextBox.TabIndex = 7;
            // 
            // buttonSalvarCadBanco
            // 
            this.buttonSalvarCadBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadBanco.Location = new System.Drawing.Point(406, 334);
            this.buttonSalvarCadBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarCadBanco.Name = "buttonSalvarCadBanco";
            this.buttonSalvarCadBanco.Size = new System.Drawing.Size(69, 28);
            this.buttonSalvarCadBanco.TabIndex = 8;
            this.buttonSalvarCadBanco.Text = "Salvar";
            this.buttonSalvarCadBanco.UseVisualStyleBackColor = true;
            this.buttonSalvarCadBanco.Click += new System.EventHandler(this.buttonSalvarCadBanco_Click);
            // 
            // buttonCancelarCadBanco
            // 
            this.buttonCancelarCadBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadBanco.Location = new System.Drawing.Point(482, 334);
            this.buttonCancelarCadBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelarCadBanco.Name = "buttonCancelarCadBanco";
            this.buttonCancelarCadBanco.Size = new System.Drawing.Size(91, 28);
            this.buttonCancelarCadBanco.TabIndex = 8;
            this.buttonCancelarCadBanco.Text = "Cancelar";
            this.buttonCancelarCadBanco.UseVisualStyleBackColor = true;
            this.buttonCancelarCadBanco.Click += new System.EventHandler(this.buttonCancelarCadBanco_Click);
            // 
            // FormCadastroBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 389);
            this.Controls.Add(this.buttonCancelarCadBanco);
            this.Controls.Add(this.buttonSalvarCadBanco);
            this.Controls.Add(saldoLabel);
            this.Controls.Add(this.saldoTextBox);
            this.Controls.Add(poupancaLabel);
            this.Controls.Add(this.poupancaTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroBanco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Banco";
            this.Load += new System.EventHandler(this.FormCadastroBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bancoBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox poupancaTextBox;
        private System.Windows.Forms.TextBox saldoTextBox;
        private System.Windows.Forms.Button buttonSalvarCadBanco;
        private System.Windows.Forms.Button buttonCancelarCadBanco;
    }
}