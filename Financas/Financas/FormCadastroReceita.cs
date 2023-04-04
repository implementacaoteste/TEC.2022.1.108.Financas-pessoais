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
    public partial class FormCadastroReceita : Form
    {
        public FormCadastroReceita()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
                try
                {
                    ReceitaBLL receitaBLL = new ReceitaBLL();
                    receitaBindingSource.EndEdit();

                    receitaBLL.Inserir((Receita)receitaBindingSource.Current);
                }
                catch
                {
                    MessageBox.Show("Registro salvo com sucesso!");
                }
                finally
                {
                    Close();
                }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
