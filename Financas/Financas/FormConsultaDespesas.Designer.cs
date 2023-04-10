namespace Financas
{
    partial class FormConsultaDespesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaDespesas));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxBuscarDespesas = new System.Windows.Forms.TextBox();
            this.despesasDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.labelInforamaConsultaDespesa = new System.Windows.Forms.Label();
            this.despesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSair = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.despesasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(824, 82);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consulta de despesas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBuscar.Location = new System.Drawing.Point(437, 110);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(700, 110);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 5;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxBuscarDespesas
            // 
            this.textBoxBuscarDespesas.Location = new System.Drawing.Point(106, 109);
            this.textBoxBuscarDespesas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscarDespesas.Multiline = true;
            this.textBoxBuscarDespesas.Name = "textBoxBuscarDespesas";
            this.textBoxBuscarDespesas.Size = new System.Drawing.Size(327, 22);
            this.textBoxBuscarDespesas.TabIndex = 8;
            // 
            // despesasDataGridView
            // 
            this.despesasDataGridView.AllowUserToAddRows = false;
            this.despesasDataGridView.AllowUserToDeleteRows = false;
            this.despesasDataGridView.AllowUserToOrderColumns = true;
            this.despesasDataGridView.AutoGenerateColumns = false;
            this.despesasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.despesasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.Valor,
            this.Contato,
            this.FormaPagamento,
            this.Banco});
            this.despesasDataGridView.DataSource = this.despesasBindingSource;
            this.despesasDataGridView.Location = new System.Drawing.Point(35, 135);
            this.despesasDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.despesasDataGridView.Name = "despesasDataGridView";
            this.despesasDataGridView.ReadOnly = true;
            this.despesasDataGridView.RowHeadersWidth = 51;
            this.despesasDataGridView.Size = new System.Drawing.Size(740, 266);
            this.despesasDataGridView.TabIndex = 9;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(518, 110);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(95, 23);
            this.buttonAdicionar.TabIndex = 8;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(619, 110);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 10;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // labelInforamaConsultaDespesa
            // 
            this.labelInforamaConsultaDespesa.AutoSize = true;
            this.labelInforamaConsultaDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInforamaConsultaDespesa.Location = new System.Drawing.Point(32, 112);
            this.labelInforamaConsultaDespesa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInforamaConsultaDespesa.Name = "labelInforamaConsultaDespesa";
            this.labelInforamaConsultaDespesa.Size = new System.Drawing.Size(67, 16);
            this.labelInforamaConsultaDespesa.TabIndex = 11;
            this.labelInforamaConsultaDespesa.Text = "Consulta";
            // 
            // despesasBindingSource
            // 
            this.despesasBindingSource.DataSource = typeof(Models.Despesas);
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(700, 407);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn7.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 87;
            // 
            // Contato
            // 
            this.Contato.DataPropertyName = "Contato";
            this.Contato.HeaderText = "Contato";
            this.Contato.MinimumWidth = 6;
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
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
            this.Banco.Width = 125;
            // 
            // FormConsultaDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 444);
            this.Controls.Add(this.labelInforamaConsultaDespesa);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.despesasDataGridView);
            this.Controls.Add(this.textBoxBuscarDespesas);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaDespesas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Despesas";
            ((System.ComponentModel.ISupportInitialize)(this.despesasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBoxBuscarDespesas;
        private System.Windows.Forms.DataGridView despesasDataGridView;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelInforamaConsultaDespesa;
        private System.Windows.Forms.BindingSource despesasBindingSource;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
    }
}