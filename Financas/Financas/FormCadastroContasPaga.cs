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
using BLL;

namespace Financas
{
    public partial class FormCadastroContasPaga : Form
    {
        public int Id;
        public FormCadastroContasPaga(int id=0)
        {
            InitializeComponent();
            Id = id;
        }

        private void buttonCancelarCadastroContasPagar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvarCadastroContasPagar_Click(object sender, EventArgs e)
        {
            ContasPagarBLL BancoBLL = new ContasPagarBLL();
           contasPagarBindingSource.EndEdit();

            if (Id == 0)
                BancoBLL.Inserir((ContasPagar)contasPagarBindingSource.Current);
            else
                BancoBLL.Alterar((ContasPagar)contasPagarBindingSource.Current);

            MessageBox.Show("Registro salvo com sucesso");
            Close();
        }
    }
}
