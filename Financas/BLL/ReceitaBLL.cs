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
        public void Inserir(Receita _receita)
        {
            new ReceitaDAL().Inserir(_receita);
        }
        public void Alterar(Receita _receita)
        {
            new ReceitaDAL().Alterar(_receita);
        }
        public void Excluir(int _id)
        {
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
    }
}
