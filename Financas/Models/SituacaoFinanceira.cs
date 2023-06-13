using System.Collections.Generic;

namespace Models
{
    public class SituacaoFinanceira
    {
        public double TotalReceita { get; set; }
        public double TotalDespesa { get; set; }
        public double Saldo { get { return TotalReceita - TotalDespesa; } }
        public List<Receita> Receitas { get; set; }
        public List<Despesas> Despesas { get; set; }
    }
}
