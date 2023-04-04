﻿using Models;
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

namespace Financas
{
    public partial class FormConsultaDespesas : Form
    {
        public FormConsultaDespesas()
        {
            InitializeComponent();
        }

        private void despesasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
              despesasBindingSource.DataSource = new DespesasBLL().BuscarTodos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            using (FormConsultaDespesas frm = new FormConsultaDespesas())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }
    }
}
