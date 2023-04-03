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
        public void Inserir(ContasPagar _contasPagar)
        {
            new ContasPagarDAL().Inserir(_contasPagar);
        }
        public void Alterar(ContasPagar _contasPagar)
        {
            new ContasPagarDAL().Alterar(_contasPagar);
        }
        public void Excluir(int _id)
        {
            new ContasPagarDAL().Excluir(_id);
        }
        public List<ContasPagar> BuscarTodos()
        {
            return new ContasPagarDAL().BuscarTodos();
        }
        public List<ContasPagar> BuscarPorDescricao(string _descricao)
        {
            return new ContasPagarDAL().BuscarPorDescricao(_descricao);
        }
        public void BuscarPorId(int _id)
        {
            new ContasPagarDAL().BuscarPorId(_id);
        }
    }
}
