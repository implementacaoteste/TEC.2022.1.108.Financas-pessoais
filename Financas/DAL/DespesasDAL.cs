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
    public class DespesasDAL
    {
        public void Inserir(Despesas _despesas)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Despesas(Gastos, Descricao)
                                    VALUES(@Gastos, @Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Gastos", _despesas.Gastos);
                cmd.Parameters.AddWithValue("@Descricao", _despesas.Descricao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma Despesa no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Despesas _despesas)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Despesas SET Gastos=@Gastos, Descricao=@Descricao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Gastos", _despesas.Gastos);
                cmd.Parameters.AddWithValue("@Descricao", _despesas.Descricao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar uma Despesa no banco de dados", ex);
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
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Despesas WHERE Id = @Id", cn))
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
                        throw new Exception("Ocorreu erro ao tentar excluir uma Despesa no banco de dados", ex);
                    }

                }
            }
        }

        public Despesas BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Despesas despesas = new Despesas();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Gastos, Descricao FROM Despesas WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        despesas = new Despesas();
                        despesas.Id = Convert.ToInt32(rd["ID"]);
                        despesas.Gastos = (double)rd["Gastos"];
                        despesas.Descricao = rd["Descricao"].ToString();
                    }
                }
                return despesas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as despesas por id do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Despesas> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            List<Despesas> despesa = new List<Despesas>();
            Despesas despesas;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Gastos, Descricao FROM Despesas";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        despesas = new Despesas();
                        despesas.Id = Convert.ToInt32(rd["Id"]);
                        despesas.Gastos = (double)rd["Gastos"];
                        despesas.Descricao = rd["Descricao"].ToString();
                        despesa.Add(despesas);
                    }
                }
                return despesa;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todas as despesas do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Despesas> BuscarPorDescricao(string _descricao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Despesas> despesa = new List<Despesas>();
            Despesas despesas;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Gastos, Descricao, Renda FROM Despesas WHERE Descricao LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        despesas = new Despesas();
                        despesas.Id = Convert.ToInt32(rd["Id"]);
                        despesas.Gastos = (double)rd["Gastos"];
                        despesas.Descricao = rd["Descricao"].ToString();
                        despesa.Add(despesas);
                    }
                }
                return despesa;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as despesas por descrição do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
