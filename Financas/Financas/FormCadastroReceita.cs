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
    public partial class FormCadastroReceita : Form
    {
        public int Id;
        public FormCadastroReceita(int id = 0)
        {
            InitializeComponent();
            Id = id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            ReceitaBLL receitaBLL = new ReceitaBLL();
            receitaBindingSource.EndEdit();

            if (Id == 0)
                receitaBLL.Inserir((Receita)receitaBindingSource.Current);
            else
                receitaBLL.Alterar((Receita)receitaBindingSource.Current);
            MessageBox.Show("Registro salvo com sucesso");
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroReceita_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                receitaBindingSource.AddNew();
            else
                receitaBindingSource.DataSource = new ReceitaBLL().BuscarPorId(Id);
        }

        private void buttonBuscarContatoReceita_Click(object sender, EventArgs e)
        {
            using (FormConsultaContato frm = new FormConsultaContato(true))
            {
                frm.ShowDialog();

                ((Receita)receitaBindingSource.Current).IdContato = frm.Id;
                contatoTextBox.Text = frm.Nome;
            }
        }

        private void buttonBuscarBancoReceita_Click(object sender, EventArgs e)
        {
            using (FormConsultaBanco frm = new FormConsultaBanco(true))
            {
                frm.ShowDialog();

                ((Receita)receitaBindingSource.Current).IdBanco = frm.Id;
                bancoTextBox.Text = frm.Nome;
              
            }
        }

        private void buttonBuscarFormaPagamentoReceita_Click(object sender, EventArgs e)
        {
            using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento())
            {
                frm.ShowDialog();
                ((Receita)receitaBindingSource.Current).IdFormaPagamento = frm.Id;
                formaPagamentoTextBox.Text = frm.Descricao;
            }
        }



        private void buttonDataEmissaoCadastroReceita_Click(object sender, EventArgs e)
        {
            using (FormConsultaReceita frm = new FormConsultaReceita())
            {
                frm.ShowDialog();
            }

        }
    }
}

