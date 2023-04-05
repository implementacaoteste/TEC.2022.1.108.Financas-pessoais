using BLL;
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
            contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarTodos();
        }

        private void buttonAdicionarContasReceber_Click(object sender, EventArgs e)
        {
            using (FormCadastroBanco frm = new FormCadastroBanco())
            {
                frm.ShowDialog();
            }
            buttonBuscarConsultaContasPagar_Click(null, null);
        }
    }
}
