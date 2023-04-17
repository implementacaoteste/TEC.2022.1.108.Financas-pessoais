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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bancoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConsultarBanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdicionarBanco = new System.Windows.Forms.Button();
            this.buttonBuscarBanco = new System.Windows.Forms.Button();
            this.buttonExcluirBanco = new System.Windows.Forms.Button();
            this.buttonAlterarBanco = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonSelecionarBanco = new System.Windows.Forms.Button();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.bancoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bancoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bancoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bancoDataGridView.DataSource = this.bancoBindingSource;
            this.bancoDataGridView.Location = new System.Drawing.Point(35, 135);
            this.bancoDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bancoDataGridView.Name = "bancoDataGridView";
            this.bancoDataGridView.ReadOnly = true;
            this.bancoDataGridView.RowHeadersWidth = 51;
            this.bancoDataGridView.RowTemplate.Height = 24;
            this.bancoDataGridView.Size = new System.Drawing.Size(1040, 515);
            this.bancoDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Saldo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Saldo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 147;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Poupanca";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Poupanca";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 147;
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataSource = typeof(Models.Banco);
            this.bancoBindingSource.CurrentChanged += new System.EventHandler(this.bancoBindingSource_CurrentChanged);
            // 

            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta";
            // 
            // textBoxConsultarBanco
            // 
            this.textBoxConsultarBanco.Location = new System.Drawing.Point(106, 109);
            this.textBoxConsultarBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConsultarBanco.Name = "textBoxConsultarBanco";
            this.textBoxConsultarBanco.Size = new System.Drawing.Size(498, 22);
            this.textBoxConsultarBanco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1111, 82);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consultar banco";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdicionarBanco
            // 
            this.buttonAdicionarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarBanco.Location = new System.Drawing.Point(818, 110);
            this.buttonAdicionarBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarBanco.Name = "buttonAdicionarBanco";
            this.buttonAdicionarBanco.Size = new System.Drawing.Size(95, 23);
            this.buttonAdicionarBanco.TabIndex = 5;
            this.buttonAdicionarBanco.Text = "Adicionar";
            this.buttonAdicionarBanco.UseVisualStyleBackColor = true;
            this.buttonAdicionarBanco.Click += new System.EventHandler(this.buttonAdicionarBanco_Click);
            // 
            // buttonBuscarBanco
            // 
            this.buttonBuscarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarBanco.Location = new System.Drawing.Point(737, 110);
            this.buttonBuscarBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarBanco.Name = "buttonBuscarBanco";
            this.buttonBuscarBanco.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarBanco.TabIndex = 5;
            this.buttonBuscarBanco.Text = "Buscar";
            this.buttonBuscarBanco.UseVisualStyleBackColor = true;
            this.buttonBuscarBanco.Click += new System.EventHandler(this.buttonBuscarBanco_Click);
            // 
            // buttonExcluirBanco
            // 
            this.buttonExcluirBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirBanco.Location = new System.Drawing.Point(1000, 110);
            this.buttonExcluirBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirBanco.Name = "buttonExcluirBanco";
            this.buttonExcluirBanco.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirBanco.TabIndex = 5;
            this.buttonExcluirBanco.Text = "Excluir";
            this.buttonExcluirBanco.UseVisualStyleBackColor = true;
            this.buttonExcluirBanco.Click += new System.EventHandler(this.buttonExcluirBanco_Click);
            // 
            // buttonAlterarBanco
            // 
            this.buttonAlterarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarBanco.Location = new System.Drawing.Point(919, 110);
            this.buttonAlterarBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarBanco.Name = "buttonAlterarBanco";
            this.buttonAlterarBanco.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarBanco.TabIndex = 5;
            this.buttonAlterarBanco.Text = "Alterar";
            this.buttonAlterarBanco.UseVisualStyleBackColor = true;
            this.buttonAlterarBanco.Click += new System.EventHandler(this.buttonAlterarBanco_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(1000, 656);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonSelecionarBanco
            // 
            this.buttonSelecionarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarBanco.Location = new System.Drawing.Point(885, 656);
            this.buttonSelecionarBanco.Name = "buttonSelecionarBanco";
            this.buttonSelecionarBanco.Size = new System.Drawing.Size(109, 23);
            this.buttonSelecionarBanco.TabIndex = 6;
            this.buttonSelecionarBanco.Text = "Selecionar";
            this.buttonSelecionarBanco.UseVisualStyleBackColor = true;
            this.buttonSelecionarBanco.Click += new System.EventHandler(this.buttonSelecionarBanco_Click);
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "Todos",
            "Nome"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(610, 108);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBuscar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Buscar por";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Saldo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Saldo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 147;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Poupanca";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Poupanca";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 147;
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataSource = typeof(Models.Banco);
            this.bancoBindingSource.CurrentChanged += new System.EventHandler(this.bancoBindingSource_CurrentChanged);
            // 
            // FormConsultaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1111, 688);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.buttonSelecionarBanco);
            this.Controls.Add(this.buttonBuscarBanco);
            this.Controls.Add(this.buttonAlterarBanco);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonExcluirBanco);
            this.Controls.Add(this.buttonAdicionarBanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxConsultarBanco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bancoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(1000, 109);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaBanco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Banco";
            this.Load += new System.EventHandler(this.FormConsultaBanco_Load);
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
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonSelecionarBanco;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label3;
    }
}