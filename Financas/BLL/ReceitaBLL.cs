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
        public void Inserir(Receita _receita, ContasReceber _contasReceber = null)
        {
            if (_contasReceber != null && _contasReceber.DataPagamento != null && _contasReceber.DataPagamento.Value.Year > 2000)
                throw new Exception("Este registro já foi pago!");

            new ReceitaDAL().Inserir(_receita, _contasReceber);
        }
        public void Alterar(Receita _receita)
        {
            new ReceitaDAL().Alterar(_receita);
        }
        public void Excluir(int _id)
        {
            if (new ReceitaDAL().BuscarPorId(_id).IdContasReceber != 0)
                throw new Exception("tale coisa e coisa e tale");

            new ReceitaDAL().Excluir(_id);
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
