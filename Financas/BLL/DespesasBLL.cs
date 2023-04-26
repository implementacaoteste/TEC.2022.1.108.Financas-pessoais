﻿using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DespesasBLL
    {
        public void Inserir(Despesas _despesas, ContasPagar _contasPagar = null)
        {

            new DespesasDAL().Inserir(_despesas, _contasPagar);
        }
        public void Alterar(Despesas _despesas)
        {
            new DespesasDAL().Alterar(_despesas);
        }
        public void Excluir(int _id)
        {
            new DespesasDAL().Excluir(_id);
        }
        public List<Despesas> BuscarTodos()
        {
            return new DespesasDAL().BuscarTodos();
        }
        public List<Despesas> BuscarPorDescricao(string _descricao)
        {
            return new DespesasDAL().BuscarPorDescricao(_descricao);
        }
        public Despesas BuscarPorId(int _id)
        {
           return new DespesasDAL().BuscarPorId(_id);
        }
        public List<Despesas> BuscarPorBanco(string _banco)
        {
            return new DespesasDAL().BuscarPorBanco(_banco);
        }
        public List<Despesas> BuscarPorFormaPagamento(string _formaPagamento)
        {
            return new DespesasDAL().BuscarPorFormaPagamento(_formaPagamento);
        }
        public List<Despesas> BuscarPorContato(string _contato)
        {
            return new DespesasDAL().BuscarPorContato(_contato);
        }
        public List<Despesas> BuscarPorPeriodo(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            return new DespesasDAL().BuscarPorPeriodo(_periodoInicial, _periodoFinal);
        }
    }
}
