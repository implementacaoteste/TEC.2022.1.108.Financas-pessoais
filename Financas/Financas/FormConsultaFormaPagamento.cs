﻿using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financas
{
    public partial class FormConsultaFormaPagamento : Form
    {
        public FormConsultaFormaPagamento()
        {
            InitializeComponent();
        }

        private void FormConsultaFormaPagamento_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscarFormaPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                formaPagamentoBindingSource.DataSource = new UsuarioBLL().BuscarPorNome(textBoxConsultarFormaPagamento.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterarFormaPagamento_Click(object sender, EventArgs e)
        {
            int id = ((FormaPagamento)formaPagamentoBindingSource.Current).Id;
            using (FormCadastroFormaPagamento frm = new FormCadastroFormaPagamento(id))
            {
                frm.ShowDialog();
            }
            buttonBuscarFormaPagamento_Click(null, null);
        }

        private void buttonExcluirFormaPagamento_Click(object sender, EventArgs e)
        {
            if (formaPagamentoBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((FormaPagamento)formaPagamentoBindingSource.Current).Id;
            new FormaPagamentoBLL().Excluir(id);
            formaPagamentoBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");

        }

        private void buttonAdicionarFormaPagamento_Click(object sender, EventArgs e)
        {
            using(FormCadastroFormaPagamento frm = new FormCadastroFormaPagamento())
            {
                frm.ShowDialog();
            }
            buttonBuscarFormaPagamento_Click(null, null);
        }

        private void textBoxConsultarFormaPagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

        }
    }
}
