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
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenhaLogin = new System.Windows.Forms.TextBox();
            this.labelUsuarioLogin = new System.Windows.Forms.Label();
            this.labelSenhaLogin = new System.Windows.Forms.Label();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonsair = new System.Windows.Forms.Button();
            this.checkBoxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1129, 735);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(448, 201);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(339, 29);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.Text = "ana";
            // 
            // textBoxSenhaLogin
            // 
            this.textBoxSenhaLogin.Location = new System.Drawing.Point(445, 278);
            this.textBoxSenhaLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSenhaLogin.Multiline = true;
            this.textBoxSenhaLogin.Name = "textBoxSenhaLogin";
            this.textBoxSenhaLogin.PasswordChar = '*';
            this.textBoxSenhaLogin.Size = new System.Drawing.Size(312, 29);
            this.textBoxSenhaLogin.TabIndex = 4;
            this.textBoxSenhaLogin.Text = "123456";
            // 
            // labelUsuarioLogin
            // 
            this.labelUsuarioLogin.AutoSize = true;
            this.labelUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioLogin.ForeColor = System.Drawing.Color.Black;
            this.labelUsuarioLogin.Location = new System.Drawing.Point(304, 207);
            this.labelUsuarioLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuarioLogin.Name = "labelUsuarioLogin";
            this.labelUsuarioLogin.Size = new System.Drawing.Size(122, 18);
            this.labelUsuarioLogin.TabIndex = 1;
            this.labelUsuarioLogin.Text = "Nome Usuario:";
            // 
            // labelSenhaLogin
            // 
            this.labelSenhaLogin.AutoSize = true;
            this.labelSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaLogin.Location = new System.Drawing.Point(365, 286);
            this.labelSenhaLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSenhaLogin.Name = "labelSenhaLogin";
            this.labelSenhaLogin.Size = new System.Drawing.Size(60, 18);
            this.labelSenhaLogin.TabIndex = 3;
            this.labelSenhaLogin.Text = "Senha:";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.Location = new System.Drawing.Point(464, 397);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(96, 34);
            this.buttonEntrar.TabIndex = 5;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // buttonsair
            // 
            this.buttonsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsair.Location = new System.Drawing.Point(602, 397);
            this.buttonsair.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsair.Name = "buttonsair";
            this.buttonsair.Size = new System.Drawing.Size(97, 34);
            this.buttonsair.TabIndex = 6;
            this.buttonsair.Text = "Sair";
            this.buttonsair.UseVisualStyleBackColor = true;
            this.buttonsair.Click += new System.EventHandler(this.buttonsair_Click);
            // 
            // checkBoxMostrarSenha
            // 
            this.checkBoxMostrarSenha.AutoSize = true;
            this.checkBoxMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrarSenha.Location = new System.Drawing.Point(536, 337);
            this.checkBoxMostrarSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMostrarSenha.Name = "checkBoxMostrarSenha";
            this.checkBoxMostrarSenha.Size = new System.Drawing.Size(120, 19);
            this.checkBoxMostrarSenha.TabIndex = 7;
            this.checkBoxMostrarSenha.Text = "Mostrar a Senha";
            this.checkBoxMostrarSenha.UseVisualStyleBackColor = true;
            this.checkBoxMostrarSenha.CheckedChanged += new System.EventHandler(this.checkBoxMostrarSenha_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(91)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1129, 100);
            this.label1.TabIndex = 8;
            this.label1.Text = "Controle finanças pessoais";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 735);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxMostrarSenha);
            this.Controls.Add(this.buttonsair);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.labelSenhaLogin);
            this.Controls.Add(this.labelUsuarioLogin);
            this.Controls.Add(this.textBoxSenhaLogin);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenhaLogin;
        internal System.Windows.Forms.Label labelUsuarioLogin;
        private System.Windows.Forms.Label labelSenhaLogin;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button buttonsair;
        private System.Windows.Forms.CheckBox checkBoxMostrarSenha;
        private System.Windows.Forms.Label label1;
    }
}