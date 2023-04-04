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
    public class ContasPagarDAL
    {
        public void Inserir(ContasPagar _contasPagar)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO ContasPagar(ValorPagar, Descricao)
                                    VALUES(@ValorPagar, @Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ValorPagar", _contasPagar.ValorPagar);
                cmd.Parameters.AddWithValue("@Descricao", _contasPagar.Descricao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma Conta a pagar no banco de dados", ex);
            }
            finally 
            { 
                cn.Close(); 
            } 
        }
        public void Alterar(ContasPagar _contasPagar)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE ContasPagar SET ValorPagar=@ValorPagar, Descricao=@Descricao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ValorPagar", _contasPagar.ValorPagar);
                cmd.Parameters.AddWithValue("@Descricao", _contasPagar.Descricao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma  Conta a pagar no banco de dados", ex);
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
                using (SqlCommand cmd = new SqlCommand("DELETE FROM ContasPagar WHERE Id = @Id", cn))
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
                        throw new Exception("Ocorreu erro ao tentar excluir uma Conta a pagar no banco de dados", ex);
                    }

                }
            }
        }

        public ContasPagar BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            ContasPagar contasPagar = new ContasPagar();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, ValorPagar, Descricao FROM ContasPagar WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["ID"]);
                        contasPagar.ValorPagar = rd.GetFloat(rd.GetOrdinal("ValorPagar"));
                        contasPagar.Descricao = rd["Descricao"].ToString();
                    }
                }
                return contasPagar;
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

        public List<ContasPagar> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            List<ContasPagar> contaPagar = new List<ContasPagar>();
            ContasPagar contasPagar;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, ValorPagar, Descricao FROM ContasPagar";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["Id"]);
                        contasPagar.ValorPagar = rd.GetFloat(rd.GetOrdinal("ValorPagar"));
                        contasPagar.Descricao = rd["Descricao"].ToString();
                        contaPagar.Add(contasPagar);
                    }
                }
                return contaPagar;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todas as contas a pagar do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasPagar> BuscarPorDescricao(string _descricao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasPagar> contaPagar = new List<ContasPagar>();
            ContasPagar contasPagar;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, ValorPagar, Descricao FROM ContasPagar WHERE Descricao LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["Id"]);
                        contasPagar.ValorPagar = rd.GetFloat(rd.GetOrdinal("ValorPagar"));
                        contasPagar.Descricao = rd["Descricao"].ToString();
                        contaPagar.Add(contasPagar);
                    }
                }
                return contaPagar;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a pagar por descrição do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
