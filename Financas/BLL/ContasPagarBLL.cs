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
        public List<ContasPagar> BuscarPorPeriodo(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            return new ContasPagarDAL().BuscarPorPeriodo(_periodoInicial, _periodoFinal);
        }
        public List<ContasPagar> BuscarPagamento(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            return new ContasPagarDAL().BuscarPagamento(_periodoInicial, _periodoFinal);
        }
        public List<ContasPagar> BuscarPorContato(string _contato)
        {
            return new ContasPagarDAL().BuscarPorContato(_contato);
        }
        public List<ContasPagar> BuscarPorFormaPagamento(string _formaPagamento)
        {
            return new ContasPagarDAL().BuscarPorFormaPagamento(_formaPagamento);
        }
        public List<ContasPagar> BuscarPorBanco(string _banco)
        {
            return new ContasPagarDAL().BuscarPorBanco(_banco);
        }
        public void EstornarBaixa(ContasPagar _contasPagar)
        {
            if (_contasPagar.DataPagamento == null)
                throw new Exception("Este registro ainda não foi pago!");

            new ContasPagarDAL().EstornarBaixa(_contasPagar);
        }
    }
}
