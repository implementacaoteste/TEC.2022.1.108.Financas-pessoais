using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ContasPagar
    {
        public int Id { get; set; }
        public double ValorPagar { get; set; }
        public string Descricao { get; set; }
        public string Contato { get; set; }
        public int IdContato { get; set; }
    }
}
