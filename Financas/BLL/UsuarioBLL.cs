using DAL;
using infra;
using Models;
using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace BLL
{
    public class UsuarioBLL
    {
        private Usuario ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.Senha == null || _usuario.Senha.Length < 3)
                throw new Exception("A senha deve possuir 3 ou mais caracteres.") { Data = { { "Id", 1 } } };
            if (_usuario.Nome == null || _usuario.Nome.Length < 2)
                throw new Exception("O nome deve possuir 2 ou mais caracteres.") { Data = { { "Id", 2 } } };
            if (_usuario.NomeUsuario == null || _usuario.NomeUsuario.Contains(" "))
                throw new Exception("O nome de usuário não pode conter espaço.") { Data = { { "Id", 3 } } };
            _usuario.Nome = _usuario.Nome.Trim();
            if (_usuario.Nome == null || _usuario.Nome.Length <= 2)
                throw new Exception("O nome deve possuir 2 ou mais caracteres.") { Data = { { "Id", 2 } } };


            Usuario usuario = new UsuarioDAL().BuscarPorNomeUsuario(_usuario.NomeUsuario);

            if (usuario.NomeUsuario != null && usuario.NomeUsuario.ToUpper() == _usuario.NomeUsuario.ToUpper() && usuario.Id != _usuario.Id)
                throw new Exception("Já existe um usuário com esse nome de usuario.") { Data = { { "Id", 3 } } };
            if (_usuario.Senha != usuario.Senha && _usuario.Senha != _confirmacaoDeSenha)
                throw new Exception("A senha e a confirmação da senha devem ser iguais.") { Data = { { "Id", 1 } } };

            if (usuario.Senha == null || _usuario.Senha != usuario.Senha)
                _usuario.Senha = new Criptografia().CriptografarSenha(_usuario.Senha);

            return _usuario;
        }
        public void Inserir(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            ValidarDados(_usuario, _confirmacaoDeSenha);
            new UsuarioDAL().Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            ValidarDados(_usuario, _confirmacaoDeSenha);
            new UsuarioDAL().Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
            if (Constantes.IdUsuarioLogado != -1)
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
        public bool Altenticar(string _nomeUsuario, string _senha, bool _altenticacaoInicial)
        {
            if (_nomeUsuario == Constantes.NomeUsuarioSuporte && _senha == Constantes.SenhaSuporte)
            {
                if (!_altenticacaoInicial)
                {
                    Constantes.IdUsuarioLogado = -1;
                    Constantes.NomeUsuarioLogado = Constantes.NomeUsuarioSuporte;
                }
                return true;
            }

            Usuario usuario = new UsuarioDAL().BuscarPorNomeUsuario(_nomeUsuario);
            if (new Criptografia().CriptografarSenha(_senha) == usuario.Senha && usuario.Ativo)
            {
                if (_altenticacaoInicial)
                {
                    Constantes.IdUsuarioLogado = usuario.Id;
                    Constantes.NomeUsuarioLogado = usuario.NomeUsuario;
                    return true;
                }
                if (Constantes.IdUsuarioLogado != usuario.Id)
                    throw new Exception("Usuario ou senha inválido.");
                return false;
            }
            else
                throw new Exception("Usuario ou senha inválido.");
        }
    }
}
