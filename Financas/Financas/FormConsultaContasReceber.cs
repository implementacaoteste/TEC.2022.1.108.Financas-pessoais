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
            try
            {

                contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarTodos();
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
            int id = ((ContasReceber)contasReceberBindingSource.Current).Id;
            using (FormCadastroContasReceber frm = new FormCadastroContasReceber(id))
            {
                frm.ShowDialog();
            }
            buttonBuscarContasReceber_Click(null, null);
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
    }
}
