namespace Financas
{
    partial class FormConsultaBanco
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
            this.bancoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConsultarBanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdicionarBanco = new System.Windows.Forms.Button();
            this.buttonBuscarBanco = new System.Windows.Forms.Button();
            this.buttonExcluirBanco = new System.Windows.Forms.Button();
            this.buttonAlterarBanco = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bancoDataGridView
            // 
            this.bancoDataGridView.AllowUserToAddRows = false;
            this.bancoDataGridView.AllowUserToDeleteRows = false;
            this.bancoDataGridView.AllowUserToOrderColumns = true;
            this.bancoDataGridView.AutoGenerateColumns = false;
            this.bancoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bancoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bancoDataGridView.DataSource = this.bancoBindingSource;
            this.bancoDataGridView.Location = new System.Drawing.Point(26, 136);
            this.bancoDataGridView.Name = "bancoDataGridView";
            this.bancoDataGridView.ReadOnly = true;
            this.bancoDataGridView.RowHeadersWidth = 51;
            this.bancoDataGridView.RowTemplate.Height = 24;
            this.bancoDataGridView.Size = new System.Drawing.Size(740, 266);
            this.bancoDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxConsultarBanco
            // 
            this.textBoxConsultarBanco.Location = new System.Drawing.Point(96, 107);
            this.textBoxConsultarBanco.Name = "textBoxConsultarBanco";
            this.textBoxConsultarBanco.Size = new System.Drawing.Size(296, 22);
            this.textBoxConsultarBanco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 83);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consultar Banco";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonAdicionarBanco
            // 
            this.buttonAdicionarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarBanco.Location = new System.Drawing.Point(479, 107);
            this.buttonAdicionarBanco.Name = "buttonAdicionarBanco";
            this.buttonAdicionarBanco.Size = new System.Drawing.Size(88, 23);
            this.buttonAdicionarBanco.TabIndex = 5;
            this.buttonAdicionarBanco.Text = "Adicionar";
            this.buttonAdicionarBanco.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarBanco
            // 
            this.buttonBuscarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarBanco.Location = new System.Drawing.Point(398, 107);
            this.buttonBuscarBanco.Name = "buttonBuscarBanco";
            this.buttonBuscarBanco.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarBanco.TabIndex = 5;
            this.buttonBuscarBanco.Text = "Buscar";
            this.buttonBuscarBanco.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirBanco
            // 
            this.buttonExcluirBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirBanco.Location = new System.Drawing.Point(654, 107);
            this.buttonExcluirBanco.Name = "buttonExcluirBanco";
            this.buttonExcluirBanco.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirBanco.TabIndex = 5;
            this.buttonExcluirBanco.Text = "Excluir";
            this.buttonExcluirBanco.UseVisualStyleBackColor = true;
            this.buttonExcluirBanco.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAlterarBanco
            // 
            this.buttonAlterarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarBanco.Location = new System.Drawing.Point(573, 107);
            this.buttonAlterarBanco.Name = "buttonAlterarBanco";
            this.buttonAlterarBanco.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarBanco.TabIndex = 5;
            this.buttonAlterarBanco.Text = "Alterar";
            this.buttonAlterarBanco.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 47;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Saldo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Saldo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Poupanca";
            this.dataGridViewTextBoxColumn4.HeaderText = "Poupanca";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataSource = typeof(Models.Banco);
            // 
            // FormConsultaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBuscarBanco);
            this.Controls.Add(this.buttonAlterarBanco);
            this.Controls.Add(this.buttonExcluirBanco);
            this.Controls.Add(this.buttonAdicionarBanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxConsultarBanco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bancoDataGridView);
            this.Name = "FormConsultaBanco";
            this.Text = "FormConsultaBanco";
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bancoBindingSource;
        private System.Windows.Forms.DataGridView bancoDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConsultarBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdicionarBanco;
        private System.Windows.Forms.Button buttonBuscarBanco;
        private System.Windows.Forms.Button buttonExcluirBanco;
        private System.Windows.Forms.Button buttonAlterarBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}