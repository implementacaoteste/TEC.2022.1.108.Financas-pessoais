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
    public partial class FormCadastroUsuario : Form
    {
        public int Id;

        public FormCadastroUsuario(int id = 0)
        {
            InitializeComponent();
            Id = id;

        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {

            if (Id == 0)
                usuarioBindingSource.AddNew();
            else
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(Id);
        }

        private void buttonCancelarCadastrodeUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvarCadastrodeUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.EndEdit();

                if (Id == 0)
                    usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, textBoxConfirmarSenhaCadastroUsuario.Text);
                else
                    usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current);
                MessageBox.Show("Registro salvo com sucesso");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroUsuario_Load_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
            try
            {
                this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo.png");
                if (Id == 0)
                {
                    usuarioBindingSource.AddNew();
                    ativoCheckBox.Checked = true;
                }
                else

                    usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void FormCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void textBoxNomeCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxSenhaCadastroUsuario.Focus();
        }

        private void textBoxSenhaCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxNomeUsuarioCadastroUsuario.Focus();
        }

        private void textBoxNomeUsuarioCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxConfirmarSenhaCadastroUsuario.Focus();
        }

        private void textBoxConfirmarSenhaCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxRendaCadastroUsuario.Focus();
        }

        private void textBoxRendaCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                buttonSalvarCadastrodeUsuario_Click(null, null);
        }

        private void ativoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
