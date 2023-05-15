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
        public FormCadastroContasReceber(int id = 0)
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
                if (Id == 0)
                    contasReceberBLL.Inserir((ContasReceber)contasReceberBindingSource.Current);
                else
                    contasReceberBLL.Alterar((ContasReceber)contasReceberBindingSource.Current);

                MessageBox.Show("Registro salvo com sucesso");
                Close();
            }
            catch
            {
                MessageBox.Show("Registro salvo com sucesso!");
            }

        }

        private void buttonCancelarCadastroContasReceber_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBuscarContatoContasReceber_Click(object sender, EventArgs e)
        {
            using (FormConsultaContato frm = new FormConsultaContato(true))
            {
                frm.ShowDialog();
                ((ContasReceber)contasReceberBindingSource.Current).IdContato = frm.Id;
                textBoxBuscarContato.Text = frm.Nome;
            }
            // contatoBindingSource.DataSource = new ContatoBLL().BuscarPorNome(textBoxBuscarContato.Text);
        }

      

        private void buttonBuscarBanco_Click(object sender, EventArgs e)
        {
            using (FormConsultaBanco frm = new FormConsultaBanco(true))
            {
                frm.ShowDialog();
                ((ContasReceber)contasReceberBindingSource.Current).IdBanco = frm.Id;
                bancoTextBox.Text = frm.Nome;
            }
        }

        private void buttonBuscarFormaPagamento_Click(object sender, EventArgs e)
        {
            using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento(true))
            {
                frm.ShowDialog();
                ((ContasReceber)contasReceberBindingSource.Current).IdFormaPagamento = frm.Id;
                formaPagamentoTextBox.Text = frm.Descricao;
            }
        }

        private void FormCadastroContasReceber_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
            if (Id == 0)
            {
                contasReceberBindingSource.AddNew();
                ((ContasReceber)contasReceberBindingSource.Current).DataEmissao = DateTime.Now;
            }
            else
                contasReceberBindingSource.DataSource = new ContasReceberBLL().BuscarPorId(Id);
            this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo.png");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
        }

        private void FormCadastroContasReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void valorReceberTextBoxContasReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                textBoxBuscarContato.Focus();
            }
        }

        private void textBoxBuscarContato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscarContatoContasReceber_Click(sender, e);
                bancoTextBox.Focus();
            }
        }

        private void bancoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscarBanco_Click(null,null);
                formaPagamentoTextBox.Focus();
            }
        }

        private void formaPagamentoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscarFormaPagamento_Click(null, null);
                descricaoTextBoxContasReceber.Focus();
            }
        }

        private void descricaoTextBoxContasReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                dataEmissaoDateTimePicker.Focus();
            }
        }

        private void dataEmissaoDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSalvarCadastroContasReceber_Click(null, null);
        }

    }
}
