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
            //contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarTodos();
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarTodos();
                        break;
                    case 1:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorDescricao(textBoxConsultarContasReceber.Text);
                        break;
                    case 2:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorPeriodo(Convert.ToDateTime(textBoxConsultarContasReceber.Text), Convert.ToDateTime(textBoxConsultarContasReceber2.Text));
                        break;
                    case 3:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPagamento(Convert.ToDateTime(textBoxConsultarContasReceber.Text), Convert.ToDateTime(textBoxConsultarContasReceber2.Text));
                        break;
                    case 4:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorContato(textBoxConsultarContasReceber.Text);
                        break;
                    case 5:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorFormaPagamento(textBoxConsultarContasReceber.Text);
                        break;
                    case 6:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorBanco(textBoxConsultarContasReceber.Text);
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
            try
            {
                int id = ((ContasReceber)contasReceberBindingSource.Current).Id;
                if (((ContasReceber)contasReceberBindingSource.Current).DataPagamento != null && ((ContasReceber)contasReceberBindingSource.Current).DataPagamento.Value.Year > 2000)
                {
                    throw new Exception("Este registro já foi pago! não pode ser alterado");
                }
                using (FormCadastroContasReceber frm = new FormCadastroContasReceber(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarContasReceber_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            if (comboBox1.SelectedIndex == 2)
            {
                labelDataInicial.Visible = true;
                labelDataFinal.Visible = true;
                textBoxConsultarContasReceber.Width = 248;
                textBoxConsultarContasReceber2.Visible = true;
            }
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
            try
            {
                if (((ContasReceber)contasReceberBindingSource.Current).DataPagamento != null && ((ContasReceber)contasReceberBindingSource.Current).DataPagamento.Value.Year > 2000)
                {
                    throw new Exception("Este registro já foi pago!");
                }
                using (FormCadastroReceita frm = new FormCadastroReceita((ContasReceber)contasReceberBindingSource.Current))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaContasReceber_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void FormConsultaContasReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

        }
    }
}
