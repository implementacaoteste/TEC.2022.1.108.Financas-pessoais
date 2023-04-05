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
    public partial class FormConsultarReceita : Form
    {
        public FormConsultarReceita()
        {
            InitializeComponent();
        }

        private void buttonAlterarReceita_Click(object sender, EventArgs e)
        {
            int id = ((Receita)receitaBindingSource.Current).Id;
            using (FormCadastroReceita frm = new FormCadastroReceita(id))
            {
                frm.ShowDialog();
            }
            buttonBuscarReceita_Click(null, null);
        }

        private void buttonBuscarReceita_Click(object sender, EventArgs e)
        {
            receitaBindingSource.DataSource = new ReceitaBLL().BuscarTodos();
        }

        private void buttonAdicionarReceita_Click(object sender, EventArgs e)
        {
            using(FormCadastroReceita frm = new FormCadastroReceita())
            {
                frm.ShowDialog();
            }
            buttonBuscarReceita_Click(null, null);
        }

        private void buttonExcluirReceita_Click(object sender, EventArgs e)
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

            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
