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
    public partial class FormCadastroUsuario : Form
    {
        public int Id;
        public FormCadastroUsuario(int id=0)
        {
            InitializeComponent();
            Id = id;
        }

        private void FormCadastroUsuario_Load(string _nome)
        {

            if (Id == 0)
                usuarioBindingSource.AddNew();
            else
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorNome(_nome);
        }

        private void buttonCancelarCadastrodeUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvarCadastrodeUsuario_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.EndEdit();

            if (Id == 0)
                usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current);
            else 
                usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current);
            MessageBox.Show("Registro salvo com sucesso");
            Close();
        }
    }
}
