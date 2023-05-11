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
using Models;

namespace Financas
{
    public partial class FormConsultaBanco : Form
    {
        public int Id;
        public string Nome;
        private string filtro;
        public FormConsultaBanco(bool _selecionarBanco = false)
        {
            InitializeComponent();
            buttonSelecionarBanco.Visible = _selecionarBanco;
        }

        private void buttonBuscarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscar.SelectedIndex)
                {
                    case 0:
                        bancoBindingSource.DataSource = new BancoBLL().BuscarTodos();
                        break;
                    case 1:
                        bancoBindingSource.DataSource = new BancoBLL().BuscarPorNome(textBoxConsultarBanco.Text);
                        break;
                    case 2:
                        bancoBindingSource.DataSource = new BancoBLL().BuscarPorInativo(textBoxConsultarBanco.Text);
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

        private void buttonAdicionarBanco_Click(object sender, EventArgs e)
        {
            using (FormCadastroBanco frm = new FormCadastroBanco())
            {
                frm.ShowDialog();
            }
            buttonBuscarBanco_Click(null, null);
        }

        private void buttonAlterarBanco_Click(object sender, EventArgs e)
        {
            int id = ((Banco)bancoBindingSource.Current).Id;

            using (FormCadastroBanco frm = new FormCadastroBanco(id))
            {
                frm.ShowDialog();
            }
            buttonBuscarBanco_Click(null, null);
        }

        private void buttonExcluirBanco_Click(object sender, EventArgs e)
        {
            try
            {

                if (bancoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Banco)bancoBindingSource.Current).Id;
                new BancoBLL().Excluir(id);
                bancoBindingSource.RemoveCurrent();

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

        private void FormConsultaBanco_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxBuscar.SelectedIndex = 1;
                this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo2.png");
                this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
                this.label1.BackColor = System.Drawing.SystemColors.Control;
                this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
                this.label3.BackColor = System.Drawing.SystemColors.Control;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                if (bancoBindingSource.Count > 0)
                {
                    if (!((Banco)bancoBindingSource.Current).Ativo)
                        throw new Exception("Este banco está inativo. Você precisa ativá-lo ou escolher outro banco.");
                    
                    Id = ((Banco)bancoBindingSource.Current).Id;
                    Nome = ((Banco)bancoBindingSource.Current).Nome;
                    Close();
                }
                else
                    MessageBox.Show("Não existe um Banco para ser selecionado.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            bancoBindingSource.DataSource = new BancoBLL().BuscarTodos();
        }

        private void textBoxConsultarBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(filtro != textBoxConsultarBanco.Text)
                {
                    buttonBuscarBanco_Click(null, null);
                    filtro = textBoxConsultarBanco.Text;

                }
                else
                {
                    buttonSelecionarBanco_Click(null,null);
                }
            }
             else if (e.KeyCode == Keys.Up)
            {
                bancoBindingSource.MovePrevious();
                e.Handled = true;
            }
            else if(e.KeyCode == Keys.Down)
            {
                bancoBindingSource.MoveNext();
                e.Handled = true;
            }
        }
    }
}
