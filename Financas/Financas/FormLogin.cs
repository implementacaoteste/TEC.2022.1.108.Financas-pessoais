using BLL;
using System;
using System.Windows.Forms;

namespace Financas
{
    public partial class FormLogin : Form
    {
        public bool Logou;
        public FormLogin()
        {
            InitializeComponent();
            Logou = false;
        }

        private void buttonsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Close();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().Altenticar(textBoxUsuario.Text, textBoxSenhaLogin.Text);
                Logou = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonCdastraLogin_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            } 
        }
        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMostrarSenha.Checked)
            {
                textBoxSenhaLogin.PasswordChar = '\u0000';
            }
            else
            {
                textBoxSenhaLogin.PasswordChar = '*';
            }
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
