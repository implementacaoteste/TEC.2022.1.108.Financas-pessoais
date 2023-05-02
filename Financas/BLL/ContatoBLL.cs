using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContatoBLL
    {
        public void Inserir(Contato _contato)
        {
            new ContatoDAL().Inserir(_contato);
        }
        public void Alterar(Contato _contato)
        {
            new ContatoDAL().Alterar(_contato);
        }
        public void Excluir(int _id)
        {
            int id = new ContatoDAL().ValidarMovinteçãoContato (_id).Id;
            if (id != 0)
                throw new Exception("Registro não pode ser excluido porque existe histórico de movimentação.");

            new ContatoDAL().Excluir(_id);
        }
        public List<Contato> BuscarTodos()
        {
            return new ContatoDAL().BuscarTodos();
        }
        public List<Contato> BuscarPorNome(string _nome)
        {
            return new ContatoDAL().BuscarPorNome(_nome);
        }
        public List<Contato> BuscarPorEndereco(string _endereco)
        {
            return new ContatoDAL().BuscarPorEndereco(_endereco);
        }
        public List<Contato> BuscarPorNumero(int _numero)
        {
            return new ContatoDAL().BuscarPorNumero(_numero);
        }
        public List<Contato> BuscarPorDescricao(string _descricao)
        {
            return new ContatoDAL().BuscarPorDescricao(_descricao);
        }
        public Contato BuscarPorId(int _id)
        {
            return new ContatoDAL().BuscarPorId(_id);
        }
    }
}
