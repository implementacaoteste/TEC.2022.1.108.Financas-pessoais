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
        private DateTime dataInicial;
        private DateTime dataFinal;
        private string filtro;

        public FormConsultaContasPagar()
        {
            InitializeComponent();
        }

        private void buttonBuscarConsultaContasPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBox1.SelectedIndex != 2 && filtro == textBoxConsultaContasPagar.Text) || (comboBox1.SelectedIndex == 2 && dataInicial == Convert.ToDateTime(textBoxConsultaContasPagar.Text) && dataFinal == Convert.ToDateTime(textBoxConsultaContasPagar2.Text)))
                    return;

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarTodos();
                        break;
                    case 1:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorDescricao(textBoxConsultaContasPagar.Text);
                        break;
                    case 2:
                        if (textBoxConsultaContasPagar.Text == "")
                            throw new Exception("Informe a data inicial") { Data = { { "Id", 5 } } };
                        if (textBoxConsultaContasPagar2.Text == "")
                            throw new Exception("Informe a data final") { Data = { { "Id", 6 } } };

                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorPeriodo(Convert.ToDateTime(textBoxConsultaContasPagar.Text), Convert.ToDateTime(textBoxConsultaContasPagar2.Text));
                        dataInicial = Convert.ToDateTime(textBoxConsultaContasPagar.Text);
                        dataFinal = Convert.ToDateTime(textBoxConsultaContasPagar2.Text);
                        break;
                    case 3:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPagamento(Convert.ToDateTime(textBoxConsultaContasPagar.Text), Convert.ToDateTime(textBoxConsultaContasPagar2.Text));
                        break;
                    case 4:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorContato(textBoxConsultaContasPagar.Text);
                        break;
                    case 5:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorFormaPagamento(textBoxConsultaContasPagar.Text);
                        break;
                    case 6:
                        contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorBanco(textBoxConsultaContasPagar.Text);
                        break;
                    default:
                        break;
                }

                if (comboBox1.SelectedIndex != 2)
                    filtro = textBoxConsultaContasPagar2.Text;
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
            try
            {
                int id = ((ContasPagar)contasPagarBindingSource.Current).Id;
                if (((ContasPagar)contasPagarBindingSource.Current).DataPagamento != null && ((ContasReceber)contasPagarBindingSource.Current).DataPagamento.Value.Year > 2000)
                {
                    throw new Exception("Este registro já foi pago! não pode ser alterado");
                }
                using (FormCadastroContasPaga frm = new FormCadastroContasPaga(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarConsultaContasPagar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            if (comboBox1.SelectedIndex == 2)
            {
                labelDataInicial.Visible = true;
                labelDataFinal.Visible = true;
                textBoxConsultaContasPagar.Width = 190;
                textBoxConsultaContasPagar2.Visible = true;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                labelDataInicial.Visible = true;
                labelDataFinal.Visible = true;
                textBoxConsultaContasPagar.Width = 190;
                textBoxConsultaContasPagar2.Visible = true;
            }
        }

        private void buttonPagarContasPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (((ContasPagar)contasPagarBindingSource.Current).DataPagamento != null && ((ContasPagar)contasPagarBindingSource.Current).DataPagamento.Value.Year > 2000)
                {
                    throw new Exception("Este registro já foi pago!");
                }
                using (FormCadastroDespesas frm = new FormCadastroDespesas((ContasPagar)contasPagarBindingSource.Current))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            buttonBuscarConsultaContasPagar_Click(null, null);
        }

        private void FormConsultaContasPagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void buttonEstornarContasPagar_Click(object sender, EventArgs e)
        {
            try
            {
                new ContasPagarBLL().EstornarBaixa((ContasPagar)contasPagarBindingSource.Current);
                throw new Exception("Registro estornado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            buttonBuscarConsultaContasPagar_Click(null, null);
        }

        private void FormConsultaContasPagar_Load(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = 2;

            this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo2.png");
        }

        private void textBoxConsultaContasPagar_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxConsultaContasPagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxConsultaContasPagar2.Focus();
            }
        }

        private void textBoxConsultaContasPagar2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonBuscarConsultaContasPagar_Click(null, null);
            
            if (e.KeyCode == Keys.Up)
            {
                contasPagarBindingSource.MovePrevious();
                e.Handled = true;

            }
            else if (e.KeyCode == Keys.Down)
            {
                contasPagarBindingSource.MoveNext();
                e.Handled = true;
            }
        }

        private void textBoxConsultaContasPagar_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBoxConsultaContasPagar2.Focus();
            }
        }
    }
}







