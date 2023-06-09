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
using WindowsFormsAppPrincipal;

namespace Financas
{
    public partial class FormConsultaContasReceber : Form

    {
        private DateTime dataInicial;
        private DateTime dataFinal;
        private string filtro;
        public FormConsultaContasReceber()
        {
            InitializeComponent();
            textBoxConsultarContasReceber2.Text =
            maskedTextBoxConsultaContasReceber.Text = DateTime.Now.Date.ToString().Substring(0, 10);
        }

        private void buttonBuscarContasReceber_Click(object sender, EventArgs e)
        {
            try
            {
                if (Buscar())
                    return;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarTodos();
                        break;
                    case 1:
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorDescricao(textBoxConsultarContasReceber.Text);
                        break;
                    case 2:

                        if (maskedTextBoxConsultaContasReceber.Text == "")
                            throw new Exception("informe a data inicial") { Data = { { "Id", 5 } } };
                        if (textBoxConsultarContasReceber2.Text == "")
                            throw new Exception("informe a data final") { Data = { { "Id", 6 } } };
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorEmissao(Convert.ToDateTime(maskedTextBoxConsultaContasReceber.Text), Convert.ToDateTime(textBoxConsultarContasReceber2.Text));
                        dataInicial = Convert.ToDateTime(maskedTextBoxConsultaContasReceber.Text);
                        dataFinal = Convert.ToDateTime(textBoxConsultarContasReceber2.Text);

                        break;
                    case 3:
                        if (maskedTextBoxConsultaContasReceber.Text == "")
                            throw new Exception("informe a data inicial") { Data = { { "Id", 5 } } };
                        if (textBoxConsultarContasReceber2.Text == "")
                            throw new Exception("informe a data final") { Data = { { "Id", 6 } } };
                        contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPagamento(Convert.ToDateTime(maskedTextBoxConsultaContasReceber.Text), Convert.ToDateTime(textBoxConsultarContasReceber2.Text));
                        dataInicial = Convert.ToDateTime(maskedTextBoxConsultaContasReceber.Text);
                        dataFinal = Convert.ToDateTime(textBoxConsultarContasReceber2.Text);

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
                if (comboBox1.SelectedIndex != 2)
                    filtro = textBoxConsultarContasReceber2.Text;
            }
            catch (Exception ex)
            {
                int idErro = new TratarErro().PegarId(ex);

                if (idErro == 5)
                {
                    maskedTextBoxConsultaContasReceber.Focus();
                }
                MessageBox.Show(ex.Message);
            }
        }

        private bool Buscar()
        {
            try
            {
                if (comboBox1.SelectedIndex == 2 || comboBox1.SelectedIndex == 3)
                    return dataInicial == Convert.ToDateTime(maskedTextBoxConsultaContasReceber.Text) && dataFinal == Convert.ToDateTime(textBoxConsultarContasReceber2.Text);
                else
                    return filtro == textBoxConsultarContasReceber.Text;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void buttonAdicionarContasReceber_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroContasReceber frm = new FormCadastroContasReceber())
                {
                    frm.ShowDialog();
                }

                HabilitarBusca();
                buttonBuscarContasReceber_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HabilitarBusca()
        {
            filtro = textBoxConsultarContasReceber.Text + " ";
            dataInicial = Convert.ToDateTime(maskedTextBoxConsultaContasReceber.Text).AddDays(1);
            dataFinal = Convert.ToDateTime(textBoxConsultarContasReceber2.Text).AddDays(1);
        }

        private void buttonAlterarContasReceber_Click(object sender, EventArgs e)
        {
            try
            {
                if (contasReceberBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existro a ser alterado");
                    return;
                }
                int id = ((ContasReceber)contasReceberBindingSource.Current).Id;
                if (((ContasReceber)contasReceberBindingSource.Current).DataPagamento != null && ((ContasReceber)contasReceberBindingSource.Current).DataPagamento.Value.Year > 2000)
                {
                    throw new Exception("Este registro já foi pago! não pode ser alterado");
                }
                using (FormCadastroContasReceber frm = new FormCadastroContasReceber(id))
                {
                    frm.ShowDialog();
                }
                HabilitarBusca();
                buttonBuscarContasReceber_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirContasReceber_Click(object sender, EventArgs e)
        {
            try
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

                HabilitarBusca();
                buttonBuscarContasReceber_Click(null, null);

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDataInicial.Visible = false;
            labelDataFinal.Visible = false;
            textBoxConsultarContasReceber.Width = 375;
            textBoxConsultarContasReceber.Visible = true;
            textBoxConsultarContasReceber2.Visible = false;
            maskedTextBoxConsultaContasReceber.Visible = false;
            HabilitarBusca();


            if (comboBox1.SelectedIndex == 2)
            {
                labelDataInicial.Visible = true;
                labelDataFinal.Visible = true;
                textBoxConsultarContasReceber.Visible = false;
                maskedTextBoxConsultaContasReceber.Width = 200;
                maskedTextBoxConsultaContasReceber.Visible = true;
                textBoxConsultarContasReceber2.Visible = true;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                labelDataInicial.Visible = true;
                labelDataFinal.Visible = true;
                textBoxConsultarContasReceber.Visible = false;
                maskedTextBoxConsultaContasReceber.Width = 200;
                maskedTextBoxConsultaContasReceber.Visible = true;
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
            buttonBuscarContasReceber_Click(null, null);
        }
        private void buttonEstornarContasReceber_Click(object sender, EventArgs e)
        {
            try
            {
                new ContasReceberBLL().EstornarBaixa((ContasReceber)contasReceberBindingSource.Current);
                throw new Exception("Registro estornado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            buttonBuscarContasReceber_Click(null, null);
        }

        private void FormConsultaContasReceber_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedIndex = 0;
                this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo2.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaContasReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

        }

        private void textBoxConsultarContasReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxConsultarContasReceber2.Focus();
            }
        }

        private void textBoxConsultarContasReceber2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscarContasReceber_Click(null, null);
            }
        }
    }
}
