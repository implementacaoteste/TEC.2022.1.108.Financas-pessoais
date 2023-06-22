using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReceitaBLL
    {
        private void ValidarDados(Receita _receita)
        {
            if (_receita.Descricao == null || _receita.Descricao.Trim().Length < 3)
                throw new Exception("O campo descrição deve ter mais que dois caracteres!") { Data = { { "Id", 0 } } };

            _receita.Descricao = _receita.Descricao.Trim();

            if (_receita.Valor <= 0)
                throw new Exception("Informe o valor") { Data = { { "Id", 1 } } };
        }
        public void Inserir(Receita _receita, ContasReceber _contasReceber = null)
        {
            if (_contasReceber != null && _contasReceber.DataPagamento != null && _contasReceber.DataPagamento.Value.Year > 2000)
                throw new Exception("Este registro já foi pago!");
            ValidarDados(_receita);
            new ReceitaDAL().Inserir(_receita, _contasReceber);
        }
        public void Alterar(Receita _receita)
        {
            ValidarDados(_receita);
            new ReceitaDAL().Alterar(_receita);
        }
        public void Excluir(int _id)
        {
            int idContasReceber = new ReceitaDAL().BuscarPorId(_id).IdContasReceber;

            if (idContasReceber != 0)
                throw new Exception("Registro não pode ser excluido, porque é preciso estornar o registro de contas a receber de id: " + idContasReceber);

            new ReceitaDAL().Excluir(_id);
        }
        public SituacaoFinanceira BuscarSituacaoFinanceiraTodos()
        {
            return new ReceitaDAL().BuscarSituacaoFinanceiraTodos();
        }
        public SituacaoFinanceira BuscarSituacaoFinanceiraEmissao(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            return new ReceitaDAL().BuscarSituacaoFinanceiraEmissao(_periodoInicial, _periodoFinal);
        }
        public SituacaoFinanceira BuscarSituacaoFinanceiraContato(string _contato)
        {
            return new ReceitaDAL().BuscarSituacaoFinanceiraContato(_contato);
        }
        public SituacaoFinanceira BuscarSituacaoFinanceiraFormaPagamento(string _formaPagamento)
        {
            return new ReceitaDAL().BuscarSituacaoFinanceiraFormaPagamento(_formaPagamento);
        }
        public SituacaoFinanceira BuscarSituacaoFinanceiraBanco(string _banco)
        {
            return new ReceitaDAL().BuscarSituacaoFinanceiraBanco(_banco);
        }
        public SituacaoFinanceira BuscarSituacaoFinanceiraDescricao(string _descricao)
        {
            return new ReceitaDAL().BuscarSituacaoFinanceiraDescricao(_descricao);
        }
        public List<Receita> BuscarTodos()
        {
            return new ReceitaDAL().BuscarTodos();
        }
        public List<Receita> BuscarPorDescricao(string _descricao)
        {
            return new ReceitaDAL().BuscarPorDescricao(_descricao);
        }
        public Receita BuscarPorId(int _id)
        {
            return new ReceitaDAL().BuscarPorId(_id);
        }
        public List<Receita> BuscarPorEmissao(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            if (_periodoInicial > _periodoFinal)
                throw new Exception("Data inicial não pode ser maior que a data final");

            return new ReceitaDAL().BuscarPorEmissao(_periodoInicial, _periodoFinal);
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
