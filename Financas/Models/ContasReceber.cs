using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ContasReceber
    {
        public int Id { get; set; }
        public double ValorReceber { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string Contato { get; set; }
        public int IdContato { get; set; }
        public string Banco { get; set; }
        public int IdBanco { get; set; }
        public string FormaPagamento { get; set; }
        public int IdFormaPagamento { get; set; }
    }
}
