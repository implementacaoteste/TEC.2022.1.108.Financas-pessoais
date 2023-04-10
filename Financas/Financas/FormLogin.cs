using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private void labelUsuarioLogin_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
    }
}
