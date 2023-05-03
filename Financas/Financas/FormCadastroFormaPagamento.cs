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
                if (Id == 0)
                    formaPagamentoBLL.Inserir((FormaPagamento)formaPagamentoBindingSource.Current);
                else
                    formaPagamentoBLL.Alterar((FormaPagamento)formaPagamentoBindingSource.Current);
                MessageBox.Show("Registro salvo com sucesso");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void FormFormaPagamento_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                formaPagamentoBindingSource.AddNew();
            else
                formaPagamentoBindingSource.DataSource = new FormaPagamentoBLL().BuscarPorId(Id);
            this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo.png");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;

        }

        private void textBoxDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSalvar_Click(null, null);
        }

        private void FormCadastroFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
