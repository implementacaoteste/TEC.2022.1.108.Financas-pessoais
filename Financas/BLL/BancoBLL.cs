using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BancoBLL
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
            int id = new BancoDAL().ValidarMovimentacaoBanco(_id).Id;

            if (id != 0)
                throw new Exception("Registro não pode ser excluido porque existe histórico de movimentação");

            new BancoDAL().Excluir(_id);
        }
        public List<Banco> BuscarTodos()
        {
            return new BancoDAL().BuscarTodos();
        }
        public List<Banco> BuscarPorNome(string _nome)
        {
            return new BancoDAL().BuscarPorNome(_nome);
        }
        public Banco BuscarPorId(int _id)
        {
            return new BancoDAL().BuscarPorId(_id);
        }

        public List<Banco> BuscarPorInativo(string _Inativo)
        {
            return new BancoDAL().BuscarPorInativo(_Inativo);
        }
    }
}
