using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class UsuarioBLL
    {
        private void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.Senha != _confirmacaoDeSenha)
                throw new Exception("A senha e a confirmação da senha devem ser iguais.");
            if (_usuario.Senha.Length <= 3)
                throw new Exception("A senha deve ter mais de 3 caracteres.");
            if (_usuario.Nome.Length <= 2)
                throw new Exception("O nome deve ter mais de 2 caracteres.");
        }
        public void Inserir(Usuario _usuario)
        {
            new UsuarioDAL().Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario)
        {
            new UsuarioDAL().Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
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
            Usuario usuario = new UsuarioDAL().BuscarPorNomeUsuario(_nomeUsuario);
            if (_senha == usuario.Senha)
                Constantes.IdUsuarioLogado = usuario.Id;
            else
                throw new Exception("Usuario ou senha inválido.");
        }
    }
}
