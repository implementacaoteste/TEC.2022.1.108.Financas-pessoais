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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void banToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormConsultaBanco frm = new FormConsultaBanco())
            {
                frm.ShowDialog();
            }
        }

        private void contatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormConsultaContato frm = new FormConsultaContato())
            {
                frm.ShowDialog();
            }
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultarReceita frm = new FormConsultarReceita())
            {
                frm.ShowDialog();
            }
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaDespesas frm = new FormConsultaDespesas())
            {
                frm.ShowDialog();
            }
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaContasPagar frm = new FormConsultaContasPagar())
            {
                frm.ShowDialog();
            }
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaContasReceber frm = new FormConsultaContasReceber())
            {
                frm.ShowDialog();
            }
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento())
            {
                frm.ShowDialog();
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (FormConsultaDespesas form = new FormConsultaDespesas())
            {
                form.ShowDialog();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
             using(FormLogin florm = new FormLogin())
             {
                 florm.ShowDialog();
             }
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroContato frm = new FormCadastroContato())
            {
                frm.ShowDialog();
            }
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroBanco frm = new FormCadastroBanco())
            {
                frm.ShowDialog();
            }
        }

        private void contasAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormCadastroContasPaga frm = new FormCadastroContasPaga())
            {
                frm.ShowDialog();
            }
        }

        private void despesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormCadastroDespesas frm = new FormCadastroDespesas())
            {
                frm.ShowDialog();
            }
        }

        private void receitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormConsultaUsuario frm = new FormConsultaUsuario())
            {
                frm.ShowDialog();
            }
        }
    }
}