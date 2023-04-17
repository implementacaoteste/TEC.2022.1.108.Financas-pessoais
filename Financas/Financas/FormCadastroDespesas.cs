using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace Financas
{
    public partial class FormCadastroDespesas : Form
    {
        public  int Id;
        public FormCadastroDespesas(int id=0)
        {
            InitializeComponent();
            Id = id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DespesasBLL despesasBLL = new DespesasBLL();
                despesasBindingSource.EndEdit();

                despesasBLL.Inserir((Despesas)despesasBindingSource.Current);
            }
            catch
            {
                MessageBox.Show("Registro salvo com sucesso!");
            }
            finally
            {
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroDespesas_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                despesasBindingSource.AddNew();
            else
                despesasBindingSource.DataSource = new DespesasBLL().BuscarTodos();
        }

        private void buttonBuscarContatoDespesas_Click(object sender, EventArgs e)
        {
            using(FormConsultaContato frm = new FormConsultaContato(true))
            {
                frm.ShowDialog();
                ((Despesas)despesasBindingSource.Current).IdContato = frm.Id;
                contatoTextBox.Text = frm.Nome;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            using(FormConsultaBanco frm = new FormConsultaBanco(true))
            {
                frm.ShowDialog();
                ((Despesas)despesasBindingSource.Current).IdBanco = frm.Id;
                bancoTextBox.Text = frm.Nome;
            }
        }

        private void buttonBuscarFormaPagamentoDespesas_Click(object sender, EventArgs e)
        {
            using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento(true))
            {
                frm.ShowDialog();
                ((Despesas)despesasBindingSource.Current).IdFormaPagamento = frm.Id;
                formaPagamentoTextBox.Text = frm.Descricao;
            }
        }

        private void FormCadastroDespesas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                Close();
        }

        private void textBoxDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                buttonSalvar_Click(sender, e);
        }
    }
}
