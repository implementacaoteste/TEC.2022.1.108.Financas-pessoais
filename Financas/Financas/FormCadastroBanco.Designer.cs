﻿namespace Financas
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
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(23, 130);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(63, 20);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // poupancaLabel
            // 
            poupancaLabel.AutoSize = true;
            poupancaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            poupancaLabel.Location = new System.Drawing.Point(380, 127);
            poupancaLabel.Name = "poupancaLabel";
            poupancaLabel.Size = new System.Drawing.Size(97, 20);
            poupancaLabel.TabIndex = 4;
            poupancaLabel.Text = "Poupança:";
            // 
            // saldoLabel
            // 
            saldoLabel.AutoSize = true;
            saldoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            saldoLabel.Location = new System.Drawing.Point(203, 226);
            saldoLabel.Name = "saldoLabel";
            saldoLabel.Size = new System.Drawing.Size(62, 20);
            saldoLabel.TabIndex = 6;
            saldoLabel.Text = "Saldo:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Banco";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataSource = typeof(Models.Banco);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bancoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(87, 130);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(246, 26);
            this.nomeTextBox.TabIndex = 3;
            // 
            // poupancaTextBox
            // 
            this.poupancaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bancoBindingSource, "Poupanca", true));
            this.poupancaTextBox.Location = new System.Drawing.Point(474, 124);
            this.poupancaTextBox.Name = "poupancaTextBox";
            this.poupancaTextBox.Size = new System.Drawing.Size(253, 26);
            this.poupancaTextBox.TabIndex = 5;
            // 
            // saldoTextBox
            // 
            this.saldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bancoBindingSource, "Saldo", true));
            this.saldoTextBox.Location = new System.Drawing.Point(271, 223);
            this.saldoTextBox.Name = "saldoTextBox";
            this.saldoTextBox.Size = new System.Drawing.Size(262, 26);
            this.saldoTextBox.TabIndex = 7;
            // 
            // buttonSalvarCadBanco
            // 
            this.buttonSalvarCadBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadBanco.Location = new System.Drawing.Point(254, 325);
            this.buttonSalvarCadBanco.Name = "buttonSalvarCadBanco";
            this.buttonSalvarCadBanco.Size = new System.Drawing.Size(78, 23);
            this.buttonSalvarCadBanco.TabIndex = 8;
            this.buttonSalvarCadBanco.Text = "Salvar";
            this.buttonSalvarCadBanco.UseVisualStyleBackColor = true;
            this.buttonSalvarCadBanco.Click += new System.EventHandler(this.buttonSalvarCadBanco_Click);
            // 
            // buttonCancelarCadBanco
            // 
            this.buttonCancelarCadBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadBanco.Location = new System.Drawing.Point(410, 325);
            this.buttonCancelarCadBanco.Name = "buttonCancelarCadBanco";
            this.buttonCancelarCadBanco.Size = new System.Drawing.Size(103, 23);
            this.buttonCancelarCadBanco.TabIndex = 8;
            this.buttonCancelarCadBanco.Text = "Cancelar";
            this.buttonCancelarCadBanco.UseVisualStyleBackColor = true;
            this.buttonCancelarCadBanco.Click += new System.EventHandler(this.buttonCancelarCadBanco_Click);
            // 
            // FormCadastroBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 455);
            this.Controls.Add(this.buttonCancelarCadBanco);
            this.Controls.Add(this.buttonSalvarCadBanco);
            this.Controls.Add(saldoLabel);
            this.Controls.Add(this.saldoTextBox);
            this.Controls.Add(poupancaLabel);
            this.Controls.Add(this.poupancaTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroBanco";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
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