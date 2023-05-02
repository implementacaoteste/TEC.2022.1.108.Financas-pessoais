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
    public partial class FormCadastroContato : Form
    {
        public int Id;
        public FormCadastroContato(int id = 0)
        {
            InitializeComponent();
            Id = id;
        }

        private void buttonSalvarCadastroContato_Click(object sender, EventArgs e)
        {
            try
            {
                ContatoBLL contatoBLL = new ContatoBLL();
                contatoBindingSource.EndEdit();
                if (Id == 0)
                    contatoBLL.Inserir((Contato)contatoBindingSource.Current);
                else
                    contatoBLL.Alterar((Contato)contatoBindingSource.Current);
                MessageBox.Show("Registro salvo com sucesso");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex. Message);
            }
        }

        private void buttonCancelarCadastroContato_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void FormCadastroContato_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                contatoBindingSource.AddNew();
            else
                contatoBindingSource.DataSource = new ContatoBLL().BuscarPorId(Id);
            this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo.png");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
        }

        private void FormCadastroContato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void nomeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                numeroTextBox.Focus();
        }

        private void numeroTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                enderecoTextBox.Focus();
        }

        private void enderecoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                descricaoTextBox.Focus();
        }

        private void descricaoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                /* if (MessageBox.Show("Deseja realmente Sal este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                     return;*/
                buttonSalvarCadastroContato_Click(null, null);
        }

        private void ativoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ativoCheckBox.Checked = true;
        }
    }
}
