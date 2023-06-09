﻿using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using Models;
using WindowsFormsAppPrincipal;

namespace Financas
{
    public partial class FormCadastroBanco : Form
    {
        public int Id;
        public FormCadastroBanco(int id = 0)
        {
            InitializeComponent();
            Id = id;
        }

        private void buttonCancelarCadBanco_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvarCadBanco_Click(object sender, EventArgs e)
        {
            try
            {
                BancoBLL BancoBLL = new BancoBLL();
                bancoBindingSource.EndEdit();

                if (Id == 0)
                    BancoBLL.Inserir((Banco)bancoBindingSource.Current);
                else
                    BancoBLL.Alterar((Banco)bancoBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso");
                Close();
            }
            catch (Exception ex)
            {
                int idErro = new TratarErro().PegarId(ex);

                if (idErro == 0)
                    nomeTextBox.Focus();

                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroBanco_Load(object sender, EventArgs e)
        {

            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

            if (Id == 0)
            {
                bancoBindingSource.AddNew();
                ((Banco)bancoBindingSource.Current).Ativo =
                ativoCheckBox.Checked = true;
            }
            else
                bancoBindingSource.DataSource = new BancoBLL().BuscarPorId(Id, false, true);

            this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo.png");
            this.label1.ForeColor = SystemColors.Control;
        }

        private void FormCadastroBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void nomeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSalvarCadBanco_Click(null, null);
            }
        }

    }
}
