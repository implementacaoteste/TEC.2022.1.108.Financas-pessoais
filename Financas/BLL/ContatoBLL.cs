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
        private void ValidarDadosContato(Contato _contato)
        {
            if (_contato.Numero.Replace("(","").Replace(")", "").Replace("-", "").Replace(" ","").Length != 11)
                throw new Exception("O número do contato deve conter 11 caracteres");
        }
        public void Inserir(Contato _contato)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            ValidarDadosContato(_contato);
            new ContatoDAL().Inserir(_contato);
        }
        public void Alterar(Contato _contato)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            new ContatoDAL().Alterar(_contato);
        }
        public void Excluir(int _id)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
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

        public object BuscarPorInativo(string _inativo)
        {
            return new ContatoDAL().BuscarPorInativo(_inativo);
        }
    }
}
