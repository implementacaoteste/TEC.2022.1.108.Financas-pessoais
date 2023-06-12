using BLL;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsAppPrincipal;

namespace Financas
{
    public partial class FormCadastroReceita : Form
    {
        public int Id;
        private ContasReceber contasReceber;
        public FormCadastroReceita(ContasReceber _contasReceber = null, int _id = 0)
        {
            InitializeComponent();
            Id = _id;
            contasReceber = _contasReceber;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ReceitaBLL receitaBLL = new ReceitaBLL();
                receitaBindingSource.EndEdit();

                if (Id == 0)
                    receitaBLL.Inserir((Receita)receitaBindingSource.Current, contasReceber);
                else
                    receitaBLL.Alterar((Receita)receitaBindingSource.Current);
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
                    textBoxGanhos.Focus();

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroReceita_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo.png");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            if (Id == 0)
                receitaBindingSource.AddNew();
            else
                receitaBindingSource.DataSource = new ReceitaBLL().BuscarPorId(Id);

            if (contasReceber != null)
            {
                ((Receita)receitaBindingSource.Current).Valor = contasReceber.ValorReceber;
                textBoxGanhos.Text = contasReceber.ValorReceber.ToString();
                ((Receita)receitaBindingSource.Current).Descricao = contasReceber.Descricao;
                textBoxDescricao.Text = contasReceber.Descricao;
                ((Receita)receitaBindingSource.Current).IdContato = contasReceber.IdContato;
                ((Receita)receitaBindingSource.Current).Contato = contasReceber.Contato;
                contatoTextBox.Text = contasReceber.Contato;
                ((Receita)receitaBindingSource.Current).IdBanco = contasReceber.IdBanco;
                ((Receita)receitaBindingSource.Current).Banco = contasReceber.Banco;
                bancoTextBox.Text = contasReceber.Banco;
                ((Receita)receitaBindingSource.Current).IdFormaPagamento = contasReceber.IdFormaPagamento;
                ((Receita)receitaBindingSource.Current).FormaPagamento = contasReceber.FormaPagamento;
                formaPagamentoTextBox.Text = contasReceber.FormaPagamento;
            }
            if (contasReceber != null)
            {
                buttonBuscarContatoReceita.Visible = false;
                this.buttonBuscarContatoReceita.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            }
        }

        private void buttonBuscarContatoReceita_Click(object sender, EventArgs e)
        {
            using (FormConsultaContato frm = new FormConsultaContato(true))
            {
                frm.ShowDialog();

                ((Receita)receitaBindingSource.Current).IdContato = frm.Id;
                contatoTextBox.Text = frm.Nome;
                bancoTextBox.Focus();
            }
        }

        private void buttonBuscarBancoReceita_Click(object sender, EventArgs e)
        {
            using (FormConsultaBanco frm = new FormConsultaBanco(true))
            {
                frm.ShowDialog();

                ((Receita)receitaBindingSource.Current).IdBanco = frm.Id;
                bancoTextBox.Text = frm.Nome;
                formaPagamentoTextBox.Focus();

            }
        }

        private void buttonBuscarFormaPagamentoReceita_Click(object sender, EventArgs e)
        {
            using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento(true))
            {
                frm.ShowDialog();
                ((Receita)receitaBindingSource.Current).IdFormaPagamento = frm.Id;
                formaPagamentoTextBox.Text = frm.Descricao;
                textBoxDescricao.Focus();
            }
        }



        private void buttonDataEmissaoCadastroReceita_Click(object sender, EventArgs e)
        {
            using (FormConsultaReceita frm = new FormConsultaReceita())
            {
                frm.ShowDialog();
            }

        }

        /* private void FormCadastroReceita_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Escape)
                 Close();
         }*/

        private void textBoxDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSalvar_Click(null, null);
        }

        private void FormCadastroReceita_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void contatoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonBuscarContatoReceita_Click(null, null);
        }

        private void contatoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bancoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonBuscarBancoReceita_Click(null, null);
        }

        private void formaPagamentoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonBuscarFormaPagamentoReceita_Click(null, null);
        }

        private void textBoxGanhos_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                contatoTextBox.Focus();
        }
    }
}

