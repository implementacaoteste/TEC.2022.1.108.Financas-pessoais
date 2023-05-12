namespace Financas
{
    partial class FormCadastroUsuario
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxNomeCadastroUsuario = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxNomeUsuarioCadastroUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenhaCadastroUsuario = new System.Windows.Forms.TextBox();
            this.labelAvisoNome = new System.Windows.Forms.Label();
            this.labelAvisoSenha = new System.Windows.Forms.Label();
            this.labelConfirmarSenha = new System.Windows.Forms.Label();
            this.textBoxConfirmarSenhaCadastroUsuario = new System.Windows.Forms.TextBox();
            this.labelRendaCadastroUsuario = new System.Windows.Forms.Label();
            this.textBoxRendaCadastroUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelarCadastrodeUsuario = new System.Windows.Forms.Button();
            this.buttonSalvarCadastrodeUsuario = new System.Windows.Forms.Button();
            this.ativoCheckBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.SystemColors.Control;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(36, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(58, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUsuario.Location = new System.Drawing.Point(366, 9);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(141, 20);
            this.labelNomeUsuario.TabIndex = 6;
            this.labelNomeUsuario.Text = "Nome de usuário:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.BackColor = System.Drawing.SystemColors.Control;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(32, 112);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(61, 20);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha:";
            // 
            // textBoxNomeCadastroUsuario
            // 
            this.textBoxNomeCadastroUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.textBoxNomeCadastroUsuario.Location = new System.Drawing.Point(36, 31);
            this.textBoxNomeCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNomeCadastroUsuario.Name = "textBoxNomeCadastroUsuario";
            this.textBoxNomeCadastroUsuario.Size = new System.Drawing.Size(281, 22);
            this.textBoxNomeCadastroUsuario.TabIndex = 1;
            this.textBoxNomeCadastroUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNomeCadastroUsuario_KeyDown);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // textBoxNomeUsuarioCadastroUsuario
            // 
            this.textBoxNomeUsuarioCadastroUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.textBoxNomeUsuarioCadastroUsuario.Location = new System.Drawing.Point(366, 31);
            this.textBoxNomeUsuarioCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNomeUsuarioCadastroUsuario.Name = "textBoxNomeUsuarioCadastroUsuario";
            this.textBoxNomeUsuarioCadastroUsuario.Size = new System.Drawing.Size(281, 22);
            this.textBoxNomeUsuarioCadastroUsuario.TabIndex = 7;
            this.textBoxNomeUsuarioCadastroUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNomeUsuarioCadastroUsuario_KeyDown);
            // 
            // textBoxSenhaCadastroUsuario
            // 
            this.textBoxSenhaCadastroUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.textBoxSenhaCadastroUsuario.Location = new System.Drawing.Point(36, 134);
            this.textBoxSenhaCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSenhaCadastroUsuario.Name = "textBoxSenhaCadastroUsuario";
            this.textBoxSenhaCadastroUsuario.PasswordChar = '*';
            this.textBoxSenhaCadastroUsuario.Size = new System.Drawing.Size(235, 22);
            this.textBoxSenhaCadastroUsuario.TabIndex = 3;
            this.textBoxSenhaCadastroUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSenhaCadastroUsuario_KeyDown);
            // 
            // labelAvisoNome
            // 
            this.labelAvisoNome.AutoSize = true;
            this.labelAvisoNome.BackColor = System.Drawing.Color.Transparent;
            this.labelAvisoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoNome.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAvisoNome.Location = new System.Drawing.Point(47, 62);
            this.labelAvisoNome.Name = "labelAvisoNome";
            this.labelAvisoNome.Size = new System.Drawing.Size(186, 32);
            this.labelAvisoNome.TabIndex = 4;
            this.labelAvisoNome.Text = "Obs: O nome deve conter \r\n  mais de três caracteres";
            // 
            // labelAvisoSenha
            // 
            this.labelAvisoSenha.AutoSize = true;
            this.labelAvisoSenha.BackColor = System.Drawing.Color.Transparent;
            this.labelAvisoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAvisoSenha.Location = new System.Drawing.Point(39, 165);
            this.labelAvisoSenha.Name = "labelAvisoSenha";
            this.labelAvisoSenha.Size = new System.Drawing.Size(189, 32);
            this.labelAvisoSenha.TabIndex = 5;
            this.labelAvisoSenha.Text = "Obs: A senha deve conter \r\n  mais de três caracteres";
            // 
            // labelConfirmarSenha
            // 
            this.labelConfirmarSenha.AutoSize = true;
            this.labelConfirmarSenha.BackColor = System.Drawing.SystemColors.Control;
            this.labelConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmarSenha.Location = new System.Drawing.Point(381, 121);
            this.labelConfirmarSenha.Name = "labelConfirmarSenha";
            this.labelConfirmarSenha.Size = new System.Drawing.Size(138, 20);
            this.labelConfirmarSenha.TabIndex = 8;
            this.labelConfirmarSenha.Text = "Confirmar senha:";
            // 
            // textBoxConfirmarSenhaCadastroUsuario
            // 
            this.textBoxConfirmarSenhaCadastroUsuario.Location = new System.Drawing.Point(381, 144);
            this.textBoxConfirmarSenhaCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConfirmarSenhaCadastroUsuario.Name = "textBoxConfirmarSenhaCadastroUsuario";
            this.textBoxConfirmarSenhaCadastroUsuario.PasswordChar = '*';
            this.textBoxConfirmarSenhaCadastroUsuario.Size = new System.Drawing.Size(235, 22);
            this.textBoxConfirmarSenhaCadastroUsuario.TabIndex = 9;
            this.textBoxConfirmarSenhaCadastroUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxConfirmarSenhaCadastroUsuario_KeyDown);
            // 
            // labelRendaCadastroUsuario
            // 
            this.labelRendaCadastroUsuario.AutoSize = true;
            this.labelRendaCadastroUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.labelRendaCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRendaCadastroUsuario.Location = new System.Drawing.Point(40, 225);
            this.labelRendaCadastroUsuario.Name = "labelRendaCadastroUsuario";
            this.labelRendaCadastroUsuario.Size = new System.Drawing.Size(62, 20);
            this.labelRendaCadastroUsuario.TabIndex = 10;
            this.labelRendaCadastroUsuario.Text = "Renda:";
            // 
            // textBoxRendaCadastroUsuario
            // 
            this.textBoxRendaCadastroUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Renda", true));
            this.textBoxRendaCadastroUsuario.Location = new System.Drawing.Point(40, 247);
            this.textBoxRendaCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRendaCadastroUsuario.Name = "textBoxRendaCadastroUsuario";
            this.textBoxRendaCadastroUsuario.Size = new System.Drawing.Size(207, 22);
            this.textBoxRendaCadastroUsuario.TabIndex = 11;
            this.textBoxRendaCadastroUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRendaCadastroUsuario_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCancelarCadastrodeUsuario
            // 
            this.buttonCancelarCadastrodeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastrodeUsuario.Location = new System.Drawing.Point(513, 283);
            this.buttonCancelarCadastrodeUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelarCadastrodeUsuario.Name = "buttonCancelarCadastrodeUsuario";
            this.buttonCancelarCadastrodeUsuario.Size = new System.Drawing.Size(107, 36);
            this.buttonCancelarCadastrodeUsuario.TabIndex = 14;
            this.buttonCancelarCadastrodeUsuario.Text = "Cancelar";
            this.buttonCancelarCadastrodeUsuario.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastrodeUsuario.Click += new System.EventHandler(this.buttonCancelarCadastrodeUsuario_Click);
            // 
            // buttonSalvarCadastrodeUsuario
            // 
            this.buttonSalvarCadastrodeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastrodeUsuario.Location = new System.Drawing.Point(412, 283);
            this.buttonSalvarCadastrodeUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarCadastrodeUsuario.Name = "buttonSalvarCadastrodeUsuario";
            this.buttonSalvarCadastrodeUsuario.Size = new System.Drawing.Size(84, 36);
            this.buttonSalvarCadastrodeUsuario.TabIndex = 13;
            this.buttonSalvarCadastrodeUsuario.Text = "Salvar";
            this.buttonSalvarCadastrodeUsuario.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastrodeUsuario.Click += new System.EventHandler(this.buttonSalvarCadastrodeUsuario_Click);
            // 
            // ativoCheckBox1
            // 
            this.ativoCheckBox1.BackColor = System.Drawing.SystemColors.Control;
            this.ativoCheckBox1.Checked = true;
            this.ativoCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ativoCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Ativo", true));
            this.ativoCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.usuarioBindingSource, "Ativo", true));
            this.ativoCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ativoCheckBox1.Location = new System.Drawing.Point(381, 234);
            this.ativoCheckBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ativoCheckBox1.Name = "ativoCheckBox1";
            this.ativoCheckBox1.Size = new System.Drawing.Size(104, 25);
            this.ativoCheckBox1.TabIndex = 12;
            this.ativoCheckBox1.Text = "Ativo";
            this.ativoCheckBox1.UseVisualStyleBackColor = false;
            this.ativoCheckBox1.CheckedChanged += new System.EventHandler(this.ativoCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSenhaCadastroUsuario);
            this.panel1.Controls.Add(this.ativoCheckBox1);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Controls.Add(this.buttonSalvarCadastrodeUsuario);
            this.panel1.Controls.Add(this.labelNomeUsuario);
            this.panel1.Controls.Add(this.buttonCancelarCadastrodeUsuario);
            this.panel1.Controls.Add(this.labelSenha);
            this.panel1.Controls.Add(this.textBoxNomeCadastroUsuario);
            this.panel1.Controls.Add(this.textBoxRendaCadastroUsuario);
            this.panel1.Controls.Add(this.textBoxNomeUsuarioCadastroUsuario);
            this.panel1.Controls.Add(this.labelRendaCadastroUsuario);
            this.panel1.Controls.Add(this.labelAvisoNome);
            this.panel1.Controls.Add(this.textBoxConfirmarSenhaCadastroUsuario);
            this.panel1.Controls.Add(this.labelAvisoSenha);
            this.panel1.Controls.Add(this.labelConfirmarSenha);
            this.panel1.Location = new System.Drawing.Point(37, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 352);
            this.panel1.TabIndex = 1;
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(736, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(754, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(754, 500);
            this.Name = "FormCadastroUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuário";
            this.Load += new System.EventHandler(this.FormCadastroUsuario_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxNomeCadastroUsuario;
        private System.Windows.Forms.TextBox textBoxNomeUsuarioCadastroUsuario;
        private System.Windows.Forms.TextBox textBoxSenhaCadastroUsuario;
        private System.Windows.Forms.Label labelAvisoNome;
        private System.Windows.Forms.Label labelAvisoSenha;
        private System.Windows.Forms.Label labelConfirmarSenha;
        private System.Windows.Forms.TextBox textBoxConfirmarSenhaCadastroUsuario;
        private System.Windows.Forms.Label labelRendaCadastroUsuario;
        private System.Windows.Forms.TextBox textBoxRendaCadastroUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelarCadastrodeUsuario;
        private System.Windows.Forms.Button buttonSalvarCadastrodeUsuario;
        private System.Windows.Forms.CheckBox ativoCheckBox1;
        private System.Windows.Forms.Panel panel1;
    }
}