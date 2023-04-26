﻿namespace Financas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contasReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorReceber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscarContasReceber = new System.Windows.Forms.Button();
            this.buttonAlterarContasReceber = new System.Windows.Forms.Button();
            this.buttonExcluirContasReceber = new System.Windows.Forms.Button();
            this.buttonAdicionarContasReceber = new System.Windows.Forms.Button();
            this.textBoxConsultarContasReceber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxConsultarContasReceber2 = new System.Windows.Forms.TextBox();
            this.labelDataInicial = new System.Windows.Forms.Label();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonQuitarContasReceber = new System.Windows.Forms.Button();
            this.buttonEstornar = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorReceberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idContatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.contasReceberDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contasReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contasReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.ValorReceber,
            this.Contato,
            this.FormaPagamento,
            this.Banco,
            this.DataEmissao,
            this.DataPagamento,
            this.idDataGridViewTextBoxColumn,
            this.valorReceberDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataEmissaoDataGridViewTextBoxColumn,
            this.dataPagamentoDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn,
            this.idContatoDataGridViewTextBoxColumn,
            this.bancoDataGridViewTextBoxColumn,
            this.idBancoDataGridViewTextBoxColumn,
            this.formaPagamentoDataGridViewTextBoxColumn,
            this.idFormaPagamentoDataGridViewTextBoxColumn});
            this.contasReceberDataGridView.DataSource = this.contasReceberBindingSource;
            this.contasReceberDataGridView.Location = new System.Drawing.Point(35, 135);
            this.contasReceberDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contasReceberDataGridView.Name = "contasReceberDataGridView";
            this.contasReceberDataGridView.ReadOnly = true;
            this.contasReceberDataGridView.RowHeadersWidth = 51;
            this.contasReceberDataGridView.RowTemplate.Height = 24;
            this.contasReceberDataGridView.Size = new System.Drawing.Size(1040, 515);
            this.contasReceberDataGridView.TabIndex = 1;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 125;
            // 
            // ValorReceber
            // 
            this.ValorReceber.DataPropertyName = "ValorReceber";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.ValorReceber.DefaultCellStyle = dataGridViewCellStyle1;
            this.ValorReceber.HeaderText = "Valor";
            this.ValorReceber.MinimumWidth = 6;
            this.ValorReceber.Name = "ValorReceber";
            this.ValorReceber.ReadOnly = true;
            this.ValorReceber.Width = 80;
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
            this.FormaPagamento.HeaderText = "FormaPagamento";
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
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DataEmissao.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataEmissao.HeaderText = "Data de emissao";
            this.DataEmissao.MinimumWidth = 8;
            this.DataEmissao.Name = "DataEmissao";
            this.DataEmissao.ReadOnly = true;
            this.DataEmissao.Width = 140;
            // 
            // DataPagamento
            // 
            this.DataPagamento.DataPropertyName = "DataPagamento";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DataPagamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataPagamento.HeaderText = "Data de pagamento";
            this.DataPagamento.MinimumWidth = 6;
            this.DataPagamento.Name = "DataPagamento";
            this.DataPagamento.ReadOnly = true;
            this.DataPagamento.Width = 125;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(Models.ContasReceber);
            // 
            // buttonBuscarContasReceber
            // 
            this.buttonBuscarContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContasReceber.Location = new System.Drawing.Point(737, 110);
            this.buttonBuscarContasReceber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarContasReceber.Name = "buttonBuscarContasReceber";
            this.buttonBuscarContasReceber.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarContasReceber.TabIndex = 8;
            this.buttonBuscarContasReceber.Text = "&Buscar";
            this.buttonBuscarContasReceber.UseVisualStyleBackColor = true;
            this.buttonBuscarContasReceber.Click += new System.EventHandler(this.buttonBuscarContasReceber_Click);
            // 
            // buttonAlterarContasReceber
            // 
            this.buttonAlterarContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarContasReceber.Location = new System.Drawing.Point(919, 110);
            this.buttonAlterarContasReceber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarContasReceber.Name = "buttonAlterarContasReceber";
            this.buttonAlterarContasReceber.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarContasReceber.TabIndex = 9;
            this.buttonAlterarContasReceber.Text = "A&lterar";
            this.buttonAlterarContasReceber.UseVisualStyleBackColor = true;
            this.buttonAlterarContasReceber.Click += new System.EventHandler(this.buttonAlterarContasReceber_Click);
            // 
            // buttonExcluirContasReceber
            // 
            this.buttonExcluirContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirContasReceber.Location = new System.Drawing.Point(1000, 109);
            this.buttonExcluirContasReceber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirContasReceber.Name = "buttonExcluirContasReceber";
            this.buttonExcluirContasReceber.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirContasReceber.TabIndex = 10;
            this.buttonExcluirContasReceber.Text = "&Excluir";
            this.buttonExcluirContasReceber.UseVisualStyleBackColor = true;
            this.buttonExcluirContasReceber.Click += new System.EventHandler(this.buttonExcluirContasReceber_Click);
            // 
            // buttonAdicionarContasReceber
            // 
            this.buttonAdicionarContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarContasReceber.Location = new System.Drawing.Point(818, 110);
            this.buttonAdicionarContasReceber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarContasReceber.Name = "buttonAdicionarContasReceber";
            this.buttonAdicionarContasReceber.Size = new System.Drawing.Size(95, 23);
            this.buttonAdicionarContasReceber.TabIndex = 11;
            this.buttonAdicionarContasReceber.Text = "&Adicionar";
            this.buttonAdicionarContasReceber.UseVisualStyleBackColor = true;
            this.buttonAdicionarContasReceber.Click += new System.EventHandler(this.buttonAdicionarContasReceber_Click);
            // 
            // textBoxConsultarContasReceber
            // 
            this.textBoxConsultarContasReceber.Location = new System.Drawing.Point(105, 108);
            this.textBoxConsultarContasReceber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConsultarContasReceber.Name = "textBoxConsultarContasReceber";
            this.textBoxConsultarContasReceber.Size = new System.Drawing.Size(269, 22);
            this.textBoxConsultarContasReceber.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consulta";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1111, 82);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consulta de contas a receber";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(1000, 654);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 10;
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
            "Pagamento",
            "Devedor",
            "Forma pagamento",
            "Banco"});
            this.comboBox1.Location = new System.Drawing.Point(610, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxConsultarContasReceber2
            // 
            this.textBoxConsultarContasReceber2.Location = new System.Drawing.Point(380, 108);
            this.textBoxConsultarContasReceber2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConsultarContasReceber2.Name = "textBoxConsultarContasReceber2";
            this.textBoxConsultarContasReceber2.Size = new System.Drawing.Size(223, 22);
            this.textBoxConsultarContasReceber2.TabIndex = 18;
            this.textBoxConsultarContasReceber2.Visible = false;
            // 
            // labelDataInicial
            // 
            this.labelDataInicial.AutoSize = true;
            this.labelDataInicial.BackColor = System.Drawing.SystemColors.Control;
            this.labelDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInicial.Location = new System.Drawing.Point(103, 91);
            this.labelDataInicial.Name = "labelDataInicial";
            this.labelDataInicial.Size = new System.Drawing.Size(73, 16);
            this.labelDataInicial.TabIndex = 19;
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
            this.labelDataFinal.Size = new System.Drawing.Size(68, 16);
            this.labelDataFinal.TabIndex = 19;
            this.labelDataFinal.Text = "Data Final";
            this.labelDataFinal.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Buscar por";
            this.label3.Visible = false;
            // 
            // buttonQuitarContasReceber
            // 
            this.buttonQuitarContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitarContasReceber.Location = new System.Drawing.Point(907, 655);
            this.buttonQuitarContasReceber.Name = "buttonQuitarContasReceber";
            this.buttonQuitarContasReceber.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitarContasReceber.TabIndex = 20;
            this.buttonQuitarContasReceber.Text = "Quitar";
            this.buttonQuitarContasReceber.UseVisualStyleBackColor = true;
            this.buttonQuitarContasReceber.Click += new System.EventHandler(this.buttonQuitarContasReceber_Click);
            // 
            // buttonEstornar
            // 
            this.buttonEstornar.Location = new System.Drawing.Point(35, 655);
            this.buttonEstornar.Name = "buttonEstornar";
            this.buttonEstornar.Size = new System.Drawing.Size(75, 23);
            this.buttonEstornar.TabIndex = 21;
            this.buttonEstornar.Text = "Estornar";
            this.buttonEstornar.UseVisualStyleBackColor = true;
            this.buttonEstornar.Click += new System.EventHandler(this.buttonEstornarContasReceber_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorReceberDataGridViewTextBoxColumn
            // 
            this.valorReceberDataGridViewTextBoxColumn.DataPropertyName = "ValorReceber";
            this.valorReceberDataGridViewTextBoxColumn.HeaderText = "ValorReceber";
            this.valorReceberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorReceberDataGridViewTextBoxColumn.Name = "valorReceberDataGridViewTextBoxColumn";
            this.valorReceberDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorReceberDataGridViewTextBoxColumn.Width = 125;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataEmissaoDataGridViewTextBoxColumn
            // 
            this.dataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.HeaderText = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataEmissaoDataGridViewTextBoxColumn.Name = "dataEmissaoDataGridViewTextBoxColumn";
            this.dataEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataEmissaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataPagamentoDataGridViewTextBoxColumn
            // 
            this.dataPagamentoDataGridViewTextBoxColumn.DataPropertyName = "DataPagamento";
            this.dataPagamentoDataGridViewTextBoxColumn.HeaderText = "DataPagamento";
            this.dataPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataPagamentoDataGridViewTextBoxColumn.Name = "dataPagamentoDataGridViewTextBoxColumn";
            this.dataPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataPagamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // contatoDataGridViewTextBoxColumn
            // 
            this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
            this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
            this.contatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contatoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idContatoDataGridViewTextBoxColumn
            // 
            this.idContatoDataGridViewTextBoxColumn.DataPropertyName = "IdContato";
            this.idContatoDataGridViewTextBoxColumn.HeaderText = "IdContato";
            this.idContatoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idContatoDataGridViewTextBoxColumn.Name = "idContatoDataGridViewTextBoxColumn";
            this.idContatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idContatoDataGridViewTextBoxColumn.Width = 125;
            // 
            // bancoDataGridViewTextBoxColumn
            // 
            this.bancoDataGridViewTextBoxColumn.DataPropertyName = "Banco";
            this.bancoDataGridViewTextBoxColumn.HeaderText = "Banco";
            this.bancoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bancoDataGridViewTextBoxColumn.Name = "bancoDataGridViewTextBoxColumn";
            this.bancoDataGridViewTextBoxColumn.ReadOnly = true;
            this.bancoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idBancoDataGridViewTextBoxColumn
            // 
            this.idBancoDataGridViewTextBoxColumn.DataPropertyName = "IdBanco";
            this.idBancoDataGridViewTextBoxColumn.HeaderText = "IdBanco";
            this.idBancoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idBancoDataGridViewTextBoxColumn.Name = "idBancoDataGridViewTextBoxColumn";
            this.idBancoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBancoDataGridViewTextBoxColumn.Width = 125;
            // 
            // formaPagamentoDataGridViewTextBoxColumn
            // 
            this.formaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "FormaPagamento";
            this.formaPagamentoDataGridViewTextBoxColumn.HeaderText = "FormaPagamento";
            this.formaPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.formaPagamentoDataGridViewTextBoxColumn.Name = "formaPagamentoDataGridViewTextBoxColumn";
            this.formaPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formaPagamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idFormaPagamentoDataGridViewTextBoxColumn
            // 
            this.idFormaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "IdFormaPagamento";
            this.idFormaPagamentoDataGridViewTextBoxColumn.HeaderText = "IdFormaPagamento";
            this.idFormaPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idFormaPagamentoDataGridViewTextBoxColumn.Name = "idFormaPagamentoDataGridViewTextBoxColumn";
            this.idFormaPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFormaPagamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormConsultaContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1111, 688);
            this.Controls.Add(this.buttonEstornar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonQuitarContasReceber);
            this.Controls.Add(this.labelDataFinal);
            this.Controls.Add(this.labelDataInicial);
            this.Controls.Add(this.textBoxConsultarContasReceber2);
            this.Controls.Add(this.comboBox1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaContasReceber";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de contas a receber";
            this.Load += new System.EventHandler(this.FormConsultaContasReceber_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaContasReceber_KeyDown);
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
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxConsultarContasReceber2;
        private System.Windows.Forms.Label labelDataInicial;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label3;
        
        private System.Windows.Forms.Button buttonQuitarContasReceber;
        private System.Windows.Forms.Button buttonEstornar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorReceberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormaPagamentoDataGridViewTextBoxColumn;
    }
}