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
        public void BuscarPorId(int _id)
        {
            new BancoDAL().BuscarPorId(_id);
        }
    }
}
