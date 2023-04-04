namespace Financas
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.receitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.contatoToolStripMenuItem,
            this.bancoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // contatoToolStripMenuItem
            // 
            this.contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            this.contatoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contatoToolStripMenuItem.Text = "Contato";
            this.contatoToolStripMenuItem.Click += new System.EventHandler(this.contatoToolStripMenuItem_Click);
            // 
            // bancoToolStripMenuItem
            // 
            this.bancoToolStripMenuItem.Name = "bancoToolStripMenuItem";
            this.bancoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bancoToolStripMenuItem.Text = "Banco";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banToolStripMenuItem,
            this.contatoToolStripMenuItem1,
            this.receitasToolStripMenuItem,
            this.despesasToolStripMenuItem,
            this.contasAPagarToolStripMenuItem,
            this.contasAReceberToolStripMenuItem,
            this.formaDePagamentoToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // banToolStripMenuItem
            // 
            this.banToolStripMenuItem.Name = "banToolStripMenuItem";
            this.banToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.banToolStripMenuItem.Text = "Banco";
            this.banToolStripMenuItem.Click += new System.EventHandler(this.banToolStripMenuItem_Click);
            // 
            // contatoToolStripMenuItem1
            // 
            this.contatoToolStripMenuItem1.Name = "contatoToolStripMenuItem1";
            this.contatoToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.contatoToolStripMenuItem1.Text = "Contato";
            this.contatoToolStripMenuItem1.Click += new System.EventHandler(this.contatoToolStripMenuItem1_Click);
            // 
            // receitasToolStripMenuItem
            // 
            this.receitasToolStripMenuItem.Name = "receitasToolStripMenuItem";
            this.receitasToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.receitasToolStripMenuItem.Text = "Receitas";
            this.receitasToolStripMenuItem.Click += new System.EventHandler(this.receitasToolStripMenuItem_Click);
            // 
            // despesasToolStripMenuItem
            // 
            this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            this.despesasToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.despesasToolStripMenuItem.Text = "Despesas";
            this.despesasToolStripMenuItem.Click += new System.EventHandler(this.despesasToolStripMenuItem_Click);
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            this.contasAPagarToolStripMenuItem.Click += new System.EventHandler(this.contasAPagarToolStripMenuItem_Click);
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.contasAReceberToolStripMenuItem.Text = "Contas a receber";
            this.contasAReceberToolStripMenuItem.Click += new System.EventHandler(this.contasAReceberToolStripMenuItem_Click);
            // 
            // formaDePagamentoToolStripMenuItem
            // 
            this.formaDePagamentoToolStripMenuItem.Name = "formaDePagamentoToolStripMenuItem";
            this.formaDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.formaDePagamentoToolStripMenuItem.Text = "Forma de pagamento";
            this.formaDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.formaDePagamentoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaDePagamentoToolStripMenuItem;
    }
}

