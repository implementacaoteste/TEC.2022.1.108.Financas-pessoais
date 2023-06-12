using BLL;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsAppPrincipal;

namespace Financas
{
    public partial class FormCadastroDespesas : Form
    {
        public int Id;
        private ContasPagar contasPagar;
        public FormCadastroDespesas(ContasPagar _contasPagar = null, int id = 0)
        {
            InitializeComponent();
            Id = id;
            contasPagar = _contasPagar;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DespesasBLL despesasBLL = new DespesasBLL();
                despesasBindingSource.EndEdit();

                if (Id == 0)
                    despesasBLL.Inserir((Despesas)despesasBindingSource.Current, contasPagar);
                else
                    despesasBLL.Alterar((Despesas)despesasBindingSource.Current);
                MessageBox.Show("Registro salvo com sucesso");
                Close();
            }
            catch (Exception ex)
            {
                int idErro = new TratarErro().PegarId(ex);

                if (idErro == 0)
                    textBoxDescricao.Focus();
                else
                if (idErro == 1)
                    textBoxGastos.Focus();

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroDespesas_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
            this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo.png");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            if (Id == 0)
                despesasBindingSource.AddNew();
            else
                despesasBindingSource.DataSource = new DespesasBLL().BuscarPorId(Id);

            if (contasPagar != null)
            {
                ((Despesas)despesasBindingSource.Current).Valor = contasPagar.ValorPagar;
                textBoxGastos.Text = contasPagar.ValorPagar.ToString();
                ((Despesas)despesasBindingSource.Current).Descricao = contasPagar.Descricao;
                textBoxDescricao.Text = contasPagar.Descricao;
                ((Despesas)despesasBindingSource.Current).IdContato = contasPagar.IdContato;
                ((Despesas)despesasBindingSource.Current).Contato = contasPagar.Contato;
                contatoTextBox.Text = contasPagar.Contato;
                ((Despesas)despesasBindingSource.Current).IdBanco = contasPagar.IdBanco;
                ((Despesas)despesasBindingSource.Current).Banco = contasPagar.Banco;
                bancoTextBox.Text = contasPagar.Banco;
                ((Despesas)despesasBindingSource.Current).IdFormaPagamento = contasPagar.IdFormaPagamento;
                ((Despesas)despesasBindingSource.Current).FormaPagamento = contasPagar.FormaPagamento;
                formaPagamentoTextBox.Text = contasPagar.FormaPagamento;
            }

            if (contasPagar != null)
            {
                buttonBuscarContatoDespesas.Visible = false;
                this.buttonBuscarContatoDespesas.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            }
        }

        private void buttonBuscarContatoDespesas_Click(object sender, EventArgs e)
        {
            using (FormConsultaContato frm = new FormConsultaContato(true))
            {
                frm.ShowDialog();
                ((Despesas)despesasBindingSource.Current).IdContato = frm.Id;
                contatoTextBox.Text = frm.Nome;
                bancoTextBox.Focus();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaBanco frm = new FormConsultaBanco(true))
                {
                    frm.ShowDialog();
                    new DespesasBLL().ValidarSaldo(Convert.ToDouble(textBoxGastos.Text), frm.Id);
                    ((Despesas)despesasBindingSource.Current).IdBanco = frm.Id;
                    bancoTextBox.Text = frm.Nome;
                    formaPagamentoTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscarFormaPagamentoDespesas_Click(object sender, EventArgs e)
        {
            using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento(true))
            {
                frm.ShowDialog();
                ((Despesas)despesasBindingSource.Current).IdFormaPagamento = frm.Id;
                formaPagamentoTextBox.Text = frm.Descricao;
                textBoxDescricao.Focus();
            }
        }

        private void FormCadastroDespesas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void textBoxDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSalvar_Click(null, null);
        }

        private void contatoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                buttonBuscarContatoDespesas_Click(null,null);
        }

        private void bancoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonBuscar_Click(null, null);
        }

        private void formaPagamentoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                buttonBuscarFormaPagamentoDespesas_Click(null, null);
        }

        private void textBoxGastos_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                contatoTextBox.Focus();
        }
    }
}
