using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReceitaDAL
    {
        public void Inserir(Receita _receita)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Receita(Valor, Descricao)
                                    VALUES(@Valor, @Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Valor", _receita.Valor);
                cmd.Parameters.AddWithValue("@Descricao", _receita.Descricao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma Receita no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Receita _receita)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Receita SET Valor=@Valor, Descricao=@Descricao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Valor", _receita.Valor);
                cmd.Parameters.AddWithValue("@Descricao", _receita.Descricao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar uma Receita no banco de dados", ex);
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
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Receita WHERE Id = @Id", cn))
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
                        throw new Exception("Ocorreu erro ao tentar excluir uma Receita no banco de dados", ex);
                    }

                }
            }
        }

        public Receita BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Receita receita = new Receita();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Receita.Id, Receita.Valor, Receita.Descricao, Contato.Nome FROM Receita
                                    INNER JOIN Contato ON Receita.IdContato = Contato.Id WHERE Receita.Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        receita = new Receita();
                        receita.Id = Convert.ToInt32(rd["ID"]);
                        receita.Valor = (double)rd["Valor"];
                        receita.Descricao = rd["Descricao"].ToString();
                        receita.Contato = rd["Nome"].ToString();
                    }
                }
                return receita;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as receitas por id do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Receita> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            List<Receita> receitas = new List<Receita>();
            Receita receita;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Receita.Id, Receita.Valor, Receita.Descricao, Contato.Nome FROM Receita
                                    INNER JOIN Contato ON Receita.IdContato = Contato.Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        receita = new Receita();
                        receita.Id = Convert.ToInt32(rd["Id"]);
                        receita.Valor = (double)rd["Valor"];
                        receita.Descricao = rd["Descricao"].ToString();
                        receita.Contato = rd["Nome"].ToString();
                        receitas.Add(receita);
                    }
                }
                return receitas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todas as receitas do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Receita> BuscarPorDescricao(string _descricao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Receita> receitas = new List<Receita>();
            Receita receita;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Receita.Id, Receita.Valor, Receita.Descricao, Contato.Nome FROM Receita
                                    INNER JOIN Contato ON Receita.IdContato = Contato.Id WHERE Receita.Descricao LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        receita = new Receita();
                        receita.Id = Convert.ToInt32(rd["Id"]);
                        receita.Valor = (double)rd["Valor"];
                        receita.Descricao = rd["Descricao"].ToString();
                        receita.Contato = rd["Nome"].ToString();
                        receitas.Add(receita);
                    }
                }
                return receitas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as receitas por descrição do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
