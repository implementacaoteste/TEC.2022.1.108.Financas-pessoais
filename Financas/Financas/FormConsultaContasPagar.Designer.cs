﻿namespace Financas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contasPagarDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelConsultarContasPagar = new System.Windows.Forms.Label();
            this.textBoxConsultaContasPagar = new System.Windows.Forms.TextBox();
            this.buttonBuscarConsultaContasPagar = new System.Windows.Forms.Button();
            this.buttonAdicionarConsultaContasPagar = new System.Windows.Forms.Button();
            this.buttonAlterarConsultaContasPagar = new System.Windows.Forms.Button();
            this.buttonExcluirConsultaContasPagar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelDataInicial = new System.Windows.Forms.Label();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPagarContasPagar = new System.Windows.Forms.Button();
            this.buttonEstornar = new System.Windows.Forms.Button();
            this.maskedTextBoxConsultaContasPagar = new System.Windows.Forms.MaskedTextBox();
            this.textBoxConsultaContasPagar2 = new System.Windows.Forms.MaskedTextBox();
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
            this.contasPagarDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contasPagarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contasPagarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn3,
            this.ValorPagar,
            this.Contato,
            this.FormaPagamento,
            this.Banco,
            this.DataEmissao,
            this.DataPagamento});
            this.contasPagarDataGridView.DataSource = this.contasPagarBindingSource;
            this.contasPagarDataGridView.Location = new System.Drawing.Point(35, 137);
            this.contasPagarDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contasPagarDataGridView.Name = "contasPagarDataGridView";
            this.contasPagarDataGridView.ReadOnly = true;
            this.contasPagarDataGridView.RowHeadersWidth = 51;
            this.contasPagarDataGridView.RowTemplate.Height = 24;
            this.contasPagarDataGridView.Size = new System.Drawing.Size(1040, 515);
            this.contasPagarDataGridView.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // ValorPagar
            // 
            this.ValorPagar.DataPropertyName = "ValorPagar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ValorPagar.DefaultCellStyle = dataGridViewCellStyle2;
            this.ValorPagar.HeaderText = "Valor";
            this.ValorPagar.MinimumWidth = 6;
            this.ValorPagar.Name = "ValorPagar";
            this.ValorPagar.ReadOnly = true;
            this.ValorPagar.Width = 80;
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
            this.FormaPagamento.Width = 125;
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
            this.DataEmissao.Width = 125;
            // 
            // DataPagamento
            // 
            this.DataPagamento.DataPropertyName = "DataPagamento";
            this.DataPagamento.HeaderText = "Data de pagamento";
            this.DataPagamento.MinimumWidth = 6;
            this.DataPagamento.Name = "DataPagamento";
            this.DataPagamento.ReadOnly = true;
            this.DataPagamento.Width = 125;
            // 
            // contasPagarBindingSource
            // 
            this.contasPagarBindingSource.DataSource = typeof(Models.ContasPagar);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1111, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de contas a pagar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelConsultarContasPagar
            // 
            this.labelConsultarContasPagar.AutoSize = true;
            this.labelConsultarContasPagar.BackColor = System.Drawing.SystemColors.Control;
            this.labelConsultarContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultarContasPagar.Location = new System.Drawing.Point(41, 115);
            this.labelConsultarContasPagar.Name = "labelConsultarContasPagar";
            this.labelConsultarContasPagar.Size = new System.Drawing.Size(59, 16);
            this.labelConsultarContasPagar.TabIndex = 2;
            this.labelConsultarContasPagar.Text = "Consulta";
            // 
            // textBoxConsultaContasPagar
            // 
            this.textBoxConsultaContasPagar.Location = new System.Drawing.Point(103, 109);
            this.textBoxConsultaContasPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConsultaContasPagar.Name = "textBoxConsultaContasPagar";
            this.textBoxConsultaContasPagar.Size = new System.Drawing.Size(269, 22);
            this.textBoxConsultaContasPagar.TabIndex = 3;
            this.textBoxConsultaContasPagar.TextChanged += new System.EventHandler(this.textBoxConsultaContasPagar_TextChanged);
            this.textBoxConsultaContasPagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxConsultaContasPagar_KeyDown_1);
            // 
            // buttonBuscarConsultaContasPagar
            // 
            this.buttonBuscarConsultaContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarConsultaContasPagar.Location = new System.Drawing.Point(737, 110);
            this.buttonBuscarConsultaContasPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarConsultaContasPagar.Name = "buttonBuscarConsultaContasPagar";
            this.buttonBuscarConsultaContasPagar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarConsultaContasPagar.TabIndex = 8;
            this.buttonBuscarConsultaContasPagar.Text = "&Buscar";
            this.buttonBuscarConsultaContasPagar.UseVisualStyleBackColor = true;
            this.buttonBuscarConsultaContasPagar.Click += new System.EventHandler(this.buttonBuscarConsultaContasPagar_Click);
            // 
            // buttonAdicionarConsultaContasPagar
            // 
            this.buttonAdicionarConsultaContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarConsultaContasPagar.Location = new System.Drawing.Point(818, 110);
            this.buttonAdicionarConsultaContasPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarConsultaContasPagar.Name = "buttonAdicionarConsultaContasPagar";
            this.buttonAdicionarConsultaContasPagar.Size = new System.Drawing.Size(95, 23);
            this.buttonAdicionarConsultaContasPagar.TabIndex = 9;
            this.buttonAdicionarConsultaContasPagar.Text = "&Adicionar";
            this.buttonAdicionarConsultaContasPagar.UseVisualStyleBackColor = true;
            this.buttonAdicionarConsultaContasPagar.Click += new System.EventHandler(this.buttonAdicionarConsultaContasPagar_Click);
            // 
            // buttonAlterarConsultaContasPagar
            // 
            this.buttonAlterarConsultaContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarConsultaContasPagar.Location = new System.Drawing.Point(919, 110);
            this.buttonAlterarConsultaContasPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarConsultaContasPagar.Name = "buttonAlterarConsultaContasPagar";
            this.buttonAlterarConsultaContasPagar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarConsultaContasPagar.TabIndex = 10;
            this.buttonAlterarConsultaContasPagar.Text = "A&lterar";
            this.buttonAlterarConsultaContasPagar.UseVisualStyleBackColor = true;
            this.buttonAlterarConsultaContasPagar.Click += new System.EventHandler(this.buttonAlterarConsultaContasPagar_Click);
            // 
            // buttonExcluirConsultaContasPagar
            // 
            this.buttonExcluirConsultaContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirConsultaContasPagar.Location = new System.Drawing.Point(1000, 109);
            this.buttonExcluirConsultaContasPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirConsultaContasPagar.Name = "buttonExcluirConsultaContasPagar";
            this.buttonExcluirConsultaContasPagar.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirConsultaContasPagar.TabIndex = 11;
            this.buttonExcluirConsultaContasPagar.Text = "&Excluir";
            this.buttonExcluirConsultaContasPagar.UseVisualStyleBackColor = true;
            this.buttonExcluirConsultaContasPagar.Click += new System.EventHandler(this.buttonExcluirConsultaContasPagar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(1000, 654);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 24);
            this.buttonSair.TabIndex = 14;
            this.buttonSair.Text = "&Sair";
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
            "Pagamento",
            "Credor",
            "Forma pagamento",
            "Banco"});
            this.comboBox1.Location = new System.Drawing.Point(610, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelDataInicial
            // 
            this.labelDataInicial.AutoSize = true;
            this.labelDataInicial.BackColor = System.Drawing.SystemColors.Control;
            this.labelDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInicial.Location = new System.Drawing.Point(103, 91);
            this.labelDataInicial.Name = "labelDataInicial";
            this.labelDataInicial.Size = new System.Drawing.Size(73, 16);
            this.labelDataInicial.TabIndex = 1;
            this.labelDataInicial.Text = "Data inicial";
            this.labelDataInicial.Visible = false;
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.BackColor = System.Drawing.SystemColors.Control;
            this.labelDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataFinal.Location = new System.Drawing.Point(378, 91);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(63, 16);
            this.labelDataFinal.TabIndex = 4;
            this.labelDataFinal.Text = "Data final";
            this.labelDataFinal.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar por";
            this.label2.Visible = false;
            // 
            // buttonPagarContasPagar
            // 
            this.buttonPagarContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagarContasPagar.Location = new System.Drawing.Point(919, 654);
            this.buttonPagarContasPagar.Name = "buttonPagarContasPagar";
            this.buttonPagarContasPagar.Size = new System.Drawing.Size(75, 24);
            this.buttonPagarContasPagar.TabIndex = 13;
            this.buttonPagarContasPagar.Text = "&Pagar";
            this.buttonPagarContasPagar.UseVisualStyleBackColor = true;
            this.buttonPagarContasPagar.Click += new System.EventHandler(this.buttonPagarContasPagar_Click);
            // 
            // buttonEstornar
            // 
            this.buttonEstornar.Location = new System.Drawing.Point(35, 655);
            this.buttonEstornar.Name = "buttonEstornar";
            this.buttonEstornar.Size = new System.Drawing.Size(75, 24);
            this.buttonEstornar.TabIndex = 15;
            this.buttonEstornar.Text = "Estornar";
            this.buttonEstornar.UseVisualStyleBackColor = true;
            this.buttonEstornar.Click += new System.EventHandler(this.buttonEstornarContasPagar_Click);
            // 
            // maskedTextBoxConsultaContasPagar
            // 
            this.maskedTextBoxConsultaContasPagar.Location = new System.Drawing.Point(106, 109);
            this.maskedTextBoxConsultaContasPagar.Mask = "00/00/0000";
            this.maskedTextBoxConsultaContasPagar.Name = "maskedTextBoxConsultaContasPagar";
            this.maskedTextBoxConsultaContasPagar.Size = new System.Drawing.Size(269, 22);
            this.maskedTextBoxConsultaContasPagar.TabIndex = 16;
            this.maskedTextBoxConsultaContasPagar.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxConsultaContasPagar.Visible = false;
            this.maskedTextBoxConsultaContasPagar.MaskChanged += new System.EventHandler(this.textBoxConsultaContasPagar_TextChanged);
            this.maskedTextBoxConsultaContasPagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxConsultaContasPagar_KeyDown_1);
            // 
            // textBoxConsultaContasPagar2
            // 
            this.textBoxConsultaContasPagar2.Location = new System.Drawing.Point(378, 109);
            this.textBoxConsultaContasPagar2.Mask = "00/00/0000";
            this.textBoxConsultaContasPagar2.Name = "textBoxConsultaContasPagar2";
            this.textBoxConsultaContasPagar2.Size = new System.Drawing.Size(223, 22);
            this.textBoxConsultaContasPagar2.TabIndex = 16;
            this.textBoxConsultaContasPagar2.ValidatingType = typeof(System.DateTime);
            this.textBoxConsultaContasPagar2.Visible = false;
            this.textBoxConsultaContasPagar2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxConsultaContasPagar2_KeyDown);
            // 
            // FormConsultaContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1111, 693);
            this.Controls.Add(this.textBoxConsultaContasPagar2);
            this.Controls.Add(this.maskedTextBoxConsultaContasPagar);
            this.Controls.Add(this.buttonEstornar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPagarContasPagar);
            this.Controls.Add(this.labelDataFinal);
            this.Controls.Add(this.labelDataInicial);
            this.Controls.Add(this.comboBox1);
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
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaContasPagar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Contas a Pagar";
            this.Load += new System.EventHandler(this.FormConsultaContasPagar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaContasPagar_KeyDown);
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
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelDataInicial;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.Label label2;




        private System.Windows.Forms.Button buttonPagarContasPagar;
        private System.Windows.Forms.Button buttonEstornar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxConsultaContasPagar;
        private System.Windows.Forms.MaskedTextBox textBoxConsultaContasPagar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPagamento;
    }
}