using BLL;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Financas
{
    public partial class FormConsultaFormaPagamento : Form
    {
        public int Id;
        public string Descricao;
        private string filtro;
        public FormConsultaFormaPagamento(bool _selecionar = false)
        {
            InitializeComponent();
            buttonSelecionar.Visible = _selecionar;
        }

        private void buttonBuscarFormaPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        formaPagamentoBindingSource.DataSource = new FormaPagamentoBLL().BuscarTodos();
                        break;
                    case 1:
                        formaPagamentoBindingSource.DataSource = new FormaPagamentoBLL().BuscarPorDescricao(textBoxConsultarFormaPagamento.Text);
                        break;

                    case 2:
                        formaPagamentoBindingSource.DataSource = new FormaPagamentoBLL().BuscarPorInativo(textBoxConsultarFormaPagamento.Text);
                        break;



                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterarFormaPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (formaPagamentoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro a ser alterado");
                    return;
                }
                int id = ((FormaPagamento)formaPagamentoBindingSource.Current).Id;
                using (FormCadastroFormaPagamento frm = new FormCadastroFormaPagamento(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarFormaPagamento_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirFormaPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (formaPagamentoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((FormaPagamento)formaPagamentoBindingSource.Current).Id;
                new FormaPagamentoBLL().Excluir(id);
                formaPagamentoBindingSource.RemoveCurrent();

                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAdicionarFormaPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroFormaPagamento frm = new FormCadastroFormaPagamento())
                {
                    frm.ShowDialog();
                }
                buttonBuscarFormaPagamento_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdicionarFormaPagamento_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroFormaPagamento frm = new FormCadastroFormaPagamento())
                {
                    frm.ShowDialog();
                }
                buttonBuscarFormaPagamento_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (formaPagamentoBindingSource.Count > 0)
                {
                    if (!((FormaPagamento)formaPagamentoBindingSource.Current).Ativo)
                        throw new Exception("Esta forma de pagamento está inativa. Você precisa ativá-la ou escolher outra.");

                    Id = ((FormaPagamento)formaPagamentoBindingSource.Current).Id;
                    Descricao = ((FormaPagamento)formaPagamentoBindingSource.Current).Descricao;
                    Close();
                }
                else
                    MessageBox.Show("Não existe um Devedor para ser selecionado.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormConsultaFormaPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedIndex = 1;
                this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo2.png");

                this.label1.ForeColor =
                this.label3.ForeColor = SystemColors.ControlText;

                this.label2.ForeColor =
                this.label1.BackColor =
                this.label3.BackColor = SystemColors.Control;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (formaPagamentoBindingSource.Count > 0)
                {
                    if (!((FormaPagamento)formaPagamentoBindingSource.Current).Ativo)
                        throw new Exception("Esta forma de pagamento está inativa. Você precisa ativá-la ou escolher outra.");

                    Id = ((FormaPagamento)formaPagamentoBindingSource.Current).Id;
                    Descricao = ((FormaPagamento)formaPagamentoBindingSource.Current).Descricao;
                    Close();
                }
                else
                    MessageBox.Show("Não existe um Devedor para ser selecionado.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxConsultarFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (filtro != textBoxConsultarFormaPagamento.Text)
                {
                    buttonBuscarFormaPagamento_Click(null, null);
                    filtro = textBoxConsultarFormaPagamento.Text;
                }
                else
                {
                    buttonSelecionar_Click(null, null);
                }

            }
            else if (e.KeyCode == Keys.Up)
            {
                formaPagamentoBindingSource.MovePrevious();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                formaPagamentoBindingSource.MoveNext();
                e.Handled = true;
            }

        }

        private void formaPagamentoDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSelecionar_Click(null, null);
            e.Handled = true;
        }

        private void formaPagamentoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            buttonSelecionar_Click(null, null);
        }

        private void formaPagamentoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            formaPagamentoBindingSource.DataSource = new FormaPagamentoBLL().BuscarTodos();
        }
    }
}
