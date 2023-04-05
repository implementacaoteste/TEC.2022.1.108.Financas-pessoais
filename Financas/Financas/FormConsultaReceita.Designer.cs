namespace Financas
{
    partial class FormConsultaReceita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.receitaDataGridView = new System.Windows.Forms.DataGridView();

            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscarReceita = new System.Windows.Forms.Button();
            this.buttonAlterarReceita = new System.Windows.Forms.Button();
            this.buttonExcluirReceita = new System.Windows.Forms.Button();
            this.buttonAdicionarReceita = new System.Windows.Forms.Button();
            this.textBoxConsultarReceita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();

            this.receitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.receitaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // receitaDataGridView
            // 
            this.receitaDataGridView.AllowUserToAddRows = false;
            this.receitaDataGridView.AllowUserToDeleteRows = false;
            this.receitaDataGridView.AllowUserToOrderColumns = true;
            this.receitaDataGridView.AutoGenerateColumns = false;
            this.receitaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receitaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Contato});
            this.receitaDataGridView.DataSource = this.receitaBindingSource;
            this.receitaDataGridView.Location = new System.Drawing.Point(35, 135);
            this.receitaDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receitaDataGridView.Name = "receitaDataGridView";
            this.receitaDataGridView.ReadOnly = true;
            this.receitaDataGridView.RowHeadersWidth = 51;
            this.receitaDataGridView.RowTemplate.Height = 24;
            this.receitaDataGridView.Size = new System.Drawing.Size(740, 266);
            this.receitaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ganhos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ganhos";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 147;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // receitaBindingSource
            // 
            this.receitaBindingSource.DataSource = typeof(Models.Receita);
            // 
            // buttonBuscarReceita
            // 
            this.buttonBuscarReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarReceita.Location = new System.Drawing.Point(451, 105);
            this.buttonBuscarReceita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarReceita.Name = "buttonBuscarReceita";
            this.buttonBuscarReceita.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarReceita.TabIndex = 8;
            this.buttonBuscarReceita.Text = "Buscar";
            this.buttonBuscarReceita.UseVisualStyleBackColor = true;
            this.buttonBuscarReceita.Click += new System.EventHandler(this.buttonBuscarReceita_Click);
            // 
            // buttonAlterarReceita
            // 
            this.buttonAlterarReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarReceita.Location = new System.Drawing.Point(619, 106);
            this.buttonAlterarReceita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarReceita.Name = "buttonAlterarReceita";
            this.buttonAlterarReceita.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarReceita.TabIndex = 9;
            this.buttonAlterarReceita.Text = "Alterar";
            this.buttonAlterarReceita.UseVisualStyleBackColor = true;
            this.buttonAlterarReceita.Click += new System.EventHandler(this.buttonAlterarReceita_Click);
            // 
            // buttonExcluirReceita
            // 
            this.buttonExcluirReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirReceita.Location = new System.Drawing.Point(700, 106);
            this.buttonExcluirReceita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirReceita.Name = "buttonExcluirReceita";
            this.buttonExcluirReceita.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirReceita.TabIndex = 10;
            this.buttonExcluirReceita.Text = "Excluir";
            this.buttonExcluirReceita.UseVisualStyleBackColor = true;
            this.buttonExcluirReceita.Click += new System.EventHandler(this.buttonExcluirReceita_Click);
            // 
            // buttonAdicionarReceita
            // 
            this.buttonAdicionarReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarReceita.Location = new System.Drawing.Point(531, 106);
            this.buttonAdicionarReceita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarReceita.Name = "buttonAdicionarReceita";
            this.buttonAdicionarReceita.Size = new System.Drawing.Size(83, 23);
            this.buttonAdicionarReceita.TabIndex = 11;
            this.buttonAdicionarReceita.Text = "Adicionar";
            this.buttonAdicionarReceita.UseVisualStyleBackColor = true;
            this.buttonAdicionarReceita.Click += new System.EventHandler(this.buttonAdicionarReceita_Click);
            // 
            // textBoxConsultarReceita
            // 
            this.textBoxConsultarReceita.Location = new System.Drawing.Point(109, 106);
            this.textBoxConsultarReceita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConsultarReceita.Name = "textBoxConsultarReceita";
            this.textBoxConsultarReceita.Size = new System.Drawing.Size(335, 22);
            this.textBoxConsultarReceita.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consulta:";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(824, 86);
            this.label2.TabIndex = 12;
            this.label2.Text = "Consulta de receita";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(700, 407);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 13;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // receitaBindingSource
            // 
            this.receitaBindingSource.DataSource = typeof(Models.Receita);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ganhos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ganhos";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 147;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Contato
            // 
            this.Contato.DataPropertyName = "Contato";
            this.Contato.HeaderText = "Contato";
            this.Contato.MinimumWidth = 6;
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            this.Contato.Width = 125;
            // 
            // FormConsultaReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 444);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuscarReceita);
            this.Controls.Add(this.buttonAlterarReceita);
            this.Controls.Add(this.buttonExcluirReceita);
            this.Controls.Add(this.buttonAdicionarReceita);
            this.Controls.Add(this.textBoxConsultarReceita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receitaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaReceita";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de receita";
            ((System.ComponentModel.ISupportInitialize)(this.receitaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource receitaBindingSource;
        private System.Windows.Forms.DataGridView receitaDataGridView;
        private System.Windows.Forms.Button buttonBuscarReceita;
        private System.Windows.Forms.Button buttonAlterarReceita;
        private System.Windows.Forms.Button buttonExcluirReceita;
        private System.Windows.Forms.Button buttonAdicionarReceita;
        private System.Windows.Forms.TextBox textBoxConsultarReceita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
    }
}