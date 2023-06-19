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
    public partial class FormConsultaUsuario : Form
    {
        public FormConsultaUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorNome(textBoxBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroUsuario frm = new FormCadastroUsuario())
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuarioBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro a ser alterado");
                    return;
                }
                if (Constantes.IdUsuarioLogado != ((Usuario)usuarioBindingSource.Current).Id)
                    if (MessageBox.Show("Você não pode alterar os dados de outro usuário. Deseja alterar os seus próprios dados", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;

                MessageBox.Show("Para continuar você precisa confirmar sua identidade.");
                Close();
                using (FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                }

                using (FormCadastroUsuario frm = new FormCadastroUsuario(Constantes.IdUsuarioLogado))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuarioBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Usuario)usuarioBindingSource.Current).Id;
                new UsuarioBLL().Excluir(id);
                usuarioBindingSource.RemoveCurrent();

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

        private void FormConsultaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormConsultaUsuario_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo2.png");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
        }

        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                usuarioBindingSource.MovePrevious();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                usuarioBindingSource.MoveNext();
                e.Handled = true;
            }
        }
    }
}
