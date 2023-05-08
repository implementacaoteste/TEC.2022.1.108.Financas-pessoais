namespace Financas
{
    partial class FormConsultaFormaPagamento
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
            this.formaPagamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.formaPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscarFormaPagamento = new System.Windows.Forms.Button();
            this.buttonAlterarFormaPagamento = new System.Windows.Forms.Button();
            this.buttonExcluirFormaPagamento = new System.Windows.Forms.Button();
            this.buttonAdicionarFormaPagamento = new System.Windows.Forms.Button();
            this.textBoxConsultarFormaPagamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formaPagamentoDataGridView
            // 
            this.formaPagamentoDataGridView.AllowUserToAddRows = false;
            this.formaPagamentoDataGridView.AllowUserToDeleteRows = false;
            this.formaPagamentoDataGridView.AllowUserToOrderColumns = true;
            this.formaPagamentoDataGridView.AutoGenerateColumns = false;
            this.formaPagamentoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formaPagamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formaPagamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Ativo});
            this.formaPagamentoDataGridView.DataSource = this.formaPagamentoBindingSource;
            this.formaPagamentoDataGridView.Location = new System.Drawing.Point(35, 135);
            this.formaPagamentoDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formaPagamentoDataGridView.Name = "formaPagamentoDataGridView";
            this.formaPagamentoDataGridView.ReadOnly = true;
            this.formaPagamentoDataGridView.RowHeadersWidth = 51;
            this.formaPagamentoDataGridView.RowTemplate.Height = 24;
            this.formaPagamentoDataGridView.Size = new System.Drawing.Size(1040, 515);
            this.formaPagamentoDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.MinimumWidth = 6;
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Width = 125;
            // 
            // formaPagamentoBindingSource
            // 
            this.formaPagamentoBindingSource.DataSource = typeof(Models.FormaPagamento);
            // 
            // buttonBuscarFormaPagamento
            // 
            this.buttonBuscarFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarFormaPagamento.Location = new System.Drawing.Point(737, 110);
            this.buttonBuscarFormaPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarFormaPagamento.Name = "buttonBuscarFormaPagamento";
            this.buttonBuscarFormaPagamento.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarFormaPagamento.TabIndex = 5;
            this.buttonBuscarFormaPagamento.Text = "&Buscar";
            this.buttonBuscarFormaPagamento.UseVisualStyleBackColor = true;
            this.buttonBuscarFormaPagamento.Click += new System.EventHandler(this.buttonBuscarFormaPagamento_Click);
            // 
            // buttonAlterarFormaPagamento
            // 
            this.buttonAlterarFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarFormaPagamento.Location = new System.Drawing.Point(919, 108);
            this.buttonAlterarFormaPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarFormaPagamento.Name = "buttonAlterarFormaPagamento";
            this.buttonAlterarFormaPagamento.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarFormaPagamento.TabIndex = 7;
            this.buttonAlterarFormaPagamento.Text = "Al&terar";
            this.buttonAlterarFormaPagamento.UseVisualStyleBackColor = true;
            this.buttonAlterarFormaPagamento.Click += new System.EventHandler(this.buttonAlterarFormaPagamento_Click);
            // 
            // buttonExcluirFormaPagamento
            // 
            this.buttonExcluirFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirFormaPagamento.Location = new System.Drawing.Point(1000, 108);
            this.buttonExcluirFormaPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirFormaPagamento.Name = "buttonExcluirFormaPagamento";
            this.buttonExcluirFormaPagamento.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirFormaPagamento.TabIndex = 8;
            this.buttonExcluirFormaPagamento.Text = "&Excluir";
            this.buttonExcluirFormaPagamento.UseVisualStyleBackColor = true;
            this.buttonExcluirFormaPagamento.Click += new System.EventHandler(this.buttonExcluirFormaPagamento_Click);
            // 
            // buttonAdicionarFormaPagamento
            // 
            this.buttonAdicionarFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarFormaPagamento.Location = new System.Drawing.Point(818, 110);
            this.buttonAdicionarFormaPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarFormaPagamento.Name = "buttonAdicionarFormaPagamento";
            this.buttonAdicionarFormaPagamento.Size = new System.Drawing.Size(95, 23);
            this.buttonAdicionarFormaPagamento.TabIndex = 6;
            this.buttonAdicionarFormaPagamento.Text = "&Adicionar";
            this.buttonAdicionarFormaPagamento.UseVisualStyleBackColor = true;
            this.buttonAdicionarFormaPagamento.Click += new System.EventHandler(this.buttonAdicionarFormaPagamento_Click_1);
            // 
            // textBoxConsultarFormaPagamento
            // 
            this.textBoxConsultarFormaPagamento.Location = new System.Drawing.Point(106, 109);
            this.textBoxConsultarFormaPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConsultarFormaPagamento.Name = "textBoxConsultarFormaPagamento";
            this.textBoxConsultarFormaPagamento.Size = new System.Drawing.Size(486, 22);
            this.textBoxConsultarFormaPagamento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1111, 82);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consulta de forma de pagamento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(1000, 654);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 11;
            this.buttonSair.Text = "&Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click_1);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar.Location = new System.Drawing.Point(878, 655);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(116, 23);
            this.buttonSelecionar.TabIndex = 10;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Descrição",
            "Inativo"});
            this.comboBox1.Location = new System.Drawing.Point(608, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(605, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Buscar por";
            // 
            // FormConsultaFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1111, 693);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuscarFormaPagamento);
            this.Controls.Add(this.buttonAlterarFormaPagamento);
            this.Controls.Add(this.buttonExcluirFormaPagamento);
            this.Controls.Add(this.buttonAdicionarFormaPagamento);
            this.Controls.Add(this.textBoxConsultarFormaPagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formaPagamentoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaFormaPagamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Forma de Pagamento";
            this.Load += new System.EventHandler(this.FormConsultaFormaPagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaFormaPagamento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource formaPagamentoBindingSource;
        private System.Windows.Forms.DataGridView formaPagamentoDataGridView;
        private System.Windows.Forms.Button buttonBuscarFormaPagamento;
        private System.Windows.Forms.Button buttonAlterarFormaPagamento;
        private System.Windows.Forms.Button buttonExcluirFormaPagamento;
        private System.Windows.Forms.Button buttonAdicionarFormaPagamento;
        private System.Windows.Forms.TextBox textBoxConsultarFormaPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ativo;
    }
}