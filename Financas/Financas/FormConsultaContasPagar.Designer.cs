namespace Financas
{
    partial class FormConsultaContasPagar
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
            this.contasPagarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelConsultarContasPagar = new System.Windows.Forms.Label();
            this.textBoxConsultaContasPagar = new System.Windows.Forms.TextBox();
            this.buttonBuscarConsultaContasPagar = new System.Windows.Forms.Button();
            this.buttonAdicionarConsultaContasPagar = new System.Windows.Forms.Button();
            this.buttonAlterarConsultaContasPagar = new System.Windows.Forms.Button();
            this.buttonExcluirConsultaContasPagar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contasPagarDataGridView
            // 
            this.contasPagarDataGridView.AllowUserToAddRows = false;
            this.contasPagarDataGridView.AllowUserToDeleteRows = false;
            this.contasPagarDataGridView.AllowUserToOrderColumns = true;
            this.contasPagarDataGridView.AutoGenerateColumns = false;
            this.contasPagarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contasPagarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.contasPagarDataGridView.DataSource = this.contasPagarBindingSource;
            this.contasPagarDataGridView.Location = new System.Drawing.Point(26, 110);
            this.contasPagarDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contasPagarDataGridView.Name = "contasPagarDataGridView";
            this.contasPagarDataGridView.ReadOnly = true;
            this.contasPagarDataGridView.RowHeadersWidth = 51;
            this.contasPagarDataGridView.RowTemplate.Height = 24;
            this.contasPagarDataGridView.Size = new System.Drawing.Size(555, 216);
            this.contasPagarDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ValorPagar";
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor a pagar";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // contasPagarBindingSource
            // 
            this.contasPagarBindingSource.DataSource = typeof(Models.ContasPagar);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta de Contas a Pagar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelConsultarContasPagar
            // 
            this.labelConsultarContasPagar.AutoSize = true;
            this.labelConsultarContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultarContasPagar.Location = new System.Drawing.Point(24, 90);
            this.labelConsultarContasPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsultarContasPagar.Name = "labelConsultarContasPagar";
            this.labelConsultarContasPagar.Size = new System.Drawing.Size(56, 13);
            this.labelConsultarContasPagar.TabIndex = 3;
            this.labelConsultarContasPagar.Text = "Consulta";
            // 
            // textBoxConsultaContasPagar
            // 
            this.textBoxConsultaContasPagar.Location = new System.Drawing.Point(79, 89);
            this.textBoxConsultaContasPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxConsultaContasPagar.Name = "textBoxConsultaContasPagar";
            this.textBoxConsultaContasPagar.Size = new System.Drawing.Size(256, 20);
            this.textBoxConsultaContasPagar.TabIndex = 4;
            // 
            // buttonBuscarConsultaContasPagar
            // 
            this.buttonBuscarConsultaContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarConsultaContasPagar.Location = new System.Drawing.Point(338, 88);
            this.buttonBuscarConsultaContasPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarConsultaContasPagar.Name = "buttonBuscarConsultaContasPagar";
            this.buttonBuscarConsultaContasPagar.Size = new System.Drawing.Size(56, 19);
            this.buttonBuscarConsultaContasPagar.TabIndex = 5;
            this.buttonBuscarConsultaContasPagar.Text = "Buscar";
            this.buttonBuscarConsultaContasPagar.UseVisualStyleBackColor = true;
            this.buttonBuscarConsultaContasPagar.Click += new System.EventHandler(this.buttonBuscarConsultaContasPagar_Click);
            // 
            // buttonAdicionarConsultaContasPagar
            // 
            this.buttonAdicionarConsultaContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarConsultaContasPagar.Location = new System.Drawing.Point(399, 88);
            this.buttonAdicionarConsultaContasPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionarConsultaContasPagar.Name = "buttonAdicionarConsultaContasPagar";
            this.buttonAdicionarConsultaContasPagar.Size = new System.Drawing.Size(61, 19);
            this.buttonAdicionarConsultaContasPagar.TabIndex = 6;
            this.buttonAdicionarConsultaContasPagar.Text = "Adicionar";
            this.buttonAdicionarConsultaContasPagar.UseVisualStyleBackColor = true;
            this.buttonAdicionarConsultaContasPagar.Click += new System.EventHandler(this.buttonAdicionarConsultaContasPagar_Click);
            // 
            // buttonAlterarConsultaContasPagar
            // 
            this.buttonAlterarConsultaContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarConsultaContasPagar.Location = new System.Drawing.Point(464, 88);
            this.buttonAlterarConsultaContasPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAlterarConsultaContasPagar.Name = "buttonAlterarConsultaContasPagar";
            this.buttonAlterarConsultaContasPagar.Size = new System.Drawing.Size(56, 19);
            this.buttonAlterarConsultaContasPagar.TabIndex = 7;
            this.buttonAlterarConsultaContasPagar.Text = "Alterar";
            this.buttonAlterarConsultaContasPagar.UseVisualStyleBackColor = true;
            this.buttonAlterarConsultaContasPagar.Click += new System.EventHandler(this.buttonAlterarConsultaContasPagar_Click);
            // 
            // buttonExcluirConsultaContasPagar
            // 
            this.buttonExcluirConsultaContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirConsultaContasPagar.Location = new System.Drawing.Point(525, 88);
            this.buttonExcluirConsultaContasPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExcluirConsultaContasPagar.Name = "buttonExcluirConsultaContasPagar";
            this.buttonExcluirConsultaContasPagar.Size = new System.Drawing.Size(56, 19);
            this.buttonExcluirConsultaContasPagar.TabIndex = 8;
            this.buttonExcluirConsultaContasPagar.Text = "Excluir";
            this.buttonExcluirConsultaContasPagar.UseVisualStyleBackColor = true;
            this.buttonExcluirConsultaContasPagar.Click += new System.EventHandler(this.buttonExcluirConsultaContasPagar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(525, 331);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(56, 19);
            this.buttonSair.TabIndex = 8;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // FormConsultaContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 361);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonExcluirConsultaContasPagar);
            this.Controls.Add(this.buttonAlterarConsultaContasPagar);
            this.Controls.Add(this.buttonAdicionarConsultaContasPagar);
            this.Controls.Add(this.buttonBuscarConsultaContasPagar);
            this.Controls.Add(this.textBoxConsultaContasPagar);
            this.Controls.Add(this.labelConsultarContasPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contasPagarDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaContasPagar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Contas a Pagar";
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contasPagarBindingSource;
        private System.Windows.Forms.DataGridView contasPagarDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConsultarContasPagar;
        private System.Windows.Forms.TextBox textBoxConsultaContasPagar;
        private System.Windows.Forms.Button buttonBuscarConsultaContasPagar;
        private System.Windows.Forms.Button buttonAdicionarConsultaContasPagar;
        private System.Windows.Forms.Button buttonAlterarConsultaContasPagar;
        private System.Windows.Forms.Button buttonExcluirConsultaContasPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonSair;
    }
}