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
            //new Criptografia().GravarChaves();
            Log.Gravar("Usuário abriu o sistema. ");
            List<string> list = new Arquivo().LerLinhasArquivo(Models.Constantes.CaminhoArquivoLog, true);
            // string texto = "123";
            // texto = new infra.criptografia().CriptografarSenha(texto);

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
