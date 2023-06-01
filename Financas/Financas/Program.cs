using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using infra;
using Models;

namespace Financas
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<string> list = new Arquivo().LerLinhasArquivo("C:\\Users\\vsistema\\Documents\\TRABALHO FINANCIAS\\TEC.2022.1.108.Financas-pessoais\\Financas\\Financas\\bin\\Debug\\Logs\\Log20230601.Log", true);

            // string texto = "123";
            // texto = new infra.criptografia().CriptografarSenha(texto);

            Log.Gravar("Usuário abriu o sistema. ");
            Application.Run(new FormPrincipal());

            try
            {
                if (Constantes.DiretorioStringConexao != "C:\\Configuracoes\\")
                {
                    using (FormConexao frm = new FormConexao())
                    {
                        frm.ShowDialog();
                    }
                }
                else
                    using(FormLogin form = new FormLogin())
                    {
                        form.ShowDialog();
                    }
                    if (!File.Exists(Environment.CurrentDirectory + "\\ProjetoFundo.png"))
                {
                    throw new Exception("Não foi encontrado o arquivo: " + Environment.CurrentDirectory + "\\ProjetoFundo.png");
                }
                Application.Run(new FormPrincipal());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
