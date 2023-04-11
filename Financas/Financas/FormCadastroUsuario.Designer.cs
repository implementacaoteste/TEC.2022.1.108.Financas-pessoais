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
            this.buttonSalvarCadastroUsuario = new System.Windows.Forms.Button();
            this.buttonCancelarCadastroUsuario = new System.Windows.Forms.Button();
            this.labelConfirmarSenha = new System.Windows.Forms.Label();
            this.textBoxConfirmarSenhaCadastroUsuario = new System.Windows.Forms.TextBox();
            this.labelRendaCadastroUsuario = new System.Windows.Forms.Label();
            this.textBoxRendaCadastroUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelarCadastrodeUsuario = new System.Windows.Forms.Button();
            this.buttonSalvarCadastrodeUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(57, 99);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(58, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUsuario.Location = new System.Drawing.Point(57, 211);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(141, 20);
            this.labelNomeUsuario.TabIndex = 1;
            this.labelNomeUsuario.Text = "Nome de usuário:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(401, 97);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(61, 20);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha:";
            // 
            // textBoxNomeCadastroUsuario
            // 
            this.textBoxNomeCadastroUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.textBoxNomeCadastroUsuario.Location = new System.Drawing.Point(61, 124);
            this.textBoxNomeCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNomeCadastroUsuario.Name = "textBoxNomeCadastroUsuario";
            this.textBoxNomeCadastroUsuario.Size = new System.Drawing.Size(282, 22);
            this.textBoxNomeCadastroUsuario.TabIndex = 3;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // textBoxNomeUsuarioCadastroUsuario
            // 
            this.textBoxNomeUsuarioCadastroUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.textBoxNomeUsuarioCadastroUsuario.Location = new System.Drawing.Point(62, 238);
            this.textBoxNomeUsuarioCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNomeUsuarioCadastroUsuario.Name = "textBoxNomeUsuarioCadastroUsuario";
            this.textBoxNomeUsuarioCadastroUsuario.Size = new System.Drawing.Size(254, 22);
            this.textBoxNomeUsuarioCadastroUsuario.TabIndex = 4;
            // 
            // textBoxSenhaCadastroUsuario
            // 
            this.textBoxSenhaCadastroUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.textBoxSenhaCadastroUsuario.Location = new System.Drawing.Point(406, 124);
            this.textBoxSenhaCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSenhaCadastroUsuario.Name = "textBoxSenhaCadastroUsuario";
            this.textBoxSenhaCadastroUsuario.Size = new System.Drawing.Size(235, 22);
            this.textBoxSenhaCadastroUsuario.TabIndex = 5;
            // 
            // labelAvisoNome
            // 
            this.labelAvisoNome.AutoSize = true;
            this.labelAvisoNome.Location = new System.Drawing.Point(72, 148);
            this.labelAvisoNome.Name = "labelAvisoNome";
            this.labelAvisoNome.Size = new System.Drawing.Size(162, 32);
            this.labelAvisoNome.TabIndex = 6;
            this.labelAvisoNome.Text = "Obs: O nome deve conter \r\n  mais de três caracteres";
            // 
            // labelAvisoSenha
            // 
            this.labelAvisoSenha.AutoSize = true;
            this.labelAvisoSenha.Location = new System.Drawing.Point(413, 148);
            this.labelAvisoSenha.Name = "labelAvisoSenha";
            this.labelAvisoSenha.Size = new System.Drawing.Size(164, 32);
            this.labelAvisoSenha.TabIndex = 7;
            this.labelAvisoSenha.Text = "Obs: A senha deve conter \r\n  mais de três caracteres";
            // 
            // buttonSalvarCadastroUsuario
            // 
            this.buttonSalvarCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroUsuario.Location = new System.Drawing.Point(379, 455);
            this.buttonSalvarCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarCadastroUsuario.Name = "buttonSalvarCadastroUsuario";
            this.buttonSalvarCadastroUsuario.Size = new System.Drawing.Size(85, 39);
            this.buttonSalvarCadastroUsuario.TabIndex = 8;
            this.buttonSalvarCadastroUsuario.Text = "Salvar";
            this.buttonSalvarCadastroUsuario.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarCadastroUsuario
            // 
            this.buttonCancelarCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastroUsuario.Location = new System.Drawing.Point(483, 455);
            this.buttonCancelarCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelarCadastroUsuario.Name = "buttonCancelarCadastroUsuario";
            this.buttonCancelarCadastroUsuario.Size = new System.Drawing.Size(85, 39);
            this.buttonCancelarCadastroUsuario.TabIndex = 9;
            this.buttonCancelarCadastroUsuario.Text = "Cancelar";
            this.buttonCancelarCadastroUsuario.UseVisualStyleBackColor = true;
            // 
            // labelConfirmarSenha
            // 
            this.labelConfirmarSenha.AutoSize = true;
            this.labelConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmarSenha.Location = new System.Drawing.Point(401, 211);
            this.labelConfirmarSenha.Name = "labelConfirmarSenha";
            this.labelConfirmarSenha.Size = new System.Drawing.Size(140, 20);
            this.labelConfirmarSenha.TabIndex = 10;
            this.labelConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // textBoxConfirmarSenhaCadastroUsuario
            // 
            this.textBoxConfirmarSenhaCadastroUsuario.Location = new System.Drawing.Point(406, 238);
            this.textBoxConfirmarSenhaCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConfirmarSenhaCadastroUsuario.Name = "textBoxConfirmarSenhaCadastroUsuario";
            this.textBoxConfirmarSenhaCadastroUsuario.Size = new System.Drawing.Size(235, 22);
            this.textBoxConfirmarSenhaCadastroUsuario.TabIndex = 11;
            // 
            // labelRendaCadastroUsuario
            // 
            this.labelRendaCadastroUsuario.AutoSize = true;
            this.labelRendaCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRendaCadastroUsuario.Location = new System.Drawing.Point(57, 302);
            this.labelRendaCadastroUsuario.Name = "labelRendaCadastroUsuario";
            this.labelRendaCadastroUsuario.Size = new System.Drawing.Size(62, 20);
            this.labelRendaCadastroUsuario.TabIndex = 12;
            this.labelRendaCadastroUsuario.Text = "Renda:";
            // 
            // textBoxRendaCadastroUsuario
            // 
            this.textBoxRendaCadastroUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Renda", true));
            this.textBoxRendaCadastroUsuario.Location = new System.Drawing.Point(62, 329);
            this.textBoxRendaCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRendaCadastroUsuario.Name = "textBoxRendaCadastroUsuario";
            this.textBoxRendaCadastroUsuario.Size = new System.Drawing.Size(207, 22);
            this.textBoxRendaCadastroUsuario.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 69);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro de usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelarCadastrodeUsuario
            // 
            this.buttonCancelarCadastrodeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastrodeUsuario.Location = new System.Drawing.Point(538, 376);
            this.buttonCancelarCadastrodeUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelarCadastrodeUsuario.Name = "buttonCancelarCadastrodeUsuario";
            this.buttonCancelarCadastrodeUsuario.Size = new System.Drawing.Size(103, 23);
            this.buttonCancelarCadastrodeUsuario.TabIndex = 15;
            this.buttonCancelarCadastrodeUsuario.Text = "Cancelar";
            this.buttonCancelarCadastrodeUsuario.UseVisualStyleBackColor = true;
            this.buttonCancelarCadastrodeUsuario.Click += new System.EventHandler(this.buttonCancelarCadastrodeUsuario_Click);
            // 
            // buttonSalvarCadastrodeUsuario
            // 
            this.buttonSalvarCadastrodeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastrodeUsuario.Location = new System.Drawing.Point(437, 376);
            this.buttonSalvarCadastrodeUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarCadastrodeUsuario.Name = "buttonSalvarCadastrodeUsuario";
            this.buttonSalvarCadastrodeUsuario.Size = new System.Drawing.Size(77, 23);
            this.buttonSalvarCadastrodeUsuario.TabIndex = 15;
            this.buttonSalvarCadastrodeUsuario.Text = "Salvar";
            this.buttonSalvarCadastrodeUsuario.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastrodeUsuario.Click += new System.EventHandler(this.buttonSalvarCadastrodeUsuario_Click);
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 424);
            this.Controls.Add(this.buttonSalvarCadastrodeUsuario);
            this.Controls.Add(this.buttonCancelarCadastrodeUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRendaCadastroUsuario);
            this.Controls.Add(this.labelRendaCadastroUsuario);
            this.Controls.Add(this.textBoxConfirmarSenhaCadastroUsuario);
            this.Controls.Add(this.labelConfirmarSenha);
            this.Controls.Add(this.buttonCancelarCadastroUsuario);
            this.Controls.Add(this.buttonSalvarCadastroUsuario);
            this.Controls.Add(this.labelAvisoSenha);
            this.Controls.Add(this.labelAvisoNome);
            this.Controls.Add(this.textBoxSenhaCadastroUsuario);
            this.Controls.Add(this.textBoxNomeUsuarioCadastroUsuario);
            this.Controls.Add(this.textBoxNomeCadastroUsuario);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.labelNome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastroUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuário";
            this.Load += new System.EventHandler(this.FormCadastroUsuario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonSalvarCadastroUsuario;
        private System.Windows.Forms.Button buttonCancelarCadastroUsuario;
        private System.Windows.Forms.Label labelConfirmarSenha;
        private System.Windows.Forms.TextBox textBoxConfirmarSenhaCadastroUsuario;
        private System.Windows.Forms.Label labelRendaCadastroUsuario;
        private System.Windows.Forms.TextBox textBoxRendaCadastroUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelarCadastrodeUsuario;
        private System.Windows.Forms.Button buttonSalvarCadastrodeUsuario;
    }
}