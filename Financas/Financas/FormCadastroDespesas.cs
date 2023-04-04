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
    public partial class FormCadastroDespesas : Form
    {
        public FormCadastroDespesas()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DespesasBLL despesasBLL = new DespesasBLL();
                despesasBindingSource.EndEdit();

                despesasBLL.Inserir((Despesas)despesasBindingSource.Current);
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
