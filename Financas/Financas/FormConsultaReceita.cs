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
    public partial class FormConsultaReceita : Form
    {
        private DateTime dataInicial;
        private DateTime dataFinal;
        private string filtro;
        public FormConsultaReceita()
        {
            InitializeComponent();
        }

        private void buttonAlterarReceita_Click(object sender, EventArgs e)
        {
            try
            {
                if (receitaBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro a ser alterado");
                    return;
                }
                int id = ((Receita)receitaBindingSource.Current).Id;
                using (FormCadastroReceita frm = new FormCadastroReceita(null, id))
                {
                    frm.ShowDialog();
                }
                filtro = textBoxConsultarReceita.Text + " ";
                buttonBuscarReceita_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscarReceita_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBox1.SelectedIndex != 2 && filtro == textBoxConsultarReceita.Text) || (comboBox1.SelectedIndex == 2 && dataInicial == Convert.ToDateTime(maskedTextBoxConsultarReceita.Text) && dataFinal == Convert.ToDateTime(textBoxConsultarReceita2.Text)))
                    return;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        SituacaoFinanceira situacaoFinanceira = new ReceitaBLL().BuscarSituacaoFinanceiraTodos();
                        receitaBindingSource.DataSource = situacaoFinanceira.Receitas;
                        textBoxReceitaTotal.Text = situacaoFinanceira.TotalReceita.ToString("C");
                        textBoxDespesaTotal.Text = situacaoFinanceira.TotalDespesa.ToString("C");
                        textBoxSaldoTotal.Text = situacaoFinanceira.Saldo.ToString("C");
                        //receitaBindingSource.DataSource = new ReceitaBLL().BuscarTodos();
                        break;
                    case 1:
                        receitaBindingSource.DataSource = new ReceitaBLL().BuscarPorDescricao(textBoxConsultarReceita.Text);
                        break;
                    case 2:
                        if (maskedTextBoxConsultarReceita.Text == "")
                            throw new Exception("Informa a data inicial") { Data = { { "Id", 5 } } };
                        if (textBoxConsultarReceita2.Text == "")
                            throw new Exception("Informa a data inicial") { Data = { { "Id", 6 } } };

                        receitaBindingSource.DataSource = new ReceitaBLL().BuscarPorEmissao(Convert.ToDateTime(maskedTextBoxConsultarReceita.Text), Convert.ToDateTime(textBoxConsultarReceita2.Text));
                        dataInicial = Convert.ToDateTime(maskedTextBoxConsultarReceita.Text);
                        dataFinal = Convert.ToDateTime(textBoxConsultarReceita2.Text);
                        break;
                    case 3:
                        receitaBindingSource.DataSource = new ReceitaBLL().BuscarPorContato(textBoxConsultarReceita.Text);
                        break;
                    case 4:
                        receitaBindingSource.DataSource = new ReceitaBLL().BuscarPorFormaPagamento(textBoxConsultarReceita.Text);
                        break;
                    case 5:
                        receitaBindingSource.DataSource = new ReceitaBLL().BuscarPorBanco(textBoxConsultarReceita.Text);
                        break;
                    default:
                        break;
                }
                if (comboBox1.SelectedIndex != 2)
                    filtro = textBoxConsultarReceita2.Text;
            }
            catch (Exception ex)
            {
                int idErro = new TratarErro().PegarId(ex);

                if (idErro == 5)
                {
                    textBoxConsultarReceita.Focus();
                }
                MessageBox.Show(ex.Message);
            }


        }
        private void buttonAdicionarReceita_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroReceita frm = new FormCadastroReceita())
                {
                    frm.ShowDialog();
                }
                filtro = textBoxConsultarReceita.Text + " ";
                buttonBuscarReceita_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirReceita_Click(object sender, EventArgs e)
        {
            try
            {

                if (receitaBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Receita)receitaBindingSource.Current).Id;
                new ReceitaBLL().Excluir(id);
                receitaBindingSource.RemoveCurrent();

                filtro = textBoxConsultarReceita.Text + " ";
                buttonBuscarReceita_Click(null, null);

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
            textBoxConsultarReceita.Width = 515;
            textBoxConsultarReceita.Visible = true;
            textBoxConsultarReceita2.Visible = false;
            maskedTextBoxConsultarReceita.Visible = false;

            if (comboBox1.SelectedIndex == 2)
            {
                labelDataInicial.Visible = true;
                labelDataFinal.Visible = true;
                textBoxConsultarReceita.Visible = false;
                maskedTextBoxConsultarReceita.Width = 255;
                maskedTextBoxConsultarReceita.Visible = true;
                textBoxConsultarReceita2.Visible = true;
            }
        }

        private void FormConsultaReceita_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void FormConsultaReceita_Load(object sender, EventArgs e)
        {
            try
            {

                comboBox1.SelectedIndex = 0;
                this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo2.png");
                this.labelDataInicial.ForeColor = System.Drawing.SystemColors.ControlText;
                this.labelDataInicial.BackColor = System.Drawing.SystemColors.Control;

                this.labelDataFinal.ForeColor = System.Drawing.SystemColors.ControlText;
                this.labelDataFinal.BackColor = System.Drawing.SystemColors.Control;

                this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
                this.label1.BackColor = System.Drawing.SystemColors.Control;

                this.label2.ForeColor = System.Drawing.SystemColors.Control;

                this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
                this.label3.BackColor = System.Drawing.SystemColors.Control;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
