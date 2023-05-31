using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Constantes
    {
        public static int IdUsuarioLogado;
        public static string NomeUsuarioLogado;

        public static string NomeUsuarioSuporte { get { return "Suporte"; } }
        public static string SenhaSuporte
        {
            get
            {
                return Convert.ToString(DateTime.Now.Month * 40 + DateTime.Now.Year);
            }
        }
    }
}
