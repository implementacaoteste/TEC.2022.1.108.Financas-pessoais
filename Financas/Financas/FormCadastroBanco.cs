using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace Financas
{
    public partial class FormCadastroBanco : Form
    {
        public int Id;
        public FormCadastroBanco(int id=0)
        {
            InitializeComponent();
            Id = id;
         
        }

          private void buttonCancelarCadBanco_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvarCadBanco_Click(object sender, EventArgs e)
        {          
            BancoBLL BancoBLL = new BancoBLL();
            bancoBindingSource.EndEdit();

            if (Id == 0)
                BancoBLL.Inserir((Banco)bancoBindingSource.Current);
            else
                BancoBLL.Alterar((Banco)bancoBindingSource.Current);

            MessageBox.Show("Registro salvo com sucesso");
            Close();
        }

        private void FormCadastroBanco_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                bancoBindingSource.AddNew();
                ativoCheckBox.Checked = true;
            }
            else
                bancoBindingSource.DataSource = new BancoBLL().BuscarPorId(Id);

            this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\ProjetoFundo.png");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
        }

        private void FormCadastroBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void nomeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                poupancaTextBox.Focus();
            }
        }

        private void poupancaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSalvarCadBanco_Click(null,null);
            }
        }

        private void ativoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
