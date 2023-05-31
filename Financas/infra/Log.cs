using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using infra;

namespace infra
{
    public class Log
    {
        public static void Gravar(string _texto)
        {
            new Arquivo().GravarLinhaNoFinalDoArquivo(Constantes.CaminhoArquivo, new Criptografia().Criptografar(DateTime.Now + ": " + _texto));
        }
    }
}
