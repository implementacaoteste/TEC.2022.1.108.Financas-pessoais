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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.receitaDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscarReceita = new System.Windows.Forms.Button();
            this.buttonAdicionarReceita = new System.Windows.Forms.Button();
            this.textBoxConsultarReceita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDataInicial = new System.Windows.Forms.Label();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.maskedTextBoxConsultarReceita = new System.Windows.Forms.MaskedTextBox();
            this.textBoxConsultarReceita2 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxReceitaTotal = new System.Windows.Forms.TextBox();
            this.textBoxDespesaTotal = new System.Windows.Forms.TextBox();
            this.textBoxSaldoTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.Id,
            this.Valor,
            this.Contato,
            this.FormaPagamento,
            this.Banco,
            this.DataEmissao,
            this.dataGridViewTextBoxColumn3});
            this.receitaDataGridView.DataSource = this.receitaBindingSource;
            this.receitaDataGridView.Location = new System.Drawing.Point(23, 137);
            this.receitaDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receitaDataGridView.Name = "receitaDataGridView";
            this.receitaDataGridView.ReadOnly = true;
            this.receitaDataGridView.RowHeadersWidth = 51;
            this.receitaDataGridView.RowTemplate.Height = 24;
            this.receitaDataGridView.Size = new System.Drawing.Size(1076, 445);
            this.receitaDataGridView.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Id.DefaultCellStyle = dataGridViewCellStyle10;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.DataEmissao.DefaultCellStyle = dataGridViewCellStyle12;
            this.DataEmissao.HeaderText = "Data de Emissao";
            this.DataEmissao.MinimumWidth = 6;
            this.DataEmissao.Name = "DataEmissao";
            this.DataEmissao.ReadOnly = true;
            this.DataEmissao.Width = 140;
            // 
            // receitaBindingSource
            // 
            this.receitaBindingSource.DataSource = typeof(Models.Receita);
            // 
            // buttonBuscarReceita
            // 
            this.buttonBuscarReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarReceita.Location = new System.Drawing.Point(923, 107);
            this.buttonBuscarReceita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarReceita.Name = "buttonBuscarReceita";
            this.buttonBuscarReceita.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarReceita.TabIndex = 8;
            this.buttonBuscarReceita.Text = "&Buscar";
            this.buttonBuscarReceita.UseVisualStyleBackColor = true;
            this.buttonBuscarReceita.Click += new System.EventHandler(this.buttonBuscarReceita_Click);
            // 
            // buttonAdicionarReceita
            // 
            this.buttonAdicionarReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarReceita.Location = new System.Drawing.Point(1004, 107);
            this.buttonAdicionarReceita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarReceita.Name = "buttonAdicionarReceita";
            this.buttonAdicionarReceita.Size = new System.Drawing.Size(95, 23);
            this.buttonAdicionarReceita.TabIndex = 9;
            this.buttonAdicionarReceita.Text = "&Adicionar";
            this.buttonAdicionarReceita.UseVisualStyleBackColor = true;
            this.buttonAdicionarReceita.Click += new System.EventHandler(this.buttonAdicionarReceita_Click);
            // 
            // textBoxConsultarReceita
            // 
            this.textBoxConsultarReceita.Location = new System.Drawing.Point(94, 108);
            this.textBoxConsultarReceita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConsultarReceita.Name = "textBoxConsultarReceita";
            this.textBoxConsultarReceita.Size = new System.Drawing.Size(349, 22);
            this.textBoxConsultarReceita.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1119, 82);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consulta de receita";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            "Emissão",
            "Contato",
            "Forma pagamento",
            "Banco",
            "Receita bruta "});
            this.comboBox1.Location = new System.Drawing.Point(787, 106);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(786, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar por";
            // 
            // labelDataInicial
            // 
            this.labelDataInicial.AutoSize = true;
            this.labelDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.labelDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInicial.Location = new System.Drawing.Point(91, 90);
            this.labelDataInicial.Name = "labelDataInicial";
            this.labelDataInicial.Size = new System.Drawing.Size(73, 16);
            this.labelDataInicial.TabIndex = 1;
            this.labelDataInicial.Text = "Data inicial";
            this.labelDataInicial.Visible = false;
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.BackColor = System.Drawing.Color.Transparent;
            this.labelDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataFinal.Location = new System.Drawing.Point(449, 90);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(63, 16);
            this.labelDataFinal.TabIndex = 4;
            this.labelDataFinal.Text = "Data final";
            this.labelDataFinal.Visible = false;
            // 
            // maskedTextBoxConsultarReceita
            // 
            this.maskedTextBoxConsultarReceita.Location = new System.Drawing.Point(94, 107);
            this.maskedTextBoxConsultarReceita.Mask = "00/00/0000";
            this.maskedTextBoxConsultarReceita.Name = "maskedTextBoxConsultarReceita";
            this.maskedTextBoxConsultarReceita.Size = new System.Drawing.Size(246, 22);
            this.maskedTextBoxConsultarReceita.TabIndex = 14;
            this.maskedTextBoxConsultarReceita.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxConsultarReceita.Visible = false;
            // 
            // textBoxConsultarReceita2
            // 
            this.textBoxConsultarReceita2.Location = new System.Drawing.Point(449, 107);
            this.textBoxConsultarReceita2.Mask = "00/00/0000";
            this.textBoxConsultarReceita2.Name = "textBoxConsultarReceita2";
            this.textBoxConsultarReceita2.Size = new System.Drawing.Size(330, 22);
            this.textBoxConsultarReceita2.TabIndex = 14;
            this.textBoxConsultarReceita2.ValidatingType = typeof(System.DateTime);
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
            // textBoxReceitaTotal
            // 
            this.textBoxReceitaTotal.Enabled = false;
            this.textBoxReceitaTotal.Location = new System.Drawing.Point(23, 617);
            this.textBoxReceitaTotal.Name = "textBoxReceitaTotal";
            this.textBoxReceitaTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxReceitaTotal.TabIndex = 15;
            // 
            // textBoxDespesaTotal
            // 
            this.textBoxDespesaTotal.Enabled = false;
            this.textBoxDespesaTotal.Location = new System.Drawing.Point(143, 617);
            this.textBoxDespesaTotal.Name = "textBoxDespesaTotal";
            this.textBoxDespesaTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxDespesaTotal.TabIndex = 15;
            // 
            // textBoxSaldoTotal
            // 
            this.textBoxSaldoTotal.Enabled = false;
            this.textBoxSaldoTotal.Location = new System.Drawing.Point(262, 617);
            this.textBoxSaldoTotal.Name = "textBoxSaldoTotal";
            this.textBoxSaldoTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxSaldoTotal.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(20, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Receita:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(140, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Despesa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(259, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Saldo:";
            // 
            // FormConsultaReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1119, 697);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSaldoTotal);
            this.Controls.Add(this.textBoxDespesaTotal);
            this.Controls.Add(this.textBoxReceitaTotal);
            this.Controls.Add(this.textBoxConsultarReceita2);
            this.Controls.Add(this.maskedTextBoxConsultarReceita);
            this.Controls.Add(this.labelDataFinal);
            this.Controls.Add(this.labelDataInicial);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuscarReceita);
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
            this.Load += new System.EventHandler(this.FormConsultaReceita_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaReceita_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.receitaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource receitaBindingSource;
        private System.Windows.Forms.DataGridView receitaDataGridView;
        private System.Windows.Forms.Button buttonBuscarReceita;
        private System.Windows.Forms.Button buttonAdicionarReceita;
        private System.Windows.Forms.TextBox textBoxConsultarReceita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDataInicial;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmissao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxConsultarReceita;
        private System.Windows.Forms.MaskedTextBox textBoxConsultarReceita2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox textBoxReceitaTotal;
        private System.Windows.Forms.TextBox textBoxDespesaTotal;
        private System.Windows.Forms.TextBox textBoxSaldoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}