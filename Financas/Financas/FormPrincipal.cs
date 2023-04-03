﻿using System;
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
    }
}
