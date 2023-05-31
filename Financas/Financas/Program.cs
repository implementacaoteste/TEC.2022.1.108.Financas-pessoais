using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using infra;

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
           // new Criptografia().GerarChaves();

            // string texto = "123";
            // texto = new infra.criptografia().CriptografarSenha(texto);

            Log.Gravar("o usuario abriu o sistema");
            Application.Run(new FormPrincipal());

            try
            {
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
