using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Banco
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double Poupanca { get; set; }
        public bool Ativo { get; set; }
        public bool PermitirSaldoNegativo { get; set; }
    }
}
