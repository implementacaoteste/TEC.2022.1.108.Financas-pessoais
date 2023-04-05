﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContasReceberDAL
    {
        public void Inserir(ContasReceber _contasReceber)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO ContasReceber(ValorReceber, Descricao)
                                    VALUES(@ValorReceber, @Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ValorReceber", _contasReceber.ValorReceber);
                cmd.Parameters.AddWithValue("@Descricao", _contasReceber.Descricao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma Conta a receber no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(ContasReceber _contasReceber)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE ContasReceber SET ValorReceber=@ValorReceber, Descricao=@Descricao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ValorReceber", _contasReceber.ValorReceber);
                cmd.Parameters.AddWithValue("@Descricao", _contasReceber.Descricao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma  Conta a receber no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM ContasReceber WHERE Id = @Id", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", _id);
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu erro ao tentar excluir uma Conta a receber no banco de dados", ex);
                    }

                }
            }
        }

        public ContasReceber BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            ContasReceber contasReceber = new ContasReceber();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, ValorReceber, Descricao FROM ContasReceber WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["ID"]);
                        contasReceber.ValorReceber = (double)rd["ValorReceber"];
                        contasReceber.Descricao = rd["Descricao"].ToString();
                    }
                }
                return contasReceber;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a receber por id do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasReceber> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            List<ContasReceber> contaReceber = new List<ContasReceber>();
            ContasReceber contasReceber;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, ValorReceber, Descricao FROM ContasReceber";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["Id"]);
                        contasReceber.ValorReceber = (double)rd["ValorReceber"];
                        contasReceber.Descricao = rd["Descricao"].ToString();
                        contaReceber.Add(contasReceber);
                    }
                }
                return contaReceber;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os contato do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasReceber> BuscarPorDescricao(string _descricao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasReceber> contaReceber = new List<ContasReceber>();
            ContasReceber contasReceber;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, ValorReceber, Descricao FROM ContasReceber WHERE Descricao LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["Id"]);
                        contasReceber.ValorReceber = (double)rd["ValorReceber"];
                        contasReceber.Descricao = rd["Descricao"].ToString();
                        contaReceber.Add(contasReceber);
                    }
                }
                return contaReceber;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar os contatos por descrição do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
