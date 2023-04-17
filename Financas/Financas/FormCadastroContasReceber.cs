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
    public partial class FormCadastroContasReceber : Form
    {
        public int Id;
        public FormCadastroContasReceber(int id = 0)
        {
            InitializeComponent();
            Id = id;
        }

        private void buttonSalvarCadastroContasReceber_Click(object sender, EventArgs e)
        {
            try
            {
                ContasReceberBLL contasReceberBLL = new ContasReceberBLL();
                contasReceberBindingSource.EndEdit();
                if (Id == 0)
                    contasReceberBLL.Inserir((ContasReceber)contasReceberBindingSource.Current);
                else
                    contasReceberBLL.Alterar((ContasReceber)contasReceberBindingSource.Current);
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

        private void buttonCancelarCadastroContasReceber_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBuscarContatoContasReceber_Click(object sender, EventArgs e)
        {
            using (FormConsultaContato frm = new FormConsultaContato(true))
            {
                frm.ShowDialog();
                ((ContasReceber)contasReceberBindingSource.Current).IdContato = frm.Id;
                textBoxBuscarContato.Text = frm.Nome;
            }
            // contatoBindingSource.DataSource = new ContatoBLL().BuscarPorNome(textBoxBuscarContato.Text);
        }

        private void textBoxBuscarContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarBanco_Click(object sender, EventArgs e)
        {
            using (FormConsultaBanco frm = new FormConsultaBanco(true))
            {
                frm.ShowDialog();
                ((ContasReceber)contasReceberBindingSource.Current).IdBanco = frm.Id;
                bancoTextBox.Text = frm.Nome;
            }
        }

        private void buttonBuscarFormaPagamento_Click(object sender, EventArgs e)
        {
            using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento(true))
            {
                frm.ShowDialog();
                ((ContasReceber)contasReceberBindingSource.Current).IdFormaPagamento = frm.Id;
                formaPagamentoTextBox.Text = frm.Descricao;
            }
        }

        private void FormCadastroContasReceber_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                contasReceberBindingSource.AddNew();
            else
                contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorId(Id);
        }
    }
}
