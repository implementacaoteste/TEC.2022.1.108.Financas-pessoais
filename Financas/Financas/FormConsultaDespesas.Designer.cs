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
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.despesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.labelInforamaConsultaDespesa = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxBuscarDespesas2 = new System.Windows.Forms.TextBox();
            this.labelDataInicial = new System.Windows.Forms.Label();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.despesasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1111, 82);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consulta de despesas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBuscar.Location = new System.Drawing.Point(737, 110);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(1000, 109);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 5;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxBuscarDespesas
            // 
            this.textBoxBuscarDespesas.Location = new System.Drawing.Point(106, 109);
            this.textBoxBuscarDespesas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscarDespesas.Multiline = true;
            this.textBoxBuscarDespesas.Name = "textBoxBuscarDespesas";
            this.textBoxBuscarDespesas.Size = new System.Drawing.Size(269, 22);
            this.textBoxBuscarDespesas.TabIndex = 8;
            // 
            // despesasDataGridView
            // 
            this.despesasDataGridView.AllowUserToAddRows = false;
            this.despesasDataGridView.AllowUserToDeleteRows = false;
            this.despesasDataGridView.AllowUserToOrderColumns = true;
            this.despesasDataGridView.AutoGenerateColumns = false;
            this.despesasDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.despesasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.despesasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.Valor,
            this.Contato,
            this.FormaPagamento,
            this.Banco,
            this.DataEmissao});
            this.despesasDataGridView.DataSource = this.despesasBindingSource;
            this.despesasDataGridView.Location = new System.Drawing.Point(35, 135);
            this.despesasDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.despesasDataGridView.Name = "despesasDataGridView";
            this.despesasDataGridView.ReadOnly = true;
            this.despesasDataGridView.RowHeadersWidth = 51;
            this.despesasDataGridView.Size = new System.Drawing.Size(1040, 515);
            this.despesasDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn7.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 140;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle1;
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
            // DataEmissao
            // 
            this.DataEmissao.DataPropertyName = "DataEmissao";
            this.DataEmissao.HeaderText = "Data de emissao";
            this.DataEmissao.MinimumWidth = 6;
            this.DataEmissao.Name = "DataEmissao";
            this.DataEmissao.ReadOnly = true;
            this.DataEmissao.Width = 140;
            // 
            // despesasBindingSource
            // 
            this.despesasBindingSource.DataSource = typeof(Models.Despesas);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(818, 110);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(95, 23);
            this.buttonAdicionar.TabIndex = 8;
            this.buttonAdicionar.Text = "&Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(919, 110);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 10;
            this.buttonAlterar.Text = "Al&terar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // labelInforamaConsultaDespesa
            // 
            this.labelInforamaConsultaDespesa.AutoSize = true;
            this.labelInforamaConsultaDespesa.BackColor = System.Drawing.Color.Transparent;
            this.labelInforamaConsultaDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInforamaConsultaDespesa.Location = new System.Drawing.Point(32, 112);
            this.labelInforamaConsultaDespesa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInforamaConsultaDespesa.Name = "labelInforamaConsultaDespesa";
            this.labelInforamaConsultaDespesa.Size = new System.Drawing.Size(59, 16);
            this.labelInforamaConsultaDespesa.TabIndex = 11;
            this.labelInforamaConsultaDespesa.Text = "Consulta";
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(1000, 654);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 5;
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
            this.comboBox1.Location = new System.Drawing.Point(610, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxBuscarDespesas2
            // 
            this.textBoxBuscarDespesas2.Location = new System.Drawing.Point(381, 109);
            this.textBoxBuscarDespesas2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscarDespesas2.Name = "textBoxBuscarDespesas2";
            this.textBoxBuscarDespesas2.Size = new System.Drawing.Size(223, 22);
            this.textBoxBuscarDespesas2.TabIndex = 16;
            // 
            // labelDataInicial
            // 
            this.labelDataInicial.AutoSize = true;
            this.labelDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.labelDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInicial.Location = new System.Drawing.Point(103, 91);
            this.labelDataInicial.Name = "labelDataInicial";
            this.labelDataInicial.Size = new System.Drawing.Size(73, 16);
            this.labelDataInicial.TabIndex = 17;
            this.labelDataInicial.Text = "Data inicial";
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.BackColor = System.Drawing.Color.Transparent;
            this.labelDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataFinal.Location = new System.Drawing.Point(378, 91);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(63, 16);
            this.labelDataFinal.TabIndex = 17;
            this.labelDataFinal.Text = "Data final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Buscar por";
            // 
            // FormConsultaDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1111, 688);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDataFinal);
            this.Controls.Add(this.labelDataInicial);
            this.Controls.Add(this.textBoxBuscarDespesas2);
            this.Controls.Add(this.comboBox1);
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
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaDespesas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Despesas";
            this.Load += new System.EventHandler(this.FormConsultaDespesas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaDespesas_KeyDown);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxBuscarDespesas2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmissao;
        private System.Windows.Forms.Label labelDataInicial;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.Label label2;
    }
}