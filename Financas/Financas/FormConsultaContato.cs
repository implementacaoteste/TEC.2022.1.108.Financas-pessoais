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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Financas
{
    public partial class FormConsultaContato : Form
    {
        public int Id;
        public string Nome;
        private string filtro;
        public FormConsultaContato(bool _selecionar = false)
        {
            InitializeComponent();

            buttonSelecionarContato.Visible = _selecionar;

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscar.SelectedIndex)
                {
                    case 0:
                        contatoBindingSource.DataSource = new ContatoBLL().BuscarTodos();
                        break;
                    case 1:
                        contatoBindingSource.DataSource = new ContatoBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        contatoBindingSource.DataSource = new ContatoBLL().BuscarPorEndereco(textBoxBuscar.Text);
                        break;
                    case 3:
                        contatoBindingSource.DataSource = new ContatoBLL().BuscarPorNumero(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 4:
                        contatoBindingSource.DataSource = new ContatoBLL().BuscarPorDescricao(textBoxBuscar.Text);
                        break;
                    case 5:
                        contatoBindingSource.DataSource = new ContatoBLL().BuscarPorInativo(textBoxBuscar.Text);
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

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            using (FormCadastroContato frm = new FormCadastroContato())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (contatoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Contato)contatoBindingSource.Current).Id;
                new ContatoBLL().Excluir(id);
                contatoBindingSource.RemoveCurrent();

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

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((Contato)contatoBindingSource.Current).Id;
            using (FormCadastroContato frm = new FormCadastroContato(id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }
        private void buttonSelecionarContato_Click(object sender, EventArgs e)
        {
            try
            {
                if (contatoBindingSource.Count > 0)
                {
                    if (!((Contato)contatoBindingSource.Current).Ativo)
                        throw new Exception("Este contato está inativo.Você precisa ativá-lo ou escolher outro contato");
                    Id = ((Contato)contatoBindingSource.Current).Id;
                    Nome = ((Contato)contatoBindingSource.Current).Nome;
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

        private void FormConsultaContato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void FormConsultaContato_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo2.png");
            comboBoxBuscar.SelectedIndex = 1;
        }

        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (filtro != textBoxBuscar.Text)
                {
                    buttonBuscar_Click(null, null);
                    filtro = textBoxBuscar.Text;
                }
                else
                {
                    buttonSelecionarContato_Click(null, null);
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                contatoBindingSource.MovePrevious();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                contatoBindingSource.MoveNext();
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contatoDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSelecionarContato_Click(null, null);

            e.Handled = true;
        }

        private void contatoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            buttonSelecionarContato_Click(null, null);
        }
    }
}
