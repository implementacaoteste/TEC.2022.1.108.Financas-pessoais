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
        public FormCadastroContasReceber(int id=0)
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

                contasReceberBLL.Inserir((ContasReceber)contasReceberBindingSource.Current);
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
            contatoBindingSource.DataSource = new ContatoBLL().BuscarPorNome(textBoxBuscarContato.Text);
        }
    }
}
