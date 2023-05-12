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
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.bancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poupancaTextBox = new System.Windows.Forms.TextBox();
            this.buttonSalvarCadBanco = new System.Windows.Forms.Button();
            this.buttonCancelarCadBanco = new System.Windows.Forms.Button();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            nomeLabel = new System.Windows.Forms.Label();
            poupancaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(107, 41);
            nomeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(58, 20);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome:";
            // 
            // poupancaLabel
            // 
            poupancaLabel.AutoSize = true;
            poupancaLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            poupancaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            poupancaLabel.Location = new System.Drawing.Point(111, 171);
            poupancaLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            poupancaLabel.Name = "poupancaLabel";
            poupancaLabel.Size = new System.Drawing.Size(88, 20);
            poupancaLabel.TabIndex = 1;
            poupancaLabel.Text = "Poupança:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1015, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro do banco";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bancoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(111, 64);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(477, 22);
            this.nomeTextBox.TabIndex = 1;
            this.nomeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataSource = typeof(Models.Banco);
            // 
            // poupancaTextBox
            // 
            this.poupancaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bancoBindingSource, "Poupanca", true));
            this.poupancaTextBox.Location = new System.Drawing.Point(111, 204);
            this.poupancaTextBox.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.poupancaTextBox.Name = "poupancaTextBox";
            this.poupancaTextBox.Size = new System.Drawing.Size(477, 22);
            this.poupancaTextBox.TabIndex = 2;
            this.poupancaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.poupancaTextBox_KeyDown);
            // 
            // buttonSalvarCadBanco
            // 
            this.buttonSalvarCadBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadBanco.Location = new System.Drawing.Point(444, 334);
            this.buttonSalvarCadBanco.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSalvarCadBanco.Name = "buttonSalvarCadBanco";
            this.buttonSalvarCadBanco.Size = new System.Drawing.Size(121, 54);
            this.buttonSalvarCadBanco.TabIndex = 4;
            this.buttonSalvarCadBanco.Text = "Salvar";
            this.buttonSalvarCadBanco.UseVisualStyleBackColor = true;
            this.buttonSalvarCadBanco.Click += new System.EventHandler(this.buttonSalvarCadBanco_Click);
            // 
            // buttonCancelarCadBanco
            // 
            this.buttonCancelarCadBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadBanco.Location = new System.Drawing.Point(631, 334);
            this.buttonCancelarCadBanco.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.buttonCancelarCadBanco.Name = "buttonCancelarCadBanco";
            this.buttonCancelarCadBanco.Size = new System.Drawing.Size(128, 54);
            this.buttonCancelarCadBanco.TabIndex = 5;
            this.buttonCancelarCadBanco.Text = "Cancelar";
            this.buttonCancelarCadBanco.UseVisualStyleBackColor = true;
            this.buttonCancelarCadBanco.Click += new System.EventHandler(this.buttonCancelarCadBanco_Click);
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ativoCheckBox.Checked = true;
            this.ativoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bancoBindingSource, "Ativo", true));
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bancoBindingSource, "Ativo", true));
            this.ativoCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ativoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ativoCheckBox.Location = new System.Drawing.Point(115, 278);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(111, 37);
            this.ativoCheckBox.TabIndex = 3;
            this.ativoCheckBox.Text = "Ativo\r\nInativo\r\n";
            this.ativoCheckBox.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.poupancaTextBox);
            this.panel1.Controls.Add(this.ativoCheckBox);
            this.panel1.Controls.Add(this.buttonCancelarCadBanco);
            this.panel1.Controls.Add(this.nomeTextBox);
            this.panel1.Controls.Add(nomeLabel);
            this.panel1.Controls.Add(this.buttonSalvarCadBanco);
            this.panel1.Controls.Add(poupancaLabel);
            this.panel1.Location = new System.Drawing.Point(63, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 446);
            this.panel1.TabIndex = 0;
            // 
            // FormCadastroBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1015, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroBanco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadastroBanco_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroBanco_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bancoBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox poupancaTextBox;
        private System.Windows.Forms.Button buttonSalvarCadBanco;
        private System.Windows.Forms.Button buttonCancelarCadBanco;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}