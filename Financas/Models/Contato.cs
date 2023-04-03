﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Descricao { get; set; }
        public List<Contato> Contatos { get; set; }
    }
}
