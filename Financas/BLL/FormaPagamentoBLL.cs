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
        public void Inserir(FormaPagamento _formaPagamento)
        {
            new FormaPagamentoDAL().Inserir(_formaPagamento);
        }
        public void Alterar(FormaPagamento _formaPagamento)
        {
            new FormaPagamentoDAL().Alterar(_formaPagamento);
        }
        public void Excluir(int _id)
        {
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
        public void BuscarPorId(int _id)
        {
            new FormaPagamentoDAL().BuscarPorId(_id);
        }
    }
}
