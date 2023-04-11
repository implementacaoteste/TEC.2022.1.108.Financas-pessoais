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
        public ContasPagar BuscarPorId(int _id)
        {
            return new ContasPagarDAL().BuscarPorId(_id);
        }
        public List<Receita> BuscarPorPeriodo(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            return new ReceitaDAL().BuscarPorPeriodo(_periodoInicial, _periodoFinal);
        }
        public List<Receita> BuscarPorContato(string _contato)
        {
            return new ReceitaDAL().BuscarPorContato(_contato);
        }
        public List<Receita> BuscarPorFormaPagamento(string _formaPagamento)
        {
            return new ReceitaDAL().BuscarPorFormaPagamento(_formaPagamento);
        }
        public List<Receita> BuscarPorBanco(string _banco)
        {
            return new ReceitaDAL().BuscarPorBanco(_banco);
        }
    }
}
