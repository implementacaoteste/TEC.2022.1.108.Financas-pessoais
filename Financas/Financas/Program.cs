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

            // string texto = "123";
            // texto = new infra.criptografia().CriptografarSenha(texto);

           // new Criptografia().GravarChaves();

            Log.Gravar("Usuario abriu o sistema");
            Application.Run(new FormPrincipal());

            try
            {
                if (!File.Exists(Environment.CurrentDirectory + "\\ProjetoFundo.png"))
                {
                    throw new Exception("Não foi encontrado o arquivo: " + Environment.CurrentDirectory + "\\ProjetoFundo.png");
                }
                Application.Run(new FormPrincipal());
                
                List<string> list = new Arquivo().LerLinhasArquivos(Constantes.CaminhoArquivo, true);
                list.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
