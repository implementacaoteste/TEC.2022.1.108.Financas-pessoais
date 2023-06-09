﻿namespace Financas
{
    partial class FormCadastroDespesas
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
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label contatoLabel;
            System.Windows.Forms.Label bancoLabel;
            System.Windows.Forms.Label formaPagamentoLabel;
            System.Windows.Forms.Label dataEmissaoLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxGastos = new System.Windows.Forms.TextBox();
            this.despesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.contatoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscarContatoDespesas = new System.Windows.Forms.Button();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.formaPagamentoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscarFormaPagamentoDespesas = new System.Windows.Forms.Button();
            this.dataEmissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            valorLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            formaPagamentoLabel = new System.Windows.Forms.Label();
            dataEmissaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.SystemColors.Control;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(11, 22);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(53, 20);
            valorLabel.TabIndex = 0;
            valorLabel.Text = "Valor:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.BackColor = System.Drawing.SystemColors.Control;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(13, 210);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(91, 20);
            descricaoLabel.TabIndex = 11;
            descricaoLabel.Text = "Descrição:";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.BackColor = System.Drawing.SystemColors.Control;
            contatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatoLabel.Location = new System.Drawing.Point(335, 22);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(65, 20);
            contatoLabel.TabIndex = 2;
            contatoLabel.Text = "Credor:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.BackColor = System.Drawing.SystemColors.Control;
            bancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancoLabel.Location = new System.Drawing.Point(12, 113);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(62, 20);
            bancoLabel.TabIndex = 5;
            bancoLabel.Text = "Banco:";
            // 
            // formaPagamentoLabel
            // 
            formaPagamentoLabel.AutoSize = true;
            formaPagamentoLabel.BackColor = System.Drawing.SystemColors.Control;
            formaPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formaPagamentoLabel.Location = new System.Drawing.Point(335, 118);
            formaPagamentoLabel.Name = "formaPagamentoLabel";
            formaPagamentoLabel.Size = new System.Drawing.Size(172, 20);
            formaPagamentoLabel.TabIndex = 8;
            formaPagamentoLabel.Text = "Forma de pagamento:";
            // 
            // dataEmissaoLabel
            // 
            dataEmissaoLabel.AutoSize = true;
            dataEmissaoLabel.BackColor = System.Drawing.SystemColors.Control;
            dataEmissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataEmissaoLabel.Location = new System.Drawing.Point(337, 208);
            dataEmissaoLabel.Name = "dataEmissaoLabel";
            dataEmissaoLabel.Size = new System.Drawing.Size(141, 20);
            dataEmissaoLabel.TabIndex = 13;
            dataEmissaoLabel.Text = "Data de emissão:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de despesas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(516, 309);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(107, 36);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(427, 309);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(84, 36);
            this.buttonSalvar.TabIndex = 15;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxGastos
            // 
            this.textBoxGastos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Valor", true));
            this.textBoxGastos.Location = new System.Drawing.Point(12, 46);
            this.textBoxGastos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGastos.Name = "textBoxGastos";
            this.textBoxGastos.Size = new System.Drawing.Size(133, 22);
            this.textBoxGastos.TabIndex = 1;
            this.textBoxGastos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGastos_KeyDown);
            // 
            // despesasBindingSource
            // 
            this.despesasBindingSource.DataSource = typeof(Models.Despesas);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(12, 239);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(253, 22);
            this.textBoxDescricao.TabIndex = 12;
            this.textBoxDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDescricao_KeyDown);
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Contato", true));
            this.contatoTextBox.Location = new System.Drawing.Point(335, 46);
            this.contatoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.ReadOnly = true;
            this.contatoTextBox.Size = new System.Drawing.Size(197, 22);
            this.contatoTextBox.TabIndex = 3;
            this.contatoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contatoTextBox_KeyDown);
            // 
            // buttonBuscarContatoDespesas
            // 
            this.buttonBuscarContatoDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarContatoDespesas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBuscarContatoDespesas.Location = new System.Drawing.Point(539, 37);
            this.buttonBuscarContatoDespesas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarContatoDespesas.Name = "buttonBuscarContatoDespesas";
            this.buttonBuscarContatoDespesas.Size = new System.Drawing.Size(84, 36);
            this.buttonBuscarContatoDespesas.TabIndex = 4;
            this.buttonBuscarContatoDespesas.TabStop = false;
            this.buttonBuscarContatoDespesas.Text = "Buscar";
            this.buttonBuscarContatoDespesas.UseVisualStyleBackColor = true;
            this.buttonBuscarContatoDespesas.Click += new System.EventHandler(this.buttonBuscarContatoDespesas_Click);
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "Banco", true));
            this.bancoTextBox.Location = new System.Drawing.Point(12, 135);
            this.bancoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.ReadOnly = true;
            this.bancoTextBox.Size = new System.Drawing.Size(153, 22);
            this.bancoTextBox.TabIndex = 6;
            this.bancoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bancoTextBox_KeyDown);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(181, 127);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(84, 36);
            this.buttonBuscar.TabIndex = 7;
            this.buttonBuscar.TabStop = false;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // formaPagamentoTextBox
            // 
            this.formaPagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "FormaPagamento", true));
            this.formaPagamentoTextBox.Location = new System.Drawing.Point(335, 142);
            this.formaPagamentoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formaPagamentoTextBox.Name = "formaPagamentoTextBox";
            this.formaPagamentoTextBox.ReadOnly = true;
            this.formaPagamentoTextBox.Size = new System.Drawing.Size(197, 22);
            this.formaPagamentoTextBox.TabIndex = 9;
            this.formaPagamentoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formaPagamentoTextBox_KeyDown);
            // 
            // buttonBuscarFormaPagamentoDespesas
            // 
            this.buttonBuscarFormaPagamentoDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarFormaPagamentoDespesas.Location = new System.Drawing.Point(539, 130);
            this.buttonBuscarFormaPagamentoDespesas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarFormaPagamentoDespesas.Name = "buttonBuscarFormaPagamentoDespesas";
            this.buttonBuscarFormaPagamentoDespesas.Size = new System.Drawing.Size(84, 36);
            this.buttonBuscarFormaPagamentoDespesas.TabIndex = 10;
            this.buttonBuscarFormaPagamentoDespesas.TabStop = false;
            this.buttonBuscarFormaPagamentoDespesas.Text = "Buscar";
            this.buttonBuscarFormaPagamentoDespesas.UseVisualStyleBackColor = true;
            this.buttonBuscarFormaPagamentoDespesas.Click += new System.EventHandler(this.buttonBuscarFormaPagamentoDespesas_Click);
            // 
            // dataEmissaoDateTimePicker
            // 
            this.dataEmissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesasBindingSource, "DataEmissao", true));
            this.dataEmissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.despesasBindingSource, "DataEmissao", true));
            this.dataEmissaoDateTimePicker.Location = new System.Drawing.Point(335, 239);
            this.dataEmissaoDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataEmissaoDateTimePicker.Name = "dataEmissaoDateTimePicker";
            this.dataEmissaoDateTimePicker.Size = new System.Drawing.Size(197, 22);
            this.dataEmissaoDateTimePicker.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.contatoTextBox);
            this.panel1.Controls.Add(dataEmissaoLabel);
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.dataEmissaoDateTimePicker);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.buttonBuscarFormaPagamentoDespesas);
            this.panel1.Controls.Add(this.textBoxGastos);
            this.panel1.Controls.Add(formaPagamentoLabel);
            this.panel1.Controls.Add(valorLabel);
            this.panel1.Controls.Add(this.formaPagamentoTextBox);
            this.panel1.Controls.Add(this.textBoxDescricao);
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Controls.Add(descricaoLabel);
            this.panel1.Controls.Add(bancoLabel);
            this.panel1.Controls.Add(contatoLabel);
            this.panel1.Controls.Add(this.bancoTextBox);
            this.panel1.Controls.Add(this.buttonBuscarContatoDespesas);
            this.panel1.Location = new System.Drawing.Point(32, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 356);
            this.panel1.TabIndex = 18;
            // 
            // FormCadastroDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(740, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDespesas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de despesas";
            this.Load += new System.EventHandler(this.FormCadastroDespesas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroDespesas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.BindingSource despesasBindingSource;
        private System.Windows.Forms.TextBox textBoxGastos;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox contatoTextBox;
        private System.Windows.Forms.Button buttonBuscarContatoDespesas;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox formaPagamentoTextBox;
        private System.Windows.Forms.Button buttonBuscarFormaPagamentoDespesas;
        private System.Windows.Forms.DateTimePicker dataEmissaoDateTimePicker;
        private System.Windows.Forms.Panel panel1;
    }
}