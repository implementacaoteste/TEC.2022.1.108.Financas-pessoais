using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContatoBLL
    {
        private void ValidarDadosContato(Contato _contato)
        {
            _contato.Descricao = _contato.Descricao.Trim();
            _contato.Endereco = _contato.Endereco.Trim();
            _contato.Nome = _contato.Nome.Trim();

            if (_contato.Numero == null || _contato.Numero.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Length != 11)
                throw new Exception("O número do contato deve conter 11 caracteres") { Data = { { "Id", 0 } } }; ;

            if (_contato.Descricao == null || _contato.Descricao.Length < 3)
                throw new Exception("O campo descrição deve ter mais que dois caractéres.") { Data = { { "Id", 1 } } };
            if (_contato.Endereco == null || _contato.Descricao.Length < 3)
                throw new Exception("O campo endereco deve ter mais que dois caractéres.") { Data = { { "Id", 2 } } }; ;
            if (_contato.Nome == null || _contato.Descricao.Length < 3)
                throw new Exception("O campo nome deve ter mais que dois caractéres.") { Data = { { "Id", 3 } } }; ;
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

            ValidarDadosContato(_contato);
            new ContatoDAL().Alterar(_contato);
        }
        public void Excluir(int _id)
        {
            if (Constantes.IdUsuarioLogado == -1)
            {
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
                int id = new ContatoDAL().ValidarMovinteçãoContato(_id).Id;
                if (id != 0)
                    throw new Exception("Registro não pode ser excluido porque existe histórico de movimentação.");

                new ContatoDAL().Excluir(_id);
            }
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
