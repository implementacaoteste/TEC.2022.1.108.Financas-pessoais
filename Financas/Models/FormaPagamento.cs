﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FormaPagamento
    {
        public int Id { get; set; } 
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
