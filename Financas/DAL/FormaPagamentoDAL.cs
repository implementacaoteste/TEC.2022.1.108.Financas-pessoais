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
    public class FormaPagamentoDAL
    {
        public void Inserir(FormaPagamento _formaPagamento)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO FormaPagamento(Descricao,IdUsuario,Ativo)
                                    VALUES(@Descricao,@IdUsuario, @Ativo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _formaPagamento.Descricao);
                cmd.Parameters.AddWithValue("@Ativo", _formaPagamento.Ativo);
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma Forma de pagamento no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(FormaPagamento _formaPagamento)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE FormaPagamento SET Descricao=@Descricao, Ativo=@Ativo WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _formaPagamento.Id);
                cmd.Parameters.AddWithValue("@Descricao", _formaPagamento.Descricao);
                cmd.Parameters.AddWithValue("@Ativo", _formaPagamento.Ativo);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar uma Forma de pagamento no banco de dados", ex);
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
                using (SqlCommand cmd = new SqlCommand("DELETE FROM FormaPagamento WHERE Id = @Id", cn))
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
                        throw new Exception("Ocorreu erro ao tentar excluir uma Forma de pagamento no banco de dados", ex);
                    }

                }
            }
        }
        public List<FormaPagamento> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            List<FormaPagamento> formaPagamentos = new List<FormaPagamento>();
            FormaPagamento formaPagamento;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao, Ativo, IdUsuario FROM FormaPagamento WHERE Ativo = 1";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        formaPagamento = new FormaPagamento();
                        formaPagamento.Id = Convert.ToInt32(rd["Id"]);
                        formaPagamento.Descricao = rd["Descricao"].ToString();
                        formaPagamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        formaPagamentos.Add(formaPagamento);
                    }
                }
                return formaPagamentos;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos as formas de pagamento do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public FormaPagamento BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            FormaPagamento formaPagamento = new FormaPagamento();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao, Ativo, IdUsuario FROM FormaPagamento WHERE Id = @Id AND Ativo = 1";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        formaPagamento = new FormaPagamento();
                        formaPagamento.Id = Convert.ToInt32(rd["ID"]);
                        formaPagamento.Descricao = rd["Descricao"].ToString();
                        formaPagamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    }
                    return formaPagamento;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as formas de pagamento por id do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<FormaPagamento> BuscarPorDescricao(string _descricao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<FormaPagamento> formaPagamentos = new List<FormaPagamento>();
            FormaPagamento formaPagamento;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao, Ativo, IdUsuario FROM FormaPagamento WHERE Descricao LIKE @Descricao AND Ativo = 1";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        formaPagamento = new FormaPagamento();
                        formaPagamento.Id = Convert.ToInt32(rd["Id"]);
                        formaPagamento.Descricao = rd["Descricao"].ToString();
                        formaPagamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        formaPagamentos.Add(formaPagamento);
                    }
                }
                return formaPagamentos;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as formas de pagamento por descrição do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public FormaPagamento ValidarMovinteçãoFormaPagamento(int id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            FormaPagamento formaPagamento = new FormaPagamento();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT TOP 1 FormaPagamento.Id, FormaPagamento.Descricao FROM FormaPagamento
                                    LEFT JOIN Despesas ON FormaPagamento.Id = Despesas.IdFormaPagamento
                                    LEFT JOIN Receita ON FormaPagamento.Id = Receita.IdFormaPagamento
                                    LEFT JOIN ContasPagar ON FormaPagamento.Id = ContasPagar.IdFormaPagamento
                                    LEFT JOIN ContasReceber ON FormaPagamento.Id = ContasReceber.IdFormaPagamento
                                    WHERE FormaPagamento.Id = @Id
                                    AND (Despesas.IdFormaPagamento IS NOT NULL
                                    OR Receita.IdFormaPagamento IS NOT NULL
                                    OR ContasPagar.IdFormaPagamento IS NOT NULL
                                    OR ContasReceber.IdFormaPagamento IS NOT NULL)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        formaPagamento = new FormaPagamento();
                        formaPagamento.Id = Convert.ToInt32(rd["Id"]);
                        formaPagamento.Descricao = rd["Descricao"].ToString();
                    }
                }
                return formaPagamento;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por Forma de pagamento do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
            

            
        }
        

        public object BuscarPorInativo(string _inativo)
        {
            {
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                List<FormaPagamento> formasPagamento = new List<FormaPagamento>();
                FormaPagamento formaPagamento;
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = @"SELECT Id, Descricao, Ativo, IdUsuario FROM FormaPagamento WHERE Ativo = 0";
                    cmd.CommandType = System.Data.CommandType.Text;

                    cn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            formaPagamento = new FormaPagamento();
                            formaPagamento.Id = Convert.ToInt32(rd["Id"]);
                            formaPagamento.Descricao = rd["Descricao"].ToString();
                            formaPagamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                            formasPagamento.Add(formaPagamento);
                        }
                    }
                    return formasPagamento;
                }
                catch (Exception ex)
                {

                    throw new Exception("Ocorreu um erro ao tentar buscar as formas de pagamento por inatividade no banco de dados", ex);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}
