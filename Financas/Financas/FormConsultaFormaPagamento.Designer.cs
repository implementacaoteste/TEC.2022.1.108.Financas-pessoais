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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscarFormaPagamento = new System.Windows.Forms.Button();
            this.buttonAlterarFormaPagamento = new System.Windows.Forms.Button();
            this.buttonExcluirFormaPagamento = new System.Windows.Forms.Button();
            this.buttonAdicionarFormaPagamento = new System.Windows.Forms.Button();
            this.textBoxConsultarFormaPagamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.formaPagamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formaPagamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.formaPagamentoDataGridView.DataSource = this.formaPagamentoBindingSource;
            this.formaPagamentoDataGridView.Location = new System.Drawing.Point(32, 154);
            this.formaPagamentoDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formaPagamentoDataGridView.Name = "formaPagamentoDataGridView";
            this.formaPagamentoDataGridView.ReadOnly = true;
            this.formaPagamentoDataGridView.RowHeadersWidth = 51;
            this.formaPagamentoDataGridView.RowTemplate.Height = 24;
            this.formaPagamentoDataGridView.Size = new System.Drawing.Size(694, 282);
            this.formaPagamentoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // formaPagamentoBindingSource
            // 
            this.formaPagamentoBindingSource.DataSource = typeof(Models.FormaPagamento);
            // 
            // buttonBuscarFormaPagamento
            // 
            this.buttonBuscarFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));            this.buttonBuscarFormaPagamento.Location = new System.Drawing.Point(395, 126);
            this.buttonBuscarFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscarFormaPagamento.Name = "buttonBuscarFormaPagamento";
            this.buttonBuscarFormaPagamento.Size = new System.Drawing.Size(56, 19);
            this.buttonBuscarFormaPagamento.TabIndex = 8;
            this.buttonBuscarFormaPagamento.Text = "Buscar";
            this.buttonBuscarFormaPagamento.UseVisualStyleBackColor = true;
            this.buttonBuscarFormaPagamento.Click += new System.EventHandler(this.buttonBuscarFormaPagamento_Click);
            // 
            // buttonAlterarFormaPagamento
            // 
            this.buttonAlterarFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarFormaPagamento.Location = new System.Drawing.Point(570, 126);
            this.buttonAlterarFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAlterarFormaPagamento.Name = "buttonAlterarFormaPagamento";
            this.buttonAlterarFormaPagamento.Size = new System.Drawing.Size(56, 19);
            this.buttonAlterarFormaPagamento.TabIndex = 9;
            this.buttonAlterarFormaPagamento.Text = "Alterar";
            this.buttonAlterarFormaPagamento.UseVisualStyleBackColor = true;
            this.buttonAlterarFormaPagamento.Click += new System.EventHandler(this.buttonAlterarFormaPagamento_Click);
            // 
            // buttonExcluirFormaPagamento
            // 
            this.buttonExcluirFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirFormaPagamento.Location = new System.Drawing.Point(651, 126);
            this.buttonExcluirFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExcluirFormaPagamento.Name = "buttonExcluirFormaPagamento";
            this.buttonExcluirFormaPagamento.Size = new System.Drawing.Size(56, 19);
            this.buttonExcluirFormaPagamento.TabIndex = 10;
            this.buttonExcluirFormaPagamento.Text = "Excluir";
            this.buttonExcluirFormaPagamento.UseVisualStyleBackColor = true;
            this.buttonExcluirFormaPagamento.Click += new System.EventHandler(this.buttonExcluirFormaPagamento_Click);
            // 
            // buttonAdicionarFormaPagamento
            // 
            this.buttonAdicionarFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarFormaPagamento.Location = new System.Drawing.Point(476, 126);
            this.buttonAdicionarFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionarFormaPagamento.Name = "buttonAdicionarFormaPagamento";
            this.buttonAdicionarFormaPagamento.Size = new System.Drawing.Size(66, 19);
            this.buttonAdicionarFormaPagamento.TabIndex = 11;
            this.buttonAdicionarFormaPagamento.Text = "Adicionar";
            this.buttonAdicionarFormaPagamento.UseVisualStyleBackColor = true;
            this.buttonAdicionarFormaPagamento.Click += new System.EventHandler(this.buttonAdicionarFormaPagamento_Click);
            // 
            // textBoxConsultarFormaPagamento
            // 
            this.textBoxConsultarFormaPagamento.Location = new System.Drawing.Point(102, 127);
            this.textBoxConsultarFormaPagamento.Name = "textBoxConsultarFormaPagamento";
            this.textBoxConsultarFormaPagamento.Size = new System.Drawing.Size(287, 22);
            this.textBoxConsultarFormaPagamento.Location = new System.Drawing.Point(83, 93);
            this.textBoxConsultarFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxConsultarFormaPagamento.TabIndex = 7;
            this.textBoxConsultarFormaPagamento.TextChanged += new System.EventHandler(this.textBoxConsultarFormaPagamento_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(108, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Consulta Forma de Pagamento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConsultaFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuscarFormaPagamento);
            this.Controls.Add(this.buttonAlterarFormaPagamento);
            this.Controls.Add(this.buttonExcluirFormaPagamento);
            this.Controls.Add(this.buttonAdicionarFormaPagamento);
            this.Controls.Add(this.textBoxConsultarFormaPagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formaPagamentoDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaFormaPagamento";
            this.Text = "FormConsultaFormaPagamento";
            this.Load += new System.EventHandler(this.FormConsultaFormaPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource formaPagamentoBindingSource;
        private System.Windows.Forms.DataGridView formaPagamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonBuscarFormaPagamento;
        private System.Windows.Forms.Button buttonAlterarFormaPagamento;
        private System.Windows.Forms.Button buttonExcluirFormaPagamento;
        private System.Windows.Forms.Button buttonAdicionarFormaPagamento;
        private System.Windows.Forms.TextBox textBoxConsultarFormaPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}