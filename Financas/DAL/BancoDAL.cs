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
    public class BancoDAL
    {
        public void Inserir(Banco _banco)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Banco(Nome, Saldo, Poupanca)
                                    VALUES(@Nome, @Saldo, @Poupanca)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _banco.Nome);
                cmd.Parameters.AddWithValue("@Saldo", _banco.Saldo);
                cmd.Parameters.AddWithValue("@Poupanca", _banco.Poupanca);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um Banco no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Banco _banco)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Banco SET Nome=@Nome, Saldo=@Saldo, Poupanca=@Poupanca WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _banco.Nome);
                cmd.Parameters.AddWithValue("@Saldo", _banco.Saldo);
                cmd.Parameters.AddWithValue("@Poupanca", _banco.Poupanca);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um Banco no banco de dados", ex);
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
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Banco WHERE Id = @Id", cn))
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
                        throw new Exception("Ocorreu erro ao tentar excluir um Banco no banco de dados", ex);
                    }

                }
            }
        }

        public Banco BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Banco banco = new Banco();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Saldo, Poupanca FROM Banco WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        banco = new Banco();
                        banco.Id = Convert.ToInt32(rd["ID"]);
                        banco.Nome = rd["Nome"].ToString();
                        banco.Saldo = rd.GetFloat(rd.GetOrdinal("Saldo"));
                        banco.Poupanca = rd.GetFloat(rd.GetOrdinal("Poupanca"));
                    }
                }
                return banco;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a pagar por id do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
