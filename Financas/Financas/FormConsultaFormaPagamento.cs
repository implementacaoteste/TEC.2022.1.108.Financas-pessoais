using BLL;
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
        public int Id;
        public string Descricao;
        public FormConsultaFormaPagamento(bool _selecionar = false)
        {
            InitializeComponent();
            button1.Visible = _selecionar;
        }

        private void buttonBuscarFormaPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        formaPagamentoBindingSource.DataSource = new FormaPagamentoBLL().BuscarTodos();
                        break;
                    case 1:
                        formaPagamentoBindingSource.DataSource = new FormaPagamentoBLL().BuscarPorDescricao(textBoxConsultarFormaPagamento.Text);
                        break;
                   
                    default:
                        break;
                }
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
            using (FormCadastroFormaPagamento frm = new FormCadastroFormaPagamento())
            {
                frm.ShowDialog();
            }
            buttonBuscarFormaPagamento_Click(null, null);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdicionarFormaPagamento_Click_1(object sender, EventArgs e)
        {
            using (FormCadastroFormaPagamento frm = new FormCadastroFormaPagamento())
            {
                frm.ShowDialog();
            }
            buttonBuscarFormaPagamento_Click(null, null);
        }

        private void buttonSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (formaPagamentoBindingSource.Count > 0)
                {
                    Id = ((FormaPagamento)formaPagamentoBindingSource.Current).Id;
                    Descricao = ((FormaPagamento)formaPagamentoBindingSource.Current).Descricao;
                    Close();
                }
                else
                    MessageBox.Show("Não existe um Devedor para ser selecionado.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
