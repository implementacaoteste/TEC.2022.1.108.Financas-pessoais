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
        private void ValidarDados(ContasPagar _contasPagar)
        {
            if (_contasPagar.Descricao == null || _contasPagar.Descricao.Trim().Length <= 4)
                throw new Exception("A descrição deve ter 5 ou mais caracteres") { Data = { { "Id", 0 } } }; 
            _contasPagar.Descricao = _contasPagar.Descricao.Trim(); 

            if (_contasPagar.ValorPagar <= 0)
                throw new Exception("Informe o valor") { Data = { { "Id", 1 } } }; 
        }
        public void Inserir(ContasPagar _contasPagar)
        {
            ValidarDados(_contasPagar);
            new ContasPagarDAL().Inserir(_contasPagar);
        }
        public void Alterar(ContasPagar _contasPagar)
        {
            ValidarDados(_contasPagar);
            new ContasPagarDAL().Alterar(_contasPagar);
        }
        public void Excluir(int _id)
        {
            if (new ContasPagarDAL().BuscarPorId(_id).DataPagamento != null)
                throw new Exception("Esta conta ja foi paga!\nPrecisa fazer o estorno para realizar a exlusão");
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
        public List<ContasPagar> BuscarPorEmissao(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            if (_periodoInicial > _periodoFinal)
                throw new Exception("Data inicial não pode ser maior que a data final");

            return new ContasPagarDAL().BuscarPorEmissao(_periodoInicial, _periodoFinal);
        }
        public List<ContasPagar> BuscarPagamento(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            if (_periodoInicial > _periodoFinal)
                throw new Exception("Data inicial não pode ser maior que a data final");

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
