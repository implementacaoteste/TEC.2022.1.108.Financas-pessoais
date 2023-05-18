using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FormaPagamentoBLL
    {
        private void ValidarDados(FormaPagamento _formaPagamento)
        {
            if (_formaPagamento.Descricao == null || _formaPagamento.Descricao.Trim().Length <= 2)
                throw new Exception("A forma de pagamento deve possuir 3 ou mais caracteres.");
        }
        public void Inserir(FormaPagamento _formaPagamento)
        {
            _formaPagamento.Descricao = _formaPagamento.Descricao.Trim();
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            if (_formaPagamento.Descricao.Length < 3)
                throw new Exception("O campo descrição deve ter mais que dois caracteres!") { Data = { { "Id", 0 } } };
            ValidarDados(_formaPagamento);
            new FormaPagamentoDAL().Inserir(_formaPagamento);
        }
        public void Alterar(FormaPagamento _formaPagamento)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            ValidarDados(_formaPagamento);
            new FormaPagamentoDAL().Alterar(_formaPagamento);
        }
        public void Excluir(int _id)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            int id = new FormaPagamentoDAL().ValidarMovinteçãoFormaPagamento(_id).Id;
            if (id != 0)
                throw new Exception("Registro não pode ser excluido porque existe histórico de movimentação.");

            new FormaPagamentoDAL().Excluir(_id);
        }
        public List<FormaPagamento> BuscarTodos()
        {
            return new FormaPagamentoDAL().BuscarTodos();
        }
        public List<FormaPagamento> BuscarPorDescricao(string _descricao)
        {
            return new FormaPagamentoDAL().BuscarPorDescricao(_descricao);
        }
        public FormaPagamento BuscarPorId(int _id)
        {
            return new FormaPagamentoDAL().BuscarPorId(_id);
        }

        public object BuscarPorInativo(string _Inativo)

        {
            return new FormaPagamentoDAL().BuscarPorInativo(_Inativo);
        }
    }
}
