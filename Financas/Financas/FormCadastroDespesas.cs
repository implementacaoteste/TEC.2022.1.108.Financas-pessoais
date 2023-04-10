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
        public  int Id;
        public FormCadastroDespesas(int id=0)
        {
            InitializeComponent();
            Id = id;
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

        private void FormCadastroDespesas_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                despesasBindingSource.AddNew();
            else
                despesasBindingSource.DataSource = new DespesasBLL().BuscarTodos();
        }

        private void buttonBuscarContatoDespesas_Click(object sender, EventArgs e)
        {
            using(FormConsultaContato frm = new FormConsultaContato())
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            using(FormConsultaBanco frm = new FormConsultaBanco())
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscarFormaPagamentoDespesas_Click(object sender, EventArgs e)
        {
            using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento())
            {
                frm.ShowDialog();
            }
        }
    }
}
