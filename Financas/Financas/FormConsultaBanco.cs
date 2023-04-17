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
        public int Id;
        public string Nome;
        public FormConsultaBanco(bool _selecionarBanco = false)
        {
            InitializeComponent();
            buttonSelecionarBanco.Visible = _selecionarBanco;
        }

        private void buttonBuscarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscar.SelectedIndex)
                {
                    case 0:
                        bancoBindingSource.DataSource = new BancoBLL().BuscarTodos();
                        break;
                    case 1:
                        bancoBindingSource.DataSource = new BancoBLL().BuscarPorNome(textBoxConsultarBanco.Text);
                        break;                    
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void FormConsultaBanco_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSelecionarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                if (bancoBindingSource.Count > 0)
                {
                    Id = ((Banco)bancoBindingSource.Current).Id;
                    Nome = ((Banco)bancoBindingSource.Current).Nome;
                    Close();
                }
                else
                    MessageBox.Show("Não existe um Banco para ser selecionado.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
