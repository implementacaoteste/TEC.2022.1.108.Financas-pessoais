﻿using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BancoBLL
    {
        private void ValidarDados(Banco _banco)
        {

            if (_banco.Nome == null || _banco.Nome.Trim().Length <= 1)
                throw new Exception("O banco deve possuir 2 ou mais caracteres.") { Data = { { "Id", 0 } } }; 
            _banco.Nome = _banco.Nome.Trim();

            Banco banco = new BancoDAL().BuscarPorNomeBanco(_banco.Nome);

            if (banco.Nome != null && banco.Nome.ToUpper() == _banco.Nome.ToUpper() && banco.Id != _banco.Id)
                throw new Exception("Já existe um banco com esse nome.") { Data = { { "Id", 0 } } }; 
        }
        public void Inserir(Banco _banco)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            ValidarDados(_banco);
            new BancoDAL().Inserir(_banco);
        }
        public void Alterar(Banco _banco)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");
            ValidarDados(_banco);
            new BancoDAL().Alterar(_banco);
        }
        public void Excluir(int _id)
        {
            if (Constantes.IdUsuarioLogado == -1)
                throw new Exception("Este usuário não possui permissão para realizar essa operação.");

            int id = new BancoDAL().ValidarMovimentacaoBanco(_id).Id;

            if (id != 0)
                throw new Exception("Registro não pode ser excluido porque existe histórico de movimentação");

            new BancoDAL().Excluir(_id);
        }
        public List<Banco> BuscarTodos()
        {
            return new BancoDAL().BuscarTodos();
        }
        public List<Banco> BuscarPorNome(string _nome)
        {
            return new BancoDAL().BuscarPorNome(_nome);
        }
        public Banco BuscarPorNomeBanco(string _nome)
        {
            return new BancoDAL().BuscarPorNomeBanco(_nome);
        }
        public Banco BuscarPorId(int _id, bool _apenasInativos, bool _inativo)
        {
            return new BancoDAL().BuscarPorId(_id, _apenasInativos, _inativo);
        }

        public List<Banco> BuscarPorInativo(bool _apenasInativos = false, bool _Inativo = false)
        {
            return new BancoDAL().BuscarPorInativo(_apenasInativos, _Inativo);
        }
    }
}
