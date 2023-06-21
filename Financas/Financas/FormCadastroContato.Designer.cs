namespace Financas
{
    partial class FormCadastroContato
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelarCadastroContato = new System.Windows.Forms.Button();
            this.buttonSalvarCadastroContato = new System.Windows.Forms.Button();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numeroTextBox = new System.Windows.Forms.MaskedTextBox();
            descricaoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.BackColor = System.Drawing.SystemColors.Control;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(13, 167);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(91, 20);
            descricaoLabel.TabIndex = 6;
            descricaoLabel.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.Control;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(13, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.Control;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(13, 96);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "Endereço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.Control;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(324, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 20);
            label4.TabIndex = 2;
            label4.Text = "Número:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(13, 43);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(263, 22);
            this.nomeTextBox.TabIndex = 1;
            this.nomeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataSource = typeof(Models.Contato);
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(13, 119);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(505, 22);
            this.enderecoTextBox.TabIndex = 5;
            this.enderecoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enderecoTextBox_KeyDown);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(13, 191);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(505, 22);
            this.descricaoTextBox.TabIndex = 7;
            this.descricaoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descricaoTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de contato";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelarCadastroContato
            // 
            this.buttonCancelarCadastroContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastroContato.Location = new System.Drawing.Point(413, 257);
            this.buttonCancelarCadastroContato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelarCadastroContato.Name = "buttonCancelarCadastroContato";
            this.buttonCancelarCadastroContato.Size = new System.Drawing.Size(107, 36);
            this.buttonCancelarCadastroContato.TabIndex = 10;
            this.buttonCancelarCadastroContato.Text = "Cancelar";
            this.buttonCancelarCadastroContato.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastroContato.Click += new System.EventHandler(this.buttonCancelarCadastroContato_Click);
            // 
            // buttonSalvarCadastroContato
            // 
            this.buttonSalvarCadastroContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroContato.Location = new System.Drawing.Point(324, 257);
            this.buttonSalvarCadastroContato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarCadastroContato.Name = "buttonSalvarCadastroContato";
            this.buttonSalvarCadastroContato.Size = new System.Drawing.Size(84, 36);
            this.buttonSalvarCadastroContato.TabIndex = 9;
            this.buttonSalvarCadastroContato.Text = "Salvar";
            this.buttonSalvarCadastroContato.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastroContato.Click += new System.EventHandler(this.buttonSalvarCadastroContato_Click);
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ativoCheckBox.Checked = true;
            this.ativoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contatoBindingSource, "Ativo", true));
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.contatoBindingSource, "Ativo", true));
            this.ativoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ativoCheckBox.Location = new System.Drawing.Point(27, 234);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(104, 25);
            this.ativoCheckBox.TabIndex = 8;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numeroTextBox);
            this.panel1.Controls.Add(this.ativoCheckBox);
            this.panel1.Controls.Add(this.nomeTextBox);
            this.panel1.Controls.Add(this.buttonSalvarCadastroContato);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.buttonCancelarCadastroContato);
            this.panel1.Controls.Add(this.enderecoTextBox);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(descricaoLabel);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.descricaoTextBox);
            this.panel1.Location = new System.Drawing.Point(37, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 326);
            this.panel1.TabIndex = 13;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(324, 43);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeroTextBox.Mask = "(99) 00000-0000";
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(109, 22);
            this.numeroTextBox.TabIndex = 3;
            this.numeroTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numeroTextBox_KeyDown);
            // 
            // FormCadastroContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(625, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroContato";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de contato";
            this.Load += new System.EventHandler(this.FormCadastroContato_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroContato_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource contatoBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelarCadastroContato;
        private System.Windows.Forms.Button buttonSalvarCadastroContato;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox numeroTextBox;
    }
}