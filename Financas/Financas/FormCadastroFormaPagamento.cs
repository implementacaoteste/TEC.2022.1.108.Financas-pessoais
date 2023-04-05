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
    public partial class FormCadastroFormaPagamento : Form
    {
        public int Id;

        public FormCadastroFormaPagamento(int id = 0)
        {
            InitializeComponent();
            Id = id;
        }



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FormaPagamentoBLL formaPagamentoBLL = new FormaPagamentoBLL();
                formaPagamentoBindingSource.EndEdit();

                formaPagamentoBLL.Inserir((FormaPagamento)formaPagamentoBindingSource.Current);
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

        private void FormFormaPagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
