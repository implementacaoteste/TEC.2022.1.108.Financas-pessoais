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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void banToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaBanco frm = new FormConsultaBanco())
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
            using (FormConsultaReceita frm = new FormConsultaReceita())
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
            using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento())
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
            Autenticar();
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroContato frm = new FormCadastroContato())
            {
                frm.ShowDialog();
            }
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
            using (FormCadastroReceita fr = new FormCadastroReceita())
            {
                fr.ShowDialog();
            }
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaUsuario frm = new FormConsultaUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormCadastroContasReceber frm = new FormCadastroContasReceber())
            {
                frm.ShowDialog();
            }
        }

        private void formaDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormCadastroFormaPagamento frm = new FormCadastroFormaPagamento())
            {
                frm.ShowDialog();
            }
        }

        private void cadastroDespesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new DespesasBLL().Inserir(new Models.Despesas()
                {
                    DataEmissao = DateTime.Now,
                    Descricao = "Teste",
                    IdBanco = 3,
                    IdContato = 2,
                    IdFormaPagamento = 1,
                    Valor = 25
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cadastroReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new ReceitaBLL().Inserir(new Models.Receita()
                {
                    DataEmissao = DateTime.Now,
                    Descricao = "Sem contas a receber",
                    IdBanco = 3,
                    IdContato = 2,
                    IdFormaPagamento = 1,
                    Valor = 25
                });

                new ReceitaBLL().Inserir(new Models.Receita()
                {
                    DataEmissao = DateTime.Now,
                    Descricao = "Com contas a receber",
                    IdBanco = 3,
                    IdContato = 2,
                    IdFormaPagamento = 1,
                    Valor = 58,
                    IdContasReceber = 1
                },
                new ContasReceber()
                {
                    Id = 1,
                    IdBanco = 3,
                    IdContato = 2,
                    DataEmissao = DateTime.Now,
                    IdFormaPagamento = 1,
                    ValorReceber = 58
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mudarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autenticar();
        }

        private void Autenticar()
        {
            Constantes.IdUsuarioLogado = 0;
            using (FormLogin frm = new FormLogin())
            {
                frm.ShowDialog();
            }
            linkLabel1.Visible = Constantes.IdUsuarioLogado == -1;
            toolStripStatusLabelUsuario.Text = "Usuário: " + Constantes.NomeUsuarioLogado;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gean-teste.github.io/financaspessoais/");
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                if (MessageBox.Show("Deseja realmente sair do sistema?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Application.Exit();
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripStatusLabelUsuario_Click(object sender, EventArgs e)
        {
            
        }
    }
}