using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContasPagarBLL
    {
        public void Inserir(Banco _banco)
        {
            new BancoDAL().Inserir(_banco);
        }
        public void Alterar(Banco _banco)
        {
            new BancoDAL().Alterar(_banco);
        }
        public void Excluir(int _id)
        {
            new BancoDAL().Excluir(_id);
        }
    }
}
