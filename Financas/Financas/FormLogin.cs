using BLL;
using System;
using System.Drawing;
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
                textBoxSenhaLogin.Text = "";
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
                {
                    buttonEntrar_Click(null, null);
                    return;
                }

                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://finanaspessoais1.durable.co/?pt=NjQ1NDIzMzI2ZDZlNTU4OTM2OWFiMTdlOjE2ODM1Njc4NzguNTk1OnByZXZpZXc=");


            //https:/finanaspessoais1.durable.co/?pt=NjQ1NDIzMzI2ZDZlNTU4OTM2OWFiMTdlOjE2ODM1Njc4NzguNTk1OnByZXZpZXc=
            //https:/www.youtube.com/watch?v=P3KYR-HZmu0
        }
    }
}
