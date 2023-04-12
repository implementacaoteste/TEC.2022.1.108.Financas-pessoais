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
        public ContasReceber BuscarPorId(int _id)
        {
            return new ContasReceberDAL().BuscarPorId(_id);
        }
        public List<ContasReceber> BuscarPorPeriodo(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            return new ContasReceberDAL().BuscarPorPeriodo(_periodoInicial, _periodoFinal);
        }
        public List<ContasReceber> BuscarPorContato(string _contato)
        {
            return new ContasReceberDAL().BuscarPorContato(_contato);
        }
        public List<ContasReceber> BuscarPorFormaPagamento(string _formaPagamento)
        {
            return new ContasReceberDAL().BuscarPorFormaPagamento(_formaPagamento);
        }
        public List<ContasReceber> BuscarPorBanco(string _banco)
        {
            return new ContasReceberDAL().BuscarPorBanco(_banco);
        }
    }
}
