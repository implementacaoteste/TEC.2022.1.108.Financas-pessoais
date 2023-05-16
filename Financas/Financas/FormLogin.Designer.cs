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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.textBoxUsuario.Location = new System.Drawing.Point(431, 315);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(312, 22);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // textBoxSenhaLogin
            // 
            this.textBoxSenhaLogin.Location = new System.Drawing.Point(431, 369);
            this.textBoxSenhaLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSenhaLogin.Name = "textBoxSenhaLogin";
            this.textBoxSenhaLogin.PasswordChar = '*';
            this.textBoxSenhaLogin.Size = new System.Drawing.Size(312, 22);
            this.textBoxSenhaLogin.TabIndex = 4;
            // 
            // labelUsuarioLogin
            // 
            this.labelUsuarioLogin.AutoSize = true;
            this.labelUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioLogin.ForeColor = System.Drawing.Color.Black;
            this.labelUsuarioLogin.Location = new System.Drawing.Point(259, 319);
            this.labelUsuarioLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuarioLogin.Name = "labelUsuarioLogin";
            this.labelUsuarioLogin.Size = new System.Drawing.Size(142, 18);
            this.labelUsuarioLogin.TabIndex = 1;
            this.labelUsuarioLogin.Text = "Nome de usuário:";
            // 
            // labelSenhaLogin
            // 
            this.labelSenhaLogin.AutoSize = true;
            this.labelSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaLogin.Location = new System.Drawing.Point(352, 373);
            this.labelSenhaLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSenhaLogin.Name = "labelSenhaLogin";
            this.labelSenhaLogin.Size = new System.Drawing.Size(60, 18);
            this.labelSenhaLogin.TabIndex = 3;
            this.labelSenhaLogin.Text = "Senha:";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.Location = new System.Drawing.Point(470, 474);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(96, 34);
            this.buttonEntrar.TabIndex = 6;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            this.buttonEntrar.MouseEnter += new System.EventHandler(this.buttonEntrar_MouseEnter);
            this.buttonEntrar.MouseLeave += new System.EventHandler(this.buttonEntrar_MouseLeave);
            // 
            // buttonsair
            // 
            this.buttonsair.BackColor = System.Drawing.Color.Transparent;
            this.buttonsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsair.Location = new System.Drawing.Point(601, 474);
            this.buttonsair.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsair.Name = "buttonsair";
            this.buttonsair.Size = new System.Drawing.Size(97, 34);
            this.buttonsair.TabIndex = 7;
            this.buttonsair.Text = "Sair";
            this.buttonsair.UseVisualStyleBackColor = false;
            this.buttonsair.Click += new System.EventHandler(this.buttonsair_Click);
            // 
            // checkBoxMostrarSenha
            // 
            this.checkBoxMostrarSenha.AutoSize = true;
            this.checkBoxMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrarSenha.Location = new System.Drawing.Point(519, 420);
            this.checkBoxMostrarSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMostrarSenha.Name = "checkBoxMostrarSenha";
            this.checkBoxMostrarSenha.Size = new System.Drawing.Size(120, 19);
            this.checkBoxMostrarSenha.TabIndex = 5;
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
            this.label1.Text = "CONTROLE FINANÇAS PESSOAIS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(497, 616);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(212, 31);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Suporte Tecnico";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(438, 616);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(98)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(519, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 735);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}