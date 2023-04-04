namespace Financas
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenhaLogin = new System.Windows.Forms.TextBox();
            this.labelUsuarioLogin = new System.Windows.Forms.Label();
            this.labelSenhaLogin = new System.Windows.Forms.Label();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonsair = new System.Windows.Forms.Button();
            this.labelesqueceuUsuarioouSenha = new System.Windows.Forms.Label();
            this.buttonCdastraLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(145, 188);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(312, 29);
            this.textBoxUsuario.TabIndex = 8;
            // 
            // textBoxSenhaLogin
            // 
            this.textBoxSenhaLogin.Location = new System.Drawing.Point(145, 240);
            this.textBoxSenhaLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSenhaLogin.Multiline = true;
            this.textBoxSenhaLogin.Name = "textBoxSenhaLogin";
            this.textBoxSenhaLogin.PasswordChar = '*';
            this.textBoxSenhaLogin.Size = new System.Drawing.Size(312, 29);
            this.textBoxSenhaLogin.TabIndex = 3;
            // 
            // labelUsuarioLogin
            // 
            this.labelUsuarioLogin.AutoSize = true;
            this.labelUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioLogin.Location = new System.Drawing.Point(64, 194);
            this.labelUsuarioLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuarioLogin.Name = "labelUsuarioLogin";
            this.labelUsuarioLogin.Size = new System.Drawing.Size(77, 18);
            this.labelUsuarioLogin.TabIndex = 4;
            this.labelUsuarioLogin.Text = " Usuário:";
            this.labelUsuarioLogin.Click += new System.EventHandler(this.labelUsuarioLogin_Click);
            // 
            // labelSenhaLogin
            // 
            this.labelSenhaLogin.AutoSize = true;
            this.labelSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaLogin.Location = new System.Drawing.Point(75, 246);
            this.labelSenhaLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSenhaLogin.Name = "labelSenhaLogin";
            this.labelSenhaLogin.Size = new System.Drawing.Size(60, 18);
            this.labelSenhaLogin.TabIndex = 4;
            this.labelSenhaLogin.Text = "Senha:";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.Location = new System.Drawing.Point(214, 320);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(66, 35);
            this.buttonEntrar.TabIndex = 5;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // buttonsair
            // 
            this.buttonsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsair.Location = new System.Drawing.Point(303, 320);
            this.buttonsair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonsair.Name = "buttonsair";
            this.buttonsair.Size = new System.Drawing.Size(66, 35);
            this.buttonsair.TabIndex = 5;
            this.buttonsair.Text = "Sair";
            this.buttonsair.UseVisualStyleBackColor = true;
            this.buttonsair.Click += new System.EventHandler(this.buttonsair_Click);
            // 
            // labelesqueceuUsuarioouSenha
            // 
            this.labelesqueceuUsuarioouSenha.AutoSize = true;
            this.labelesqueceuUsuarioouSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelesqueceuUsuarioouSenha.Location = new System.Drawing.Point(164, 273);
            this.labelesqueceuUsuarioouSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelesqueceuUsuarioouSenha.Name = "labelesqueceuUsuarioouSenha";
            this.labelesqueceuUsuarioouSenha.Size = new System.Drawing.Size(215, 17);
            this.labelesqueceuUsuarioouSenha.TabIndex = 4;
            this.labelesqueceuUsuarioouSenha.Text = "Esqueceu  usuário ou senha";
            // 
            // buttonCdastraLogin
            // 
            this.buttonCdastraLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCdastraLogin.Location = new System.Drawing.Point(193, 375);
            this.buttonCdastraLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCdastraLogin.Name = "buttonCdastraLogin";
            this.buttonCdastraLogin.Size = new System.Drawing.Size(195, 38);
            this.buttonCdastraLogin.TabIndex = 5;
            this.buttonCdastraLogin.Text = "Cadastra-se";
            this.buttonCdastraLogin.UseVisualStyleBackColor = true;
            this.buttonCdastraLogin.Click += new System.EventHandler(this.buttonCdastraLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.buttonsair);
            this.Controls.Add(this.buttonCdastraLogin);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.labelesqueceuUsuarioouSenha);
            this.Controls.Add(this.labelSenhaLogin);
            this.Controls.Add(this.labelUsuarioLogin);
            this.Controls.Add(this.textBoxSenhaLogin);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenhaLogin;
        internal System.Windows.Forms.Label labelUsuarioLogin;
        private System.Windows.Forms.Label labelSenhaLogin;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button buttonsair;
        private System.Windows.Forms.Label labelesqueceuUsuarioouSenha;
        private System.Windows.Forms.Button buttonCdastraLogin;
    }
}