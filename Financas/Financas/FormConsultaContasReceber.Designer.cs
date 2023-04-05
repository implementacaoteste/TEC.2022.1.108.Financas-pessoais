namespace Financas
{
    partial class FormConsultaContasReceber
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
            this.contasReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscarContasReceber = new System.Windows.Forms.Button();
            this.buttonAlterarContasReceber = new System.Windows.Forms.Button();
            this.buttonExcluirContasReceber = new System.Windows.Forms.Button();
            this.buttonAdicionarContasReceber = new System.Windows.Forms.Button();
            this.textBoxConsultarContasReceber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contasReceberDataGridView
            // 
            this.contasReceberDataGridView.AllowUserToAddRows = false;
            this.contasReceberDataGridView.AllowUserToDeleteRows = false;
            this.contasReceberDataGridView.AllowUserToOrderColumns = true;
            this.contasReceberDataGridView.AutoGenerateColumns = false;
            this.contasReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contasReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.contasReceberDataGridView.DataSource = this.contasReceberBindingSource;
            this.contasReceberDataGridView.Location = new System.Drawing.Point(26, 110);
            this.contasReceberDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contasReceberDataGridView.Name = "contasReceberDataGridView";
            this.contasReceberDataGridView.ReadOnly = true;
            this.contasReceberDataGridView.RowHeadersWidth = 51;
            this.contasReceberDataGridView.RowTemplate.Height = 24;
            this.contasReceberDataGridView.Size = new System.Drawing.Size(555, 216);
            this.contasReceberDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ValorReceber";
            this.dataGridViewTextBoxColumn2.FillWeight = 157.2193F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor a receber";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 147;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.FillWeight = 42.78075F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(Models.ContasReceber);
            // 
            // buttonBuscarContasReceber
            // 
            this.buttonBuscarContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContasReceber.Location = new System.Drawing.Point(325, 85);
            this.buttonBuscarContasReceber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarContasReceber.Name = "buttonBuscarContasReceber";
            this.buttonBuscarContasReceber.Size = new System.Drawing.Size(64, 19);
            this.buttonBuscarContasReceber.TabIndex = 8;
            this.buttonBuscarContasReceber.Text = "Buscar";
            this.buttonBuscarContasReceber.UseVisualStyleBackColor = true;
            this.buttonBuscarContasReceber.Click += new System.EventHandler(this.buttonBuscarContasReceber_Click);
            // 
            // buttonAlterarContasReceber
            // 
            this.buttonAlterarContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarContasReceber.Location = new System.Drawing.Point(464, 85);
            this.buttonAlterarContasReceber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAlterarContasReceber.Name = "buttonAlterarContasReceber";
            this.buttonAlterarContasReceber.Size = new System.Drawing.Size(56, 19);
            this.buttonAlterarContasReceber.TabIndex = 9;
            this.buttonAlterarContasReceber.Text = "Alterar";
            this.buttonAlterarContasReceber.UseVisualStyleBackColor = true;
            this.buttonAlterarContasReceber.Click += new System.EventHandler(this.buttonAlterarContasReceber_Click);
            // 
            // buttonExcluirContasReceber
            // 
            this.buttonExcluirContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirContasReceber.Location = new System.Drawing.Point(525, 85);
            this.buttonExcluirContasReceber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExcluirContasReceber.Name = "buttonExcluirContasReceber";
            this.buttonExcluirContasReceber.Size = new System.Drawing.Size(56, 19);
            this.buttonExcluirContasReceber.TabIndex = 10;
            this.buttonExcluirContasReceber.Text = "Excluir";
            this.buttonExcluirContasReceber.UseVisualStyleBackColor = true;
            this.buttonExcluirContasReceber.Click += new System.EventHandler(this.buttonExcluirContasReceber_Click);
            // 
            // buttonAdicionarContasReceber
            // 
            this.buttonAdicionarContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarContasReceber.Location = new System.Drawing.Point(394, 85);
            this.buttonAdicionarContasReceber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionarContasReceber.Name = "buttonAdicionarContasReceber";
            this.buttonAdicionarContasReceber.Size = new System.Drawing.Size(66, 19);
            this.buttonAdicionarContasReceber.TabIndex = 11;
            this.buttonAdicionarContasReceber.Text = "Adicionar";
            this.buttonAdicionarContasReceber.UseVisualStyleBackColor = true;
            this.buttonAdicionarContasReceber.Click += new System.EventHandler(this.buttonAdicionarContasReceber_Click);
            // 
            // textBoxConsultarContasReceber
            // 
            this.textBoxConsultarContasReceber.Location = new System.Drawing.Point(78, 86);
            this.textBoxConsultarContasReceber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxConsultarContasReceber.Name = "textBoxConsultarContasReceber";
            this.textBoxConsultarContasReceber.Size = new System.Drawing.Size(243, 20);
            this.textBoxConsultarContasReceber.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consulta";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(618, 70);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consulta de contas a receber";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(525, 331);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(56, 19);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // FormConsultaContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuscarContasReceber);
            this.Controls.Add(this.buttonAlterarContasReceber);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonExcluirContasReceber);
            this.Controls.Add(this.buttonAdicionarContasReceber);
            this.Controls.Add(this.textBoxConsultarContasReceber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contasReceberDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaContasReceber";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaContasReceber";
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.DataGridView contasReceberDataGridView;
        private System.Windows.Forms.Button buttonBuscarContasReceber;
        private System.Windows.Forms.Button buttonAlterarContasReceber;
        private System.Windows.Forms.Button buttonExcluirContasReceber;
        private System.Windows.Forms.Button buttonAdicionarContasReceber;
        private System.Windows.Forms.TextBox textBoxConsultarContasReceber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonSair;
    }
}