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
        public FormCadastroContato(int id=0)
        {
            InitializeComponent();
            Id = id;
        }

        private void buttonSalvarCadastroContato_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelarCadastroContato_Click(object sender, EventArgs e)
        {
            Close();
           
        }
    }
}
