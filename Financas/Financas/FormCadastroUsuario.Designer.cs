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
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(124, 128);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(64, 25);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUsuario.Location = new System.Drawing.Point(330, 128);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(163, 25);
            this.labelNomeUsuario.TabIndex = 1;
            this.labelNomeUsuario.Text = "Nome de Usuario";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(118, 291);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(70, 25);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxNomeCadastroUsuario
            // 
            this.textBoxNomeCadastroUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.textBoxNomeCadastroUsuario.Location = new System.Drawing.Point(72, 168);
            this.textBoxNomeCadastroUsuario.Name = "textBoxNomeCadastroUsuario";
            this.textBoxNomeCadastroUsuario.Size = new System.Drawing.Size(161, 22);
            this.textBoxNomeCadastroUsuario.TabIndex = 3;
            // 
            // textBoxNomeUsuarioCadastroUsuario
            // 
            this.textBoxNomeUsuarioCadastroUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.textBoxNomeUsuarioCadastroUsuario.Location = new System.Drawing.Point(319, 168);
            this.textBoxNomeUsuarioCadastroUsuario.Name = "textBoxNomeUsuarioCadastroUsuario";
            this.textBoxNomeUsuarioCadastroUsuario.Size = new System.Drawing.Size(191, 22);
            this.textBoxNomeUsuarioCadastroUsuario.TabIndex = 4;
            // 
            // textBoxSenhaCadastroUsuario
            // 
            this.textBoxSenhaCadastroUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.textBoxSenhaCadastroUsuario.Location = new System.Drawing.Point(72, 319);
            this.textBoxSenhaCadastroUsuario.Name = "textBoxSenhaCadastroUsuario";
            this.textBoxSenhaCadastroUsuario.Size = new System.Drawing.Size(161, 22);
            this.textBoxSenhaCadastroUsuario.TabIndex = 5;
            // 
            // labelAvisoNome
            // 
            this.labelAvisoNome.AutoSize = true;
            this.labelAvisoNome.Location = new System.Drawing.Point(71, 200);
            this.labelAvisoNome.Name = "labelAvisoNome";
            this.labelAvisoNome.Size = new System.Drawing.Size(162, 32);
            this.labelAvisoNome.TabIndex = 6;
            this.labelAvisoNome.Text = "Obs: O nome deve conter \r\n  mais de três caracteres";
            // 
            // labelAvisoSenha
            // 
            this.labelAvisoSenha.AutoSize = true;
            this.labelAvisoSenha.Location = new System.Drawing.Point(69, 344);
            this.labelAvisoSenha.Name = "labelAvisoSenha";
            this.labelAvisoSenha.Size = new System.Drawing.Size(164, 32);
            this.labelAvisoSenha.TabIndex = 7;
            this.labelAvisoSenha.Text = "Obs: A senha deve conter \r\n  mais de três caracteres";
            // 
            // buttonSalvarCadastroUsuario
            // 
            this.buttonSalvarCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroUsuario.Location = new System.Drawing.Point(378, 456);
            this.buttonSalvarCadastroUsuario.Name = "buttonSalvarCadastroUsuario";
            this.buttonSalvarCadastroUsuario.Size = new System.Drawing.Size(85, 39);
            this.buttonSalvarCadastroUsuario.TabIndex = 8;
            this.buttonSalvarCadastroUsuario.Text = "Salvar";
            this.buttonSalvarCadastroUsuario.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarCadastroUsuario
            // 
            this.buttonCancelarCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastroUsuario.Location = new System.Drawing.Point(482, 456);
            this.buttonCancelarCadastroUsuario.Name = "buttonCancelarCadastroUsuario";
            this.buttonCancelarCadastroUsuario.Size = new System.Drawing.Size(85, 39);
            this.buttonCancelarCadastroUsuario.TabIndex = 9;
            this.buttonCancelarCadastroUsuario.Text = "Cancelar";
            this.buttonCancelarCadastroUsuario.UseVisualStyleBackColor = true;
            // 
            // labelConfirmarSenha
            // 
            this.labelConfirmarSenha.AutoSize = true;
            this.labelConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmarSenha.Location = new System.Drawing.Point(330, 291);
            this.labelConfirmarSenha.Name = "labelConfirmarSenha";
            this.labelConfirmarSenha.Size = new System.Drawing.Size(160, 25);
            this.labelConfirmarSenha.TabIndex = 10;
            this.labelConfirmarSenha.Text = "Confirmar Senha";
            // 
            // textBoxConfirmarSenhaCadastroUsuario
            // 
            this.textBoxConfirmarSenhaCadastroUsuario.Location = new System.Drawing.Point(319, 319);
            this.textBoxConfirmarSenhaCadastroUsuario.Name = "textBoxConfirmarSenhaCadastroUsuario";
            this.textBoxConfirmarSenhaCadastroUsuario.Size = new System.Drawing.Size(191, 22);
            this.textBoxConfirmarSenhaCadastroUsuario.TabIndex = 11;
            // 
            // labelRendaCadastroUsuario
            // 
            this.labelRendaCadastroUsuario.AutoSize = true;
            this.labelRendaCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRendaCadastroUsuario.Location = new System.Drawing.Point(239, 382);
            this.labelRendaCadastroUsuario.Name = "labelRendaCadastroUsuario";
            this.labelRendaCadastroUsuario.Size = new System.Drawing.Size(69, 25);
            this.labelRendaCadastroUsuario.TabIndex = 12;
            this.labelRendaCadastroUsuario.Text = "Renda";
            // 
            // textBoxRendaCadastroUsuario
            // 
            this.textBoxRendaCadastroUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Renda", true));
            this.textBoxRendaCadastroUsuario.Location = new System.Drawing.Point(193, 415);
            this.textBoxRendaCadastroUsuario.Name = "textBoxRendaCadastroUsuario";
            this.textBoxRendaCadastroUsuario.Size = new System.Drawing.Size(156, 22);
            this.textBoxRendaCadastroUsuario.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro de Usuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 514);
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
            this.Name = "FormCadastroUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroUsuario";
            this.Load += new System.EventHandler(this.FormCadastroUsuario_Load);
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
    }
}