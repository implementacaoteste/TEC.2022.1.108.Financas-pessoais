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
        public FormCadastroContasPaga(int id = 0)
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
            ContasPagarBLL contasPagarBLL = new ContasPagarBLL();
            contasPagarBindingSource.EndEdit();

            if (Id == 0)
                contasPagarBLL.Inserir((ContasPagar)contasPagarBindingSource.Current);
            else
                contasPagarBLL.Alterar((ContasPagar)contasPagarBindingSource.Current);

            MessageBox.Show("Registro salvo com sucesso");
            Close();
        }

        private void FormCadastroContasPaga_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0,0,0);
            if (Id == 0)
            {
                contasPagarBindingSource.AddNew();
                ((ContasPagar)contasPagarBindingSource.Current).DataEmissao = DateTime.Now;
            }
            else
                contasPagarBindingSource.DataSource = new ContasPagarBLL().BuscarPorId(Id);
            this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo.png");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
        }

        private void buttonBuscarContatoContasPagar_Click(object sender, EventArgs e)
        {
            using (FormConsultaContato frm = new FormConsultaContato(true))
            {
                frm.ShowDialog();
                ((ContasPagar)contasPagarBindingSource.Current).IdContato = frm.Id;
                contatoTextBox.Text = frm.Nome;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormConsultaBanco frm = new FormConsultaBanco(true))
            {
                frm.ShowDialog();
                ((ContasPagar)contasPagarBindingSource.Current).IdBanco = frm.Id;
                bancoTextBox.Text = frm.Nome;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento(true))
            {
                frm.ShowDialog();
                ((ContasPagar)contasPagarBindingSource.Current).IdFormaPagamento = frm.Id;
                formaPagamentoTextBox.Text = frm.Descricao;
            }
        }

        private void FormCadastroContasPaga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }


        private void valorPagarTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                contatoTextBox.Focus();
            }
        }

        private void contatoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                bancoTextBox.Focus();
            }
        }

        private void bancoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                formaPagamentoTextBox.Focus();
            }


        }

        private void formaPagamentoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                descricaoTextBox.Focus();
            }
        }

        private void descricaoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                dataEmissaoDateTimePicker.Focus();
            }

        }

        private void dataEmissaoDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                buttonSalvarCadastroContasPagar_Click(null, null);


            }
        }
    }
}
