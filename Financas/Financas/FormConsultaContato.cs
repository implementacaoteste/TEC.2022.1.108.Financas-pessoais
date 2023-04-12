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
    public partial class FormConsultaContato : Form
    {
        public int Id;
        public string Nome;
        public FormConsultaContato(bool _selecionar = false)
        {
            InitializeComponent();
            buttonSelecionarContato.Visible = _selecionar;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                contatoBindingSource.DataSource = new ContatoBLL().BuscarPorNome(textBoxBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            using (FormCadastroContato frm = new FormCadastroContato())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (contatoBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Contato)contatoBindingSource.Current).Id;
            new ContatoBLL().Excluir(id);
            contatoBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((Contato)contatoBindingSource.Current).Id;
            using (FormCadastroContato frm = new FormCadastroContato(id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonSelecionarContato_Click(object sender, EventArgs e)
        {
            try
            {
                if (contatoBindingSource.Count > 0)
                {
                    Id = ((Contato)contatoBindingSource.Current).Id;
                    Nome = ((Contato)contatoBindingSource.Current).Nome;
                    Close();
                }
                else
                    MessageBox.Show("Não existe um Devedor para ser selecionado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaContato_Load(object sender, EventArgs e)
        {

        }
    }
}
