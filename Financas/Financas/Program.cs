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
            try
            {
                if (!File.Exists(Constantes.CaminhoChavePublica) || !File.Exists(Constantes.CaminhoChavePrivada))
                    throw new Exception("A chave pulica e/ou privada não foi encontrada.\nEntre em contato com o seu administrador de sistema");

                Log.Gravar("Usuário abriu o sistema. ");
                //List<string> list = new Arquivo().LerLinhasArquivo(Models.Constantes.CaminhoArquivoLog, true);
                // string texto = "123";
                // texto = new infra.criptografia().CriptografarSenha(texto);


                if (!File.Exists(Environment.CurrentDirectory + "\\ProjetoFundo.png"))
                    throw new Exception("Não foi encontrado o arquivo: " + Environment.CurrentDirectory + "\\ProjetoFundo.png");


                if (!File.Exists(Constantes.DiretorioStringConexao + Constantes.NomeArquivoConexao))
                    using (FormConexao frm = new FormConexao())
                    {
                        frm.ShowDialog();
                        if (frm.CriouConexao)
                            Application.Run(new FormPrincipal());
                    }
                else
                    Application.Run(new FormPrincipal());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
