using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace infra
{
    public static class Log
    {
        public static void Gravar(string _texto)
        {
            new Arquivo().GravarLinhaNoFinalDoArquivo(Constantes.CaminhoArquivoLog, new Criptografia().Criptografar(DateTime.Now + ": " + _texto));
        }
    }
}
