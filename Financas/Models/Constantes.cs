using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Constantes
    {
        public static int IdUsuarioLogado;
        public static string NomeUsuarioLogado;
        public static string DiretorioStringConexao = "C:\\Configuracoes\\";
        public static string CaminhoChavePublica = "C:\\Configuracoes\\ChavePublica.txt";
        public static string CaminhoChavePrivada = "C:\\Configuracoes\\ChavePrivada.txt";
        public static string NomeArquivoConexao = "configuracoesConnection.config";


        public static string NomeUsuarioSuporte { get { return "Suporte"; } }
        public static string SenhaSuporte
        {
            get
            {
                return Convert.ToString(DateTime.Now.Day * 40 + DateTime.Now.Year);
            }
        }

        public static string CaminhoArquivoLog 
        { 
            get 
            {
                string diretorio = Environment.CurrentDirectory + "\\Logs\\";
                Directory.CreateDirectory(diretorio);
                return diretorio + "Log" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + ".Log";
            } 
        }
    }
}
