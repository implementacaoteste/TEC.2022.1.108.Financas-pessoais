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
using Models;

namespace Financas
{
    public partial class FormConsultaBanco : Form
    {
        public FormConsultaBanco()
        {
            InitializeComponent();
        }

        private void buttonBuscarBanco_Click(object sender, EventArgs e)
        {
            bancoBindingSource.DataSource = new BancoBLL().BuscarTodos();
        }

        private void bancoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdicionarBanco_Click(object sender, EventArgs e)
        {
            using (FormCadastroBanco frm = new FormCadastroBanco())
            {
                frm.ShowDialog();
            }
            buttonBuscarBanco_Click(null, null);
        }

        private void buttonAlterarBanco_Click(object sender, EventArgs e)
        {

            int id = ((Banco)bancoBindingSource.Current).Id;
            using (FormCadastroBanco frm = new FormCadastroBanco(id))
            {
                frm.ShowDialog();
            }
            buttonBuscarBanco_Click(null, null);
        }

        private void buttonExcluirBanco_Click(object sender, EventArgs e)
        {
            if (bancoBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Banco)bancoBindingSource.Current).Id;
            new BancoBLL().Excluir(id);
            bancoBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
