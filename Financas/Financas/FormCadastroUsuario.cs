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
    public partial class FormCadastroUsuario : Form
    {
        public int Id;
        public FormCadastroUsuario(int id=0)
        {
            InitializeComponent();
            Id = id;
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelarCadastrodeUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
