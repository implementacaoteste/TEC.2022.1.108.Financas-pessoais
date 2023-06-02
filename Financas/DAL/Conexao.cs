using infra;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexao
    {
        private static string stringDeConexao;
        public static string StringDeConexao
        {
            get
            {
                if (String.IsNullOrEmpty(stringDeConexao))
                    if (File.Exists(Constantes.DiretorioStringConexao + Constantes.NomeArquivoConexao))
                        stringDeConexao = new Criptografia().Descriptografar(File.ReadAllText(Constantes.DiretorioStringConexao + Constantes.NomeArquivoConexao));
                    else throw new Exception("Você precisa criar a conexão com o banco de dados");

                return stringDeConexao;
            }
        }
    }
    //ESXPRESS2019
    //Senailab02
}
