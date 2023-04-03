using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Receita
    {
        public int Id { get; set; }
        public float Ganhos { get; set; }
        public string Descricao { get; set; }
        public List<Receita> Receitas { get; set; }
    }
}
