using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DespesasBLL
    {
        public void Inserir(Despesas _despesas)
        {
            new DespesasDAL().Inserir(_despesas);
        }
        public void Alterar(Despesas _despesas)
        {
            new DespesasDAL().Alterar(_despesas);
        }
        public void Excluir(int _id)
        {
            new DespesasDAL().Excluir(_id);
        }
    }
}
