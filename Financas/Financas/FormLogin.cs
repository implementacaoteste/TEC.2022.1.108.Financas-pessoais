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
               
        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                 Application.Exit();
                

            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxSenhaLogin.Focused)
                    buttonEntrar_Click(null, null);

                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
