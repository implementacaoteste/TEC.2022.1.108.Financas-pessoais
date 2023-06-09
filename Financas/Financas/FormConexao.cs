
﻿using BLL;
using infra;
using Models;
﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Financas
{
    public partial class FormConexao : Form
    {
        public bool CriouConexao;
        public FormConexao()
        {
            InitializeComponent();
            CriouConexao = false;
        }

        private void FormConexao_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo.png");
            this.label1.ForeColor = SystemColors.Control;

        }

        private void textBoxServidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBanco_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxServidor.Text))
                {
                    MessageBox.Show("Informe o nome do servidor");
                    textBoxServidor.Focus();
                    return;
                }

                string conexao = "User ID=" + textBoxNomeUsuario.Text + ";Initial Catalog=" + textBoxBanco.Text + ";Data Source =" + textBoxServidor.Text + ";Password=" + textBoxSenha.Text;

                new TesteBLL().TestarConexao(conexao);

                new Arquivo().GravarLinhaNoFinalDoArquivo(Constantes.DiretorioStringConexao + Constantes.NomeArquivoConexao, new Criptografia().Criptografar(conexao));
                CriouConexao = true;
                MessageBox.Show("Conexão salva com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormConexao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
                buttonSair_Click(sender, e);
            }
        }
    }
}
