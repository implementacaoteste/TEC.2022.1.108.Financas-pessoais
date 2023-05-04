using Models;
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
                cmd.CommandText = @"INSERT INTO Banco(Nome, Saldo, Poupanca, Ativo, IdUsuario)
                                    VALUES(@Nome, @Saldo, @Poupanca, @Ativo, @IdUsuario)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _banco.Nome);
                cmd.Parameters.AddWithValue("@Saldo", _banco.Saldo);
                cmd.Parameters.AddWithValue("@Poupanca", _banco.Poupanca);
                cmd.Parameters.AddWithValue("@Ativo", _banco.Ativo);
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);
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
                cmd.CommandText = "UPDATE Banco SET Nome=@Nome, Saldo=@Saldo, Poupanca=@Poupanca, Ativo = @Ativo WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _banco.Id);
                cmd.Parameters.AddWithValue("@Nome", _banco.Nome);
                cmd.Parameters.AddWithValue("@Saldo", _banco.Saldo);
                cmd.Parameters.AddWithValue("@Poupanca", _banco.Poupanca);
                cmd.Parameters.AddWithValue("@Ativo", _banco.Ativo);
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
                cmd.CommandText = @"SELECT Banco.Id, Banco.Nome, ISNULL(Receita.Valor, 0) - ISNULL(Despesas.Valor, 0) AS Saldo, Banco.Poupanca, Banco.Ativo, Banco.IdUsuario FROM Banco
                                    LEFT JOIN (SELECT SUM(Valor) AS Valor, IdBanco FROM Receita GROUP BY IdBanco) AS Receita ON Banco.Id = Receita.IdBanco
                                    LEFT JOIN (SELECT SUM(Valor) AS Valor, IdBanco FROM Despesas GROUP BY IdBanco) AS Despesas ON Banco.Id = Despesas.IdBanco
                                    WHERE Id = @Id";
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
                        banco.Saldo = (double)rd["Saldo"];
                        banco.Poupanca = (double)rd["Poupanca"];
                        banco.Ativo = Convert.ToBoolean(rd["Ativo"]);
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

        public List<Banco> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            List<Banco> bancos = new List<Banco>();
            Banco banco;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Banco.Id, Banco.Nome, ISNULL(Receita.Valor, 0) - ISNULL(Despesas.Valor, 0) AS Saldo, Banco.Poupanca, Banco.Ativo, Banco.IdUsuario FROM Banco
                                    LEFT JOIN (SELECT SUM(Valor) AS Valor, IdBanco FROM Receita GROUP BY IdBanco) AS Receita ON Banco.Id = Receita.IdBanco
                                    LEFT JOIN (SELECT SUM(Valor) AS Valor, IdBanco FROM Despesas GROUP BY IdBanco) AS Despesas ON Banco.Id = Despesas.IdBanco";

                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        banco = new Banco();
                        banco.Id = Convert.ToInt32(rd["Id"]);
                        banco.Nome = rd["Nome"].ToString();
                        banco.Saldo = (double)rd["Saldo"];
                        banco.Poupanca = (double)rd["Poupanca"];
                        banco.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        bancos.Add(banco);
                    }
                }
                return bancos;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os bancos a pagar do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Banco> BuscarPorNome(string _nome)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Banco> bancos = new List<Banco>();
            Banco banco;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Banco.Id, Banco.Nome, ISNULL(Receita.Valor - Despesas.Valor, 0) AS Saldo, Banco.Poupanca, Banco.Ativo, Banco.IdUsuario FROM Banco
                                    LEFT JOIN (SELECT SUM(Valor) AS Valor, IdBanco FROM Receita GROUP BY IdBanco) AS Receita ON Banco.Id = Receita.IdBanco
                                    LEFT JOIN (SELECT SUM(Valor) AS Valor, IdBanco FROM Despesas GROUP BY IdBanco) AS Despesas ON Banco.Id = Despesas.IdBanco
                                    WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        banco = new Banco();
                        banco.Id = Convert.ToInt32(rd["Id"]);
                        banco.Nome = rd["Nome"].ToString();
                        banco.Saldo = (double)rd["Saldo"];
                        banco.Poupanca = (double)rd["Poupanca"];
                        banco.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        bancos.Add(banco);
                    }
                }
                return bancos;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar os bancos por nome do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Banco ValidarMovimentacaoBanco(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Banco banco = new Banco();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT TOP 1 Banco.Id, Banco.Nome, Banco.Poupanca, Banco.Ativo FROM Banco 
                                    LEFT JOIN Despesas ON Banco.Id = Despesas.IdBanco
                                    LEFT JOIN Receita ON Banco.Id = Receita.IdBanco
                                    LEFT JOIN ContasPagar ON Banco.Id = ContasPagar.IdBanco 
                                    LEFT JOIN ContasReceber ON Banco.Id = ContasReceber.IdBanco
                                    WHERE Banco.Id = @Id
                                    AND (Despesas.IdBanco IS NOT NULL
                                    OR Receita.IdBanco IS NOT NULL
                                    OR ContasPagar.IdBanco IS NOT NULL
                                    OR ContasReceber.IdBanco IS NOT NULL)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        banco = new Banco();
                        banco.Id = Convert.ToInt32(rd["Id"]);
                        banco.Nome = rd["Nome"].ToString();
                        //banco.Saldo = (double)rd["Saldo"];
                        banco.Poupanca = (double)rd["Poupanca"];
                        banco.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    }
                }
                return banco;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar os bancos do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
