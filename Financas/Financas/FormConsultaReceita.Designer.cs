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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.receitaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscarReceita = new System.Windows.Forms.Button();
            this.buttonAlterarReceita = new System.Windows.Forms.Button();
            this.buttonExcluirReceita = new System.Windows.Forms.Button();
            this.buttonAdicionarReceita = new System.Windows.Forms.Button();
            this.textBoxConsultarReceita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.receitaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receitaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receitaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.DataEmissao,
            this.Valor,
            this.Contato,
            this.FormaPagamento,
            this.Banco});
            this.receitaDataGridView.DataSource = this.receitaBindingSource;
            this.receitaDataGridView.Location = new System.Drawing.Point(35, 135);
            this.receitaDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receitaDataGridView.Name = "receitaDataGridView";
            this.receitaDataGridView.ReadOnly = true;
            this.receitaDataGridView.RowHeadersWidth = 51;
            this.receitaDataGridView.RowTemplate.Height = 24;
            this.receitaDataGridView.Size = new System.Drawing.Size(1040, 515);
            this.receitaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // DataEmissao
            // 
            this.DataEmissao.DataPropertyName = "DataEmissao";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DataEmissao.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataEmissao.HeaderText = "Data de Emissao";
            this.DataEmissao.MinimumWidth = 6;
            this.DataEmissao.Name = "DataEmissao";
            this.DataEmissao.ReadOnly = true;
            this.DataEmissao.Width = 140;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 80;
            // 
            // Contato
            // 
            this.Contato.DataPropertyName = "Contato";
            this.Contato.HeaderText = "Contato";
            this.Contato.MinimumWidth = 6;
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            this.Contato.Width = 115;
            // 
            // FormaPagamento
            // 
            this.FormaPagamento.DataPropertyName = "FormaPagamento";
            this.FormaPagamento.HeaderText = "Forma de Pagamento";
            this.FormaPagamento.MinimumWidth = 6;
            this.FormaPagamento.Name = "FormaPagamento";
            this.FormaPagamento.ReadOnly = true;
            this.FormaPagamento.Width = 167;
            // 
            // Banco
            // 
            this.Banco.DataPropertyName = "Banco";
            this.Banco.HeaderText = "Banco";
            this.Banco.MinimumWidth = 6;
            this.Banco.Name = "Banco";
            this.Banco.ReadOnly = true;
            this.Banco.Width = 85;
            // 
            // receitaBindingSource
            // 
            this.receitaBindingSource.DataSource = typeof(Models.Receita);
            // 
            // buttonBuscarReceita
            // 
            this.buttonBuscarReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarReceita.Location = new System.Drawing.Point(737, 110);
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
            this.buttonAlterarReceita.Location = new System.Drawing.Point(919, 110);
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
            this.buttonExcluirReceita.Location = new System.Drawing.Point(1000, 109);
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
            this.buttonAdicionarReceita.Location = new System.Drawing.Point(818, 110);
            this.buttonAdicionarReceita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarReceita.Name = "buttonAdicionarReceita";
            this.buttonAdicionarReceita.Size = new System.Drawing.Size(95, 23);
            this.buttonAdicionarReceita.TabIndex = 11;
            this.buttonAdicionarReceita.Text = "Adicionar";
            this.buttonAdicionarReceita.UseVisualStyleBackColor = true;
            this.buttonAdicionarReceita.Click += new System.EventHandler(this.buttonAdicionarReceita_Click);
            // 
            // textBoxConsultarReceita
            // 
            this.textBoxConsultarReceita.Location = new System.Drawing.Point(106, 109);
            this.textBoxConsultarReceita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConsultarReceita.Name = "textBoxConsultarReceita";
            this.textBoxConsultarReceita.Size = new System.Drawing.Size(498, 22);
            this.textBoxConsultarReceita.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consulta";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1111, 82);
            this.label2.TabIndex = 12;
            this.label2.Text = "Consulta de receita";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(1000, 654);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 13;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Descrição",
            "Periodo",
            "Contato",
            "Forma pagamento",
            "Banco"});
            this.comboBox1.Location = new System.Drawing.Point(610, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar por";
            // 
            // FormConsultaReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1111, 688);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuscarReceita);
            this.Controls.Add(this.buttonAlterarReceita);
            this.Controls.Add(this.buttonExcluirReceita);
            this.Controls.Add(this.buttonAdicionarReceita);
            this.Controls.Add(this.textBoxConsultarReceita);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}