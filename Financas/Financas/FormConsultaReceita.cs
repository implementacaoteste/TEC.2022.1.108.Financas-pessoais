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
    public partial class FormConsultaReceita : Form
    {
        public FormConsultaReceita()
        {
            InitializeComponent();
        }

        private void buttonAlterarReceita_Click(object sender, EventArgs e)
        {
            int id = ((Receita)receitaBindingSource.Current).Id;
            using (FormCadastroReceita frm = new FormCadastroReceita(null, id))
            {
                frm.ShowDialog();
            }
            buttonBuscarReceita_Click(null, null);
        }

        private void buttonBuscarReceita_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        receitaBindingSource.DataSource = new ReceitaBLL().BuscarTodos();
                        break;
                    case 1:
                        receitaBindingSource.DataSource = new ReceitaBLL().BuscarPorDescricao(textBoxConsultarReceita.Text);
                        break;
                    case 2:
                        receitaBindingSource.DataSource = new ReceitaBLL().BuscarPorPeriodo(Convert.ToDateTime(textBoxConsultarReceita.Text), Convert.ToDateTime(textBoxConsultarReceita2.Text));
                        break;
                    case 3:
                        receitaBindingSource.DataSource = new ReceitaBLL().BuscarPorContato(textBoxConsultarReceita.Text);
                        break;
                    case 4:
                        receitaBindingSource.DataSource = new ReceitaBLL().BuscarPorFormaPagamento(textBoxConsultarReceita.Text);
                        break;
                    case 5:
                        receitaBindingSource.DataSource = new ReceitaBLL().BuscarPorBanco(textBoxConsultarReceita.Text);
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
        private void buttonAdicionarReceita_Click(object sender, EventArgs e)
        {
            using (FormCadastroReceita frm = new FormCadastroReceita())
            {
                frm.ShowDialog();
            }
            buttonBuscarReceita_Click(null, null);
        }

        private void buttonExcluirReceita_Click(object sender, EventArgs e)
        {
            try
            {

                if (receitaBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Receita)receitaBindingSource.Current).Id;
                new ReceitaBLL().Excluir(id);
                receitaBindingSource.RemoveCurrent();
                MessageBox.Show("Registro excluído com sucesso!");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDataInicial.Visible = false;
            labelDataFinal.Visible = false;
            textBoxConsultarReceita.Width = 375;
            textBoxConsultarReceita2.Visible = false;

            if (comboBox1.SelectedIndex == 2)
            {
                labelDataInicial.Visible = true;
                labelDataFinal.Visible = true;
                textBoxConsultarReceita.Width = 248;
                textBoxConsultarReceita2.Visible = true;
            }
        }

        private void FormConsultaReceita_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

        }

        private void FormConsultaReceita_Load(object sender, EventArgs e)
        {
            try
            {

                comboBox1.SelectedIndex = 0;
                this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo2.png");
                this.labelDataInicial.ForeColor = System.Drawing.SystemColors.ControlText;
                this.labelDataInicial.BackColor = System.Drawing.SystemColors.Control;

                this.labelDataFinal.ForeColor = System.Drawing.SystemColors.ControlText;
                this.labelDataFinal.BackColor = System.Drawing.SystemColors.Control;

                this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
                this.label1.BackColor = System.Drawing.SystemColors.Control;

                this.label2.ForeColor = System.Drawing.SystemColors.Control;

                this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
                this.label3.BackColor = System.Drawing.SystemColors.Control;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
