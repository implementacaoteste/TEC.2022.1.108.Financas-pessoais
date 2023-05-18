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
        private void ValidarDados(ContasReceber _contasReceber)
        {
            _contasReceber.Descricao = _contasReceber.Descricao.Trim();
            if (_contasReceber.Descricao == null || _contasReceber.Descricao.Trim().Length <= 4)
                throw new Exception("A descrição precisa ter 5 ou mais caracteres");// { Data = { { "Id", 0 } } };
        }
        public void Inserir(ContasReceber _contasReceber)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            ValidarDados(_contasReceber);
            new ContasReceberDAL().Inserir(_contasReceber);
        }
        public void Alterar(ContasReceber _contasReceber)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            ValidarDados(_contasReceber);
            new ContasReceberDAL().Alterar(_contasReceber);
        }
        public void Excluir(int _id)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
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
            if (_periodoInicial > _periodoFinal)
                throw new Exception("Data inicial não pode ser maior que a data final");

            return new ContasReceberDAL().BuscarPorPeriodo(_periodoInicial, _periodoFinal);
        }
        public List<ContasReceber> BuscarPagamento(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            if (_periodoInicial > _periodoFinal)
                throw new Exception("Data inicial não pode ser maior que a data final");

            return new ContasReceberDAL().BuscarPagamento(_periodoInicial, _periodoFinal);
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

        public void EstornarBaixa(ContasReceber _contasReceber)
        {
            if (_contasReceber.DataPagamento == null)
                throw new Exception("Este registro ainda não foi pago!");

            new ContasReceberDAL().EstornarBaixa(_contasReceber);
        }
    }
}
