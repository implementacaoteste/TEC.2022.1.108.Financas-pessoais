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
using BLL;
using WindowsFormsAppPrincipal;

namespace Financas
{
    public partial class FormConsultaDespesas : Form
    {
        private DateTime dataInicial;
        private DateTime dataFinal;
        private string filtro;


        public FormConsultaDespesas()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBox1.SelectedIndex != 2 && filtro == textBoxBuscarDespesas.Text) || (comboBox1.SelectedIndex == 2 && dataInicial == Convert.ToDateTime(maskedTextBoxBuscarDespesas.Text) && dataFinal == Convert.ToDateTime(textBoxBuscarDespesas.Text)))
                    return;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        despesasBindingSource.DataSource = new DespesasBLL().BuscarTodos();
                        SituacaoFinanceira situacaoFinanceira = new DespesasBLL().BuscarSituacaoFinanceiraTodos();
                        despesasBindingSource.DataSource = situacaoFinanceira.Despesas;
                        textBoxDespesaTotal.Text = situacaoFinanceira.TotalDespesa.ToString("C");
                        textBoxReceitaTotal.Text = situacaoFinanceira.TotalReceita.ToString("C");
                        textBoxSaldoTotal.Text = situacaoFinanceira.Saldo.ToString("C");
                        break;
                    case 1:
                        despesasBindingSource.DataSource = new DespesasBLL().BuscarPorDescricao(textBoxBuscarDespesas.Text);
                        situacaoFinanceira = new DespesasBLL().BuscarSituacaoFinanceiraDescricao(textBoxBuscarDespesas.Text);
                        despesasBindingSource.DataSource = situacaoFinanceira.Despesas;
                        textBoxDespesaTotal.Text = situacaoFinanceira.TotalDespesa.ToString("C");
                        textBoxReceitaTotal.Text = situacaoFinanceira.TotalReceita.ToString("C");
                        textBoxSaldoTotal.Text = situacaoFinanceira.Saldo.ToString("C");
                        break;
                    case 2:
                        if (maskedTextBoxBuscarDespesas.Text == "")
                            throw new Exception("Informa a data inicial") { Data = { { "Id", 5 } } };
                        if (textBoxBuscarDespesas2.Text == "")
                            throw new Exception("Informa a data inicial") { Data = { { "Id", 6 } } };

                        despesasBindingSource.DataSource = new DespesasBLL().BuscarPorEmissao(Convert.ToDateTime(maskedTextBoxBuscarDespesas.Text), Convert.ToDateTime(textBoxBuscarDespesas2.Text));
                        dataInicial = Convert.ToDateTime(maskedTextBoxBuscarDespesas.Text);
                        dataFinal = Convert.ToDateTime(textBoxBuscarDespesas2.Text);
                        situacaoFinanceira = new DespesasBLL().BuscarSituacaoFinanceiraEmissao(Convert.ToDateTime(maskedTextBoxBuscarDespesas.Text), Convert.ToDateTime(textBoxBuscarDespesas2.Text));
                        textBoxDespesaTotal.Text = situacaoFinanceira.TotalDespesa.ToString("C");
                        textBoxReceitaTotal.Text = situacaoFinanceira.TotalReceita.ToString("C");
                        textBoxSaldoTotal.Text = situacaoFinanceira.Saldo.ToString("C");
                        break;
                    case 3:
                        despesasBindingSource.DataSource = new DespesasBLL().BuscarPorContato(textBoxBuscarDespesas.Text);
                        situacaoFinanceira = new DespesasBLL().BuscarSituacaoFinanceiraContato(textBoxBuscarDespesas.Text);
                        despesasBindingSource.DataSource = situacaoFinanceira.Despesas;
                        textBoxDespesaTotal.Text = situacaoFinanceira.TotalDespesa.ToString("C");
                        textBoxReceitaTotal.Text = situacaoFinanceira.TotalReceita.ToString("C");
                        textBoxSaldoTotal.Text = situacaoFinanceira.Saldo.ToString("C");
                        break;
                    case 4:
                        despesasBindingSource.DataSource = new DespesasBLL().BuscarPorFormaPagamento(textBoxBuscarDespesas.Text);
                        situacaoFinanceira = new DespesasBLL().BuscarSituacaoFinanceiraFormaPagamento(textBoxBuscarDespesas.Text);
                        textBoxDespesaTotal.Text = situacaoFinanceira.TotalDespesa.ToString("C");
                        textBoxReceitaTotal.Text = situacaoFinanceira.TotalReceita.ToString("C");
                        textBoxSaldoTotal.Text = situacaoFinanceira.Saldo.ToString("C");
                        break;
                    case 5:
                        despesasBindingSource.DataSource = new DespesasBLL().BuscarPorBanco(textBoxBuscarDespesas.Text);
                        situacaoFinanceira = new DespesasBLL().BuscarSituacaoFinanceiraBanco(textBoxBuscarDespesas.Text);
                        textBoxDespesaTotal.Text = situacaoFinanceira.TotalDespesa.ToString("C");
                        textBoxReceitaTotal.Text = situacaoFinanceira.TotalReceita.ToString("C");
                        textBoxSaldoTotal.Text = situacaoFinanceira.Saldo.ToString("C");
                        break;
                    default:
                        break;
                }
                if (comboBox1.SelectedIndex != 2)
                    filtro = textBoxBuscarDespesas2.Text;
            }
            catch (Exception ex)
            {
                int idErro = new TratarErro().PegarId(ex);

                if (idErro == 5)
                {
                    maskedTextBoxBuscarDespesas.Focus();
                }
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroDespesas frm = new FormCadastroDespesas())
                {
                    frm.ShowDialog();
                }
                filtro = textBoxBuscarDespesas.Text + " ";
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void buttonAlterar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int id = ((Despesas)despesasBindingSource.Current).Id;

        //        if (((Despesas)despesasBindingSource.Current).DataEmissao != null && ((Despesas)despesasBindingSource.Current).DataPagamento.Value.Year > 2000)
        //        {
        //            throw new Exception("Este registro já foi pago! não pode ser alterado");
        //        }
        //        using (FormCadastroContasPaga frm = new FormCadastroContasPaga(id))
        //        {
        //            frm.ShowDialog();
        //        }
        //        filtro = textBoxBuscarDespesas.Text + " ";
        //        buttonBuscar_Click(null, null);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void buttonExcluir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (despesasBindingSource.Count <= 0)
        //        {
        //            MessageBox.Show("Não existe registro para ser excluído");
        //            return;
        //        }
        //        if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
        //            return;

        //        int id = ((Despesas)despesasBindingSource.Current).Id;
        //        new DespesasBLL().Excluir(id);
        //        despesasBindingSource.RemoveCurrent();

        //        filtro = textBoxBuscarDespesas.Text + " ";
        //        buttonBuscar_Click(null, null);

        //        MessageBox.Show("Registro excluído com sucesso!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDataInicial.Visible = false;
            labelDataFinal.Visible = false;
            textBoxBuscarDespesas.Width = 495;
            textBoxBuscarDespesas.Visible = true;
            textBoxBuscarDespesas2.Visible = false;
            maskedTextBoxBuscarDespesas.Visible = false;

            if (comboBox1.SelectedIndex == 2)
            {
                labelDataInicial.Visible = true;
                labelDataFinal.Visible = true;
                textBoxBuscarDespesas.Visible = false;
                maskedTextBoxBuscarDespesas.Width = 255;
                maskedTextBoxBuscarDespesas.Visible = true;
                textBoxBuscarDespesas2.Visible = true;
            }
        }

        private void FormConsultaDespesas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void FormConsultaDespesas_Load(object sender, EventArgs e)
        {
            try
            {
                labelDataInicial.Visible = false;
                labelDataFinal.Visible = false;
                textBoxBuscarDespesas.Width = 375;
                textBoxBuscarDespesas2.Visible = false;
                comboBox1.SelectedIndex = 0;

                this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo2.png");
                this.labelInforamaConsultaDespesa.BackColor = System.Drawing.SystemColors.Control;
                this.labelInforamaConsultaDespesa.ForeColor = System.Drawing.SystemColors.ControlText;

                this.labelDataInicial.BackColor = System.Drawing.SystemColors.Control;
                this.labelDataInicial.ForeColor = System.Drawing.SystemColors.ControlText;

                this.labelDataFinal.BackColor = System.Drawing.SystemColors.Control;
                this.labelDataFinal.ForeColor = System.Drawing.SystemColors.ControlText;

                this.label2.BackColor = System.Drawing.SystemColors.Control;
                this.label2.ForeColor = System.Drawing.SystemColors.ControlText;

                this.label1.ForeColor = System.Drawing.SystemColors.Control;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
