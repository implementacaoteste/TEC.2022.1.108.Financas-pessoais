namespace Financas
{
    partial class ConfirmarAlteração
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
            System.Windows.Forms.Label ConfirmarSenhaAlteração;
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.senhaAlteracaoTextBox = new System.Windows.Forms.TextBox();
            this.confirmarAlteracao = new System.Windows.Forms.Button();
            this.cancelarAlteracao = new System.Windows.Forms.Button();
            ConfirmarSenhaAlteração = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmarSenhaAlteração
            // 
            ConfirmarSenhaAlteração.AutoSize = true;
            ConfirmarSenhaAlteração.BackColor = System.Drawing.SystemColors.ButtonFace;
            ConfirmarSenhaAlteração.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            ConfirmarSenhaAlteração.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ConfirmarSenhaAlteração.ForeColor = System.Drawing.Color.Black;
            ConfirmarSenhaAlteração.Location = new System.Drawing.Point(56, 112);
            ConfirmarSenhaAlteração.Name = "ConfirmarSenhaAlteração";
            ConfirmarSenhaAlteração.Size = new System.Drawing.Size(170, 20);
            ConfirmarSenhaAlteração.TabIndex = 2;
            ConfirmarSenhaAlteração.Text = "Confirmar sua senha:";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONFIRMAR SENHA PARA FAZER ALTERAÇÕES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // senhaAlteracaoTextBox
            // 
            this.senhaAlteracaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaAlteracaoTextBox.Location = new System.Drawing.Point(242, 110);
            this.senhaAlteracaoTextBox.Name = "senhaAlteracaoTextBox";
            this.senhaAlteracaoTextBox.Size = new System.Drawing.Size(190, 22);
            this.senhaAlteracaoTextBox.TabIndex = 3;
            // 
            // confirmarAlteracao
            // 
            this.confirmarAlteracao.BackColor = System.Drawing.SystemColors.Control;
            this.confirmarAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarAlteracao.Location = new System.Drawing.Point(282, 185);
            this.confirmarAlteracao.Name = "confirmarAlteracao";
            this.confirmarAlteracao.Size = new System.Drawing.Size(96, 36);
            this.confirmarAlteracao.TabIndex = 4;
            this.confirmarAlteracao.Text = "Confirmar";
            this.confirmarAlteracao.UseVisualStyleBackColor = false;
            this.confirmarAlteracao.Click += new System.EventHandler(this.confirmarAlteracao_Click);
            // 
            // cancelarAlteracao
            // 
            this.cancelarAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarAlteracao.Location = new System.Drawing.Point(386, 185);
            this.cancelarAlteracao.Name = "cancelarAlteracao";
            this.cancelarAlteracao.Size = new System.Drawing.Size(107, 36);
            this.cancelarAlteracao.TabIndex = 5;
            this.cancelarAlteracao.Text = "Cancelar";
            this.cancelarAlteracao.UseVisualStyleBackColor = true;
            // 
            // ConfirmarAlteração
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(537, 232);
            this.Controls.Add(this.cancelarAlteracao);
            this.Controls.Add(this.confirmarAlteracao);
            this.Controls.Add(ConfirmarSenhaAlteração);
            this.Controls.Add(this.senhaAlteracaoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmarAlteração";
            this.Text = "ConfirmarAlteração";
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox senhaAlteracaoTextBox;
        private System.Windows.Forms.Button confirmarAlteracao;
        private System.Windows.Forms.Button cancelarAlteracao;
    }
}