using BLL;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Financas
{
    public partial class FormLogin : Form
    {
        public bool Logou;
        private bool altenticacaoInicial;

        public FormLogin(bool _altenticacaoInicial = true)
        {
            InitializeComponent();
            Logou = false;
            altenticacaoInicial = _altenticacaoInicial;
        }

        private void buttonsair_Click(object sender, EventArgs e)
        {
            if (altenticacaoInicial)
                Application.Exit();
            else
                Close();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().Altenticar(textBoxUsuario.Text, textBoxSenhaLogin.Text, altenticacaoInicial);
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
            if (checkBoxMostrarSenha.Checked)
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
                if (altenticacaoInicial)
                    Application.Exit();
                else
                    Close();


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
            else if (e.KeyCode == Keys.F1)
                linkLabel1_LinkClicked(null, null);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://rosadcti.github.io/Web_Financas/index.html");


            //https:/finanaspessoais1.durable.co/?pt=NjQ1NDIzMzI2ZDZlNTU4OTM2OWFiMTdlOjE2ODM1Njc4NzguNTk1OnByZXZpZXc=
            //https:/www.youtube.com/watch?v=P3KYR-HZmu0
        }

        private void buttonEntrar_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_MouseLeave(object sender, EventArgs e)
        {


        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
        }

      
   
    }
}
