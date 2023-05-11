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
                cmd.CommandText = @"INSERT INTO Contato(Nome, Endereco, Numero,Descricao,Ativo,IdUsuario)
                                    VALUES(@Nome, @Endereco, @Numero,@Descricao,@Ativo,@IdUsuario)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _contato.Nome);
                cmd.Parameters.AddWithValue("@Endereco", _contato.Endereco);
                cmd.Parameters.AddWithValue("@Numero", _contato.Numero);
                cmd.Parameters.AddWithValue("@Descricao", _contato.Descricao);
                cmd.Parameters.AddWithValue("@Ativo", _contato.Ativo);
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);
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
                cmd.CommandText = "UPDATE Contato SET Nome=@Nome, Endereco=@Endereco, Numero=@Numero , Descricao=@Descricao, Ativo=@Ativo WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("Id", _contato.Id);
                cmd.Parameters.AddWithValue("@Nome", _contato.Nome);
                cmd.Parameters.AddWithValue("@Endereco", _contato.Endereco);
                cmd.Parameters.AddWithValue("@Numero", _contato.Numero);
                cmd.Parameters.AddWithValue("@Descricao", _contato.Descricao);
                cmd.Parameters.AddWithValue("Ativo", _contato.Ativo);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um Contato no banco de dados", ex);
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
                cmd.CommandText = @"SELECT Id, Nome, Endereco, Numero, Descricao, Ativo, IdUsuario FROM Contato
                                    WHERE Id = @Id AND IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        contato = new Contato();
                        contato.Id = Convert.ToInt32(rd["ID"]);
                        contato.Nome = rd["Nome"].ToString();
                        contato.Endereco = rd["Endereco"].ToString();
                        contato.Numero = rd["Numero"].ToString();
                        contato.Descricao = rd["Descricao"].ToString();
                        contato.Ativo = Convert.ToBoolean(rd["Ativo"]);
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

        public List<Contato> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            List<Contato> contatos = new List<Contato>();
            Contato contato;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Endereco, Numero, Descricao, Ativo, IdUsuario FROM Contato
                                    WHERE Ativo = 1 AND IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contato = new Contato();
                        contato.Id = Convert.ToInt32(rd["Id"]);
                        contato.Nome = rd["Nome"].ToString();
                        contato.Endereco = rd["Endereco"].ToString();
                        contato.Numero = rd["Numero"].ToString();
                        contato.Descricao = rd["Descricao"].ToString();
                        contato.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        contatos.Add(contato);
                    }
                }
                return contatos;
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

        public List<Contato> BuscarPorNome(string _nome)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Contato> contatos = new List<Contato>();
            Contato contato;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Endereco, Numero, Descricao, Ativo, IdUsuario FROM Contato
                                    WHERE Nome LIKE @Nome AND IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contato = new Contato();
                        contato.Id = Convert.ToInt32(rd["Id"]);
                        contato.Nome = rd["Nome"].ToString();
                        contato.Endereco = rd["Endereco"].ToString();
                        contato.Numero = rd["Numero"].ToString();
                        contato.Descricao = rd["Descricao"].ToString();
                        contato.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        contatos.Add(contato);
                    }
                }
                return contatos;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar o contato por nome do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Contato> BuscarPorEndereco(string _endereco)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Contato> contatos = new List<Contato>();
            Contato contato;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Endereco, Numero, Descricao, Ativo FROM Contato
                                    WHERE Endereco LIKE @Endereco AND IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Endereco", "%" + _endereco + "%");
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contato = new Contato();
                        contato.Id = Convert.ToInt32(rd["Id"]);
                        contato.Nome = rd["Nome"].ToString();
                        contato.Endereco = rd["Endereco"].ToString();
                        contato.Numero = rd["Numero"].ToString();
                        contato.Descricao = rd["Descricao"].ToString();
                        contato.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        contatos.Add(contato);
                    }
                }
                return contatos;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar o contato por Endereço do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Contato> BuscarPorNumero(int _numero)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Contato contato = new Contato();
            List<Contato> contatos = new List<Contato>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Endereco, Numero, Descricao, Ativo FROM Contato
                                    WHERE Numero LIKE @Numero AND IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Numero", "%" + _numero + "%");
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        contato = new Contato();
                        contato.Id = Convert.ToInt32(rd["ID"]);
                        contato.Nome = rd["Nome"].ToString();
                        contato.Endereco = rd["Endereco"].ToString();
                        contato.Numero = rd["Numero"].ToString();
                        contato.Descricao = rd["Descricao"].ToString();
                        contato.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        contatos.Add(contato);
                    }
                }
                return contatos;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar o contato por número do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Contato> BuscarPorDescricao(string _descricao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Contato> contatos = new List<Contato>();
            Contato contato;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Endereco, Numero, Descricao, Ativo FROM Contato 
                                    WHERE Descricao LIKE @Descricao AND IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contato = new Contato();
                        contato.Id = Convert.ToInt32(rd["ID"]);
                        contato.Nome = rd["Nome"].ToString();
                        contato.Endereco = rd["Endereco"].ToString();
                        contato.Numero = rd["Numero"].ToString();
                        contato.Descricao = rd["Descricao"].ToString();
                        contato.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        contatos.Add(contato);
                    }
                }
                return contatos;
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

        public Contato ValidarMovinteçãoContato(int id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Contato contato = new Contato();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT TOP 1 Contato.Id, Contato.Nome, Contato.Endereco, Contato.Numero, Contato.Descricao,Contato.Ativo FROM Contato
                                    LEFT JOIN Despesas ON Contato.Id = Despesas.IdContato
                                    LEFT JOIN Receita ON Contato.Id = Receita.IdContato
                                    LEFT JOIN ContasPagar ON Contato.Id = ContasPagar.IdContato
                                    LEFT JOIN ContasReceber ON Contato.Id = ContasReceber.IdContato
                                    WHERE Contato.Id = @Id
                                    AND (Despesas.IdContato IS NOT NULL
                                    OR Receita.IdContato IS NOT NULL
                                    OR ContasPagar.IdContato IS NOT NULL
                                    OR ContasReceber.IdContato IS NOT NULL)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        contato = new Contato();
                        contato.Id = Convert.ToInt32(rd["ID"]);
                        contato.Nome = rd["Nome"].ToString();
                        contato.Endereco = rd["Endereco"].ToString();
                        contato.Numero = rd["Numero"].ToString();
                        contato.Descricao = rd["Descricao"].ToString();
                        contato.Ativo = Convert.ToBoolean(rd["Ativo"]);

                    }
                }
                return contato;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por contato do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public object BuscarPorInativo(string inativo)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            List<Contato> contatos = new List<Contato>();
            Contato contato;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Endereco, Numero, Descricao, Ativo, IdUsuario FROM Contato 
                                    WHERE Ativo = 0 AND IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contato = new Contato();
                        contato.Id = Convert.ToInt32(rd["Id"]);
                        contato.Nome = rd["Nome"].ToString();
                        contato.Endereco = rd["Endereco"].ToString();
                        contato.Numero = rd["Numero"].ToString();
                        contato.Descricao = rd["Descricao"].ToString();
                        contato.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        contatos.Add(contato);
                    }
                }
                return contatos;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os contato inativos do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
