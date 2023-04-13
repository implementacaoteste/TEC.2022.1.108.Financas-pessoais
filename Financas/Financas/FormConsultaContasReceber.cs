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
    public partial class FormConsultaContasReceber : Form
    {
        public FormConsultaContasReceber()
        {
            InitializeComponent();
        }

        private void buttonBuscarContasReceber_Click(object sender, EventArgs e)
        {
                contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarTodos();
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        contasReceberBindingSource.DataSource = new ContasPagarBLL().BuscarTodos();
                        break;
                    case 1:
                        contasReceberBindingSource.DataSource = new ContasPagarBLL().BuscarPorDescricao(textBoxConsultarContasReceber.Text);
                        break;
                    case 2:
                        contasReceberBindingSource.DataSource = new ContasPagarBLL().BuscarPorPeriodo(Convert.ToDateTime(textBoxConsultarContasReceber.Text), Convert.ToDateTime(textBoxConsultarContasReceber2.Text));
                        break;
                    case 3:
                        contasReceberBindingSource.DataSource = new ContasPagarBLL().BuscarPorContato(textBoxConsultarContasReceber.Text);
                        break;
                    case 4:
                        contasReceberBindingSource.DataSource = new ContasPagarBLL().BuscarPorFormaPagamento(textBoxConsultarContasReceber.Text);
                        break;
                    case 5:
                        contasReceberBindingSource.DataSource = new ContasPagarBLL().BuscarPorBanco(textBoxConsultarContasReceber.Text);
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

        private void buttonAdicionarContasReceber_Click(object sender, EventArgs e)
        {
            using (FormCadastroContasReceber frm = new FormCadastroContasReceber())
            {
                frm.ShowDialog();
            }
            buttonBuscarContasReceber_Click(null, null);
        }

        private void buttonAlterarContasReceber_Click(object sender, EventArgs e)
        {
            int id = ((ContasReceber)contasReceberBindingSource.Current).Id;
            using (FormCadastroContasReceber frm = new FormCadastroContasReceber(id))
            {
                frm.ShowDialog();
            }
            buttonBuscarContasReceber_Click(null, null);
        }

        private void buttonExcluirContasReceber_Click(object sender, EventArgs e)
        {
            if (contasReceberBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((ContasReceber)contasReceberBindingSource.Current).Id;
            new ContasReceberBLL().Excluir(id);
            contasReceberBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDataInicial.Visible = false;
            labelDataFinal.Visible = false;
            textBoxConsultarContasReceber.Width = 498;
            textBoxConsultarContasReceber2.Visible = false;

            if (comboBox1.SelectedIndex == 3)
            {
                labelDataInicial.Visible = true;
                labelDataFinal.Visible = true;
                textBoxConsultarContasReceber.Width = 248;
                textBoxConsultarContasReceber2.Visible = true;
            }
        }

        private void buttonQuitarContasReceber_Click(object sender, EventArgs e)
        {
            using(FormCadastroReceita frm = new FormCadastroReceita())
            {
                frm.ShowDialog();
            }
        }
    }
}
