using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContasReceberBLL
    {
        public void Inserir(ContasReceber _contasReceber)
        {
            new ContasReceberDAL().Inserir(_contasReceber);
        }
        public void Alterar(ContasReceber _contasReceber)
        {
            new ContasReceberDAL().Alterar(_contasReceber);
        }
        public void Excluir(int _id)
        {
            new ContasReceberDAL().Excluir(_id);
        }
        public List<ContasReceber> BuscarTodos()
        {
            return new ContasReceberDAL().BuscarTodos();
        }
        public List<ContasReceber> BuscarPorDescricao(string _descricao)
        {
            return new ContasReceberDAL().BuscarPorDescricao(_descricao);
        }
        public void BuscarPorId(int _id)
        {
            new ContasReceberDAL().BuscarPorId(_id);
        }
    }
}
