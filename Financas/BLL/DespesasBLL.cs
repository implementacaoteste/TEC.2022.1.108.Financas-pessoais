using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DespesasBLL
    {
        public void Inserir(Despesas _despesas, ContasPagar _contasPagar = null)
        {
            _despesas.Descricao = _despesas.Descricao.Trim();

            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            if (_contasPagar != null && _contasPagar.DataPagamento != null && _contasPagar.DataPagamento.Value.Year > 2000)
                throw new Exception("Este registro já foi pago!");
            if (_despesas.Descricao.Length < 3)
                throw new Exception("O campo descrição deve ter mais que dois caractéres.") { Data = { { "Id", 0 } } };

            ValidarSaldo(_despesas.Valor, _despesas.IdBanco);

            new DespesasDAL().Inserir(_despesas, _contasPagar);
        }
        public void Alterar(Despesas _despesas)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            new DespesasDAL().Alterar(_despesas);
        }
        public void Excluir(int _id)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            int idContasPagar = new DespesasDAL().BuscarPorId(_id).IdContasPagar;

            if (idContasPagar != 0)
                throw new Exception("Registro não pode ser excluido, porque é preciso estornar o registro de contas a pagar de id: " + idContasPagar);

            new DespesasDAL().Excluir(_id);
        }
        public List<Despesas> BuscarTodos()
        {
            return new DespesasDAL().BuscarTodos();
        }
        public List<Despesas> BuscarPorDescricao(string _descricao)
        {
            return new DespesasDAL().BuscarPorDescricao(_descricao);
        }
        public Despesas BuscarPorId(int _id)
        {
            return new DespesasDAL().BuscarPorId(_id);
        }
        public List<Despesas> BuscarPorBanco(string _banco)
        {
            return new DespesasDAL().BuscarPorBanco(_banco);
        }
        public List<Despesas> BuscarPorFormaPagamento(string _formaPagamento)
        {
            return new DespesasDAL().BuscarPorFormaPagamento(_formaPagamento);
        }
        public List<Despesas> BuscarPorContato(string _contato)
        {
            return new DespesasDAL().BuscarPorContato(_contato);
        }
        public List<Despesas> BuscarPorPeriodo(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            if (_periodoInicial > _periodoFinal)
                throw new Exception("Data inicial não pode ser maior que a data final");

            return new DespesasDAL().BuscarPorPeriodo(_periodoInicial, _periodoFinal);
        }

        public void ValidarSaldo(double _valor, int _idBanco)
        {
            Banco banco = new BancoDAL().BuscarPorId(_idBanco);

            if (!banco.PermitirSaldoNegativo && banco.Saldo < _valor)
                throw new Exception("Este banco não possui saldo suficiente.");
        }
    }
}
