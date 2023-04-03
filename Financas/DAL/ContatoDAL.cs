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
    public class ContatoDAL
    {
        public void Inserir(Contato _contato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Contato(Nome, Endereco, Numero)
                                    VALUES(@Nome, @Endereco, @Numero)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _contato.Nome);
                cmd.Parameters.AddWithValue("@Endereco", _contato.Endereco);
                cmd.Parameters.AddWithValue("@Numero", _contato.Numero);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um Contato no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Contato _contato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Despesas SET Nome=@Nome, Endereco=@Endereco, Numero=@Numero WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _contato.Nome);
                cmd.Parameters.AddWithValue("@Endereco", _contato.Endereco);
                cmd.Parameters.AddWithValue("@Numero", _contato.Numero);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um Contato no banco de dados", ex);
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
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Contato WHERE Id = @Id", cn))
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
                        throw new Exception("Ocorreu erro ao tentar excluir um Contato no banco de dados", ex);
                    }

                }
            }
        }

        public Contato BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Contato contato = new Contato();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Endereco, Numero, Descricao FROM Contato WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        contato = new Contato();
                        contato.Id = Convert.ToInt32(rd["ID"]);
                        contato.Nome = rd["Nome"].ToString();
                        contato.Endereco = rd["Endereco"].ToString();
                        contato.Numero = Convert.ToInt32(rd["Numero"]);
                        contato.Descricao = rd["Descricao"].ToString();
                    }
                }
                return contato;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar os contatos por id do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
