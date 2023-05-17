using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace BLL
{
    public class UsuarioBLL
    {
        private void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.Senha != _confirmacaoDeSenha)
                throw new Exception("A senha e a confirmação da senha devem ser iguais.") { Data = { { "Id", 1 } } };
            if (_usuario.Senha.Length < 3)
                throw new Exception("A senha deve possuir 3 ou mais caracteres.") { Data = { { "Id", 2 } } };
            if (_usuario.Nome.Length < 2)
                throw new Exception("O nome deve possuir 2 ou mais caracteres.") { Data = { { "Id", 3 } } };
            if (_usuario.NomeUsuario.Contains(" "))
                throw new Exception("O nome de usuário não pode conter espaço.") { Data = { { "Id", 4 } } };

            Usuario usuario = new UsuarioDAL().BuscarPorNomeUsuario(_usuario.NomeUsuario);
            
            if (usuario.NomeUsuario != null && usuario.NomeUsuario.ToUpper() == _usuario.NomeUsuario.ToUpper() && usuario.Id != _usuario.Id)
                throw new Exception("Já existe um usuário com esse nome de usuario.") { Data = { { "Id", 5 } } };
        }
        public void Inserir(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            ValidarDados(_usuario, _confirmacaoDeSenha);
            new UsuarioDAL().Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            new UsuarioDAL().Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            int id = new UsuarioDAL().ValidarMovimentacaoUsuario(_id).Id;

            if (id != 0)
                throw new Exception("Registro não pode ser excluido porque existe histórico de movimentação");

            new UsuarioDAL().Excluir(_id);
        }
        public List<Usuario> BuscarTodos()
        {
            return new UsuarioDAL().BuscarTodos();
        }
        public List<Usuario> BuscarPorNome(string _nome)
        {
            return new UsuarioDAL().BuscarPorNome(_nome);
        }
        public Usuario BuscarPorId(int _id)
        {
            return new UsuarioDAL().BuscarPorId(_id);
        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            return new UsuarioDAL().BuscarPorNomeUsuario(_nomeUsuario);
        }
        public void Altenticar(string _nomeUsuario, string _senha)
        {
            if (_nomeUsuario == Constantes.NomeUsuarioSuporte && _senha == Constantes.SenhaSuporte)
            {
                Constantes.IdUsuarioLogado = -1;
                Constantes.NomeUsuarioLogado = Constantes.NomeUsuarioSuporte;
                return;
            }

            Usuario usuario = new UsuarioDAL().BuscarPorNomeUsuario(_nomeUsuario);
            if (_senha == usuario.Senha && usuario.Ativo)
            {
                Constantes.IdUsuarioLogado = usuario.Id;
                Constantes.NomeUsuarioLogado = usuario.NomeUsuario;
            }
            else
                throw new Exception("Usuario ou senha inválido.");
        }
    }
}
