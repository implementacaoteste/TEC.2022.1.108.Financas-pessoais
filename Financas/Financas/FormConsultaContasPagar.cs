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
    public partial class FormConsultaContasPagar : Form
    {
        public FormConsultaContasPagar()
        {
            InitializeComponent();
        }

        private void buttonBuscarConsultaContasPagar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarTodos();
                        break;
                    case 1:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorDescricao(textBoxConsultaContasPagar.Text);
                        break;
                    case 2:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorPeriodo(Convert.ToDateTime(textBoxConsultaContasPagar.Text), Convert.ToDateTime(textBoxConsultaContasPagar2.Text));
                        break;
                    case 3:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorContato(textBoxConsultaContasPagar.Text);
                        break;
                    case 4:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorFormaPagamento(textBoxConsultaContasPagar.Text);
                        break;
                    case 5:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorBanco(textBoxConsultaContasPagar.Text);
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

        private void buttonAdicionarConsultaContasPagar_Click(object sender, EventArgs e)
        {
            using (FormCadastroContasPaga frm = new FormCadastroContasPaga())
            {
                frm.ShowDialog();
            }
            buttonBuscarConsultaContasPagar_Click(null, null);
        }

        private void buttonAlterarConsultaContasPagar_Click(object sender, EventArgs e)
        {
            int id = ((ContasPagar)contasPagarBindingSource.Current).Id;
            using (FormCadastroContasPaga frm = new FormCadastroContasPaga(id))
            {
                frm.ShowDialog();
            }
            buttonBuscarConsultaContasPagar_Click(null, null);
        }

        private void buttonExcluirConsultaContasPagar_Click(object sender, EventArgs e)
        {
            if (contasPagarBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((ContasPagar)contasPagarBindingSource.Current).Id;
            new ContasPagarBLL().Excluir(id);
            contasPagarBindingSource.RemoveCurrent();

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
            textBoxConsultaContasPagar.Width = 498;
            textBoxConsultaContasPagar2.Visible = false;

            if (comboBox1.SelectedIndex == 3)
            {
                labelDataInicial.Visible = true;
                labelDataFinal.Visible = true;
                textBoxConsultaContasPagar.Width = 248;
                textBoxConsultaContasPagar2.Visible = true;
            }
        }

        private void buttonQuitarConsultaContasPagar_Click(object sender, EventArgs e)
        {
            using(FormCadastroDespesas frm = new FormCadastroDespesas())
            {
                frm.ShowDialog();
            }
        }
    }
}
