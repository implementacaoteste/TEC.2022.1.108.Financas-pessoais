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
        public FormConsultaContasPagar()
        {
            InitializeComponent();
        }

        private void buttonBuscarConsultaContasPagar_Click(object sender, EventArgs e)
        {
            contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarTodos();
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
            int id = ((ContasPagar)contasPagarBindingSource.Current).Id;
            using (FormCadastroContasPaga frm = new FormCadastroContasPaga(id))
            {
                frm.ShowDialog();
            }
            buttonBuscarConsultaContasPagar_Click(null, null);
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
    }
}
