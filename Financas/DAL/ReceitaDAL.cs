using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
        public void Inserir(Receita _receita, ContasReceber _contasReceber = null, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            List<SqlParameter> sqlParametersRemover = new List<SqlParameter>();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        string parametros = "";

                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Valor", _receita.Valor);
                        cmd.Parameters.AddWithValue("@Descricao", _receita.Descricao);
                        cmd.Parameters.AddWithValue("@IdContato", _receita.IdContato);
                        cmd.Parameters.AddWithValue("@IdBanco", _receita.IdBanco);
                        cmd.Parameters.AddWithValue("@IdFormaPagamento", _receita.IdFormaPagamento);
                        cmd.Parameters.AddWithValue("@DataEmissao", _receita.DataEmissao);
                        cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);
                        if (_contasReceber != null)
                            cmd.Parameters.AddWithValue("@IdContasReceber", _contasReceber.Id);
                        else
                            cmd.CommandText = cmd.CommandText.Replace("@IdContasReceber", "null");

                        cmd.CommandText = "INSERT INTO Receita(";

                        foreach(SqlParameter item in cmd.Parameters)
                        {
                            if (item.Value != null && item.ParameterName != "@Id")
                            {
                                parametros += item.ParameterName + ", ";
                                cmd.CommandText += item.ParameterName.Replace("@", "") + ",";
                            }
                            else if (item.ParameterName != "@Id")
                            {
                                sqlParametersRemover.Add(item);
                                cmd.CommandText += item.ParameterName.Replace("@", "") + " = NULL,";
                            }
                        }

                        foreach (SqlParameter item in sqlParametersRemover)
                            cmd.Parameters.Remove(item);

                        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1) + ")\r\nVALUES(" + parametros.Substring(0, parametros.Length - 2) + ")";

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        if (_contasReceber != null)
                        {
                            _contasReceber.DataPagamento = _receita.DataEmissao;
                            _contasReceber.IdBanco = _receita.IdBanco;
                            _contasReceber.IdFormaPagamento = _receita.IdFormaPagamento;
                            new ContasReceberDAL().Alterar(_contasReceber, transaction);
                        }
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction.Connection != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                            transaction.Rollback();
                        throw new Exception("Ocorreu erro ao tentar inserir uma receita no banco de dados", ex);
                    }
                }
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
                cmd.Parameters.AddWithValue("@Id", _receita.Id);
                cmd.Parameters.AddWithValue("@Valor", _receita.Valor);
                cmd.Parameters.AddWithValue("@Descricao", _receita.Descricao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar uma receita no banco de dados", ex);
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
                cmd.CommandText = @"SELECT Receita.Id, Receita.IdContasReceber, Receita.Descricao AS DescricaoReceita, Receita.Valor, Receita.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Receita.IdUsuario FROM Receita
                                    INNER JOIN Contato ON Receita.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Receita.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Receita.IdBanco = Banco.Id
                                    WHERE Receita.Id = @Id AND Receita.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        receita = new Receita();
                        receita.Id = Convert.ToInt32(rd["ID"]);
                        receita.Valor = (double)rd["Valor"];
                        receita.Descricao = rd["DescricaoReceita"].ToString();
                        receita.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        receita.Contato = rd["Contato"].ToString();
                        receita.FormaPagamento = rd["FormaPagamento"].ToString();
                        receita.Banco = rd["Banco"].ToString();
                        receita.IdContasReceber = Convert.ToInt32(rd["IdContasReceber"].ToString() == "" ? 0 : rd["IdContasReceber"]);
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
                cmd.CommandText = @"SELECT Receita.Id, Receita.Descricao AS DescricaoReceita, Receita.Valor, Receita.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Receita.IdUsuario FROM Receita
                                    INNER JOIN Contato ON Receita.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Receita.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Receita.IdBanco = Banco.Id
                                    WHERE Receita.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        receita = new Receita();
                        receita.Id = Convert.ToInt32(rd["Id"]);
                        receita.Valor = (double)rd["Valor"];
                        receita.Descricao = rd["DescricaoReceita"].ToString();
                        receita.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        receita.Contato = rd["Contato"].ToString();
                        receita.FormaPagamento = rd["FormaPagamento"].ToString();
                        receita.Banco = rd["Banco"].ToString();
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
                cmd.CommandText = @"SELECT Receita.Id, Receita.Descricao AS DescricaoReceita, Receita.Valor, Receita.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Receita.IdUsuario FROM Receita
                                    INNER JOIN Contato ON Receita.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Receita.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Receita.IdBanco = Banco.Id
                                    WHERE Receita.Descricao LIKE @Descricao AND Receita.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        receita = new Receita();
                        receita.Id = Convert.ToInt32(rd["Id"]);
                        receita.Valor = (double)rd["Valor"];
                        receita.Descricao = rd["DescricaoReceita"].ToString();
                        receita.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        receita.Contato = rd["Contato"].ToString();
                        receita.FormaPagamento = rd["FormaPagamento"].ToString();
                        receita.Banco = rd["Banco"].ToString();
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

        public List<Receita> BuscarPorEmissao(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Receita> receitas = new List<Receita>();
            Receita receita;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Receita.Id, Receita.Descricao AS DescricaoReceita, Receita.Valor, Receita.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Receita.IdUsuario FROM Receita
                                    INNER JOIN Contato ON Receita.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Receita.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Receita.IdBanco = Banco.Id
                                    WHERE Receita.DataEmissao BETWEEN @DataInicial AND @DataFinal AND Receita.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@DataInicial", _periodoInicial);
                cmd.Parameters.AddWithValue("@DataFinal", _periodoFinal);
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        receita = new Receita();
                        receita.Id = Convert.ToInt32(rd["Id"]);
                        receita.Valor = (double)rd["Valor"];
                        receita.Descricao = rd["DescricaoReceita"].ToString();
                        receita.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        receita.Contato = rd["Contato"].ToString();
                        receita.FormaPagamento = rd["FormaPagamento"].ToString();
                        receita.Banco = rd["Banco"].ToString();
                        receitas.Add(receita);
                    }
                }
                return receitas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as receitas por periodo do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Receita> BuscarPorContato(string _contato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Receita> receitas = new List<Receita>();
            Receita receita;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Receita.Id, Receita.Descricao AS DescricaoReceita, Receita.Valor, Receita.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Receita.IdUsuario FROM Receita
                                    INNER JOIN Contato ON Receita.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Receita.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Receita.IdBanco = Banco.Id
                                    WHERE Contato.Nome LIKE @Nome AND Receita.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _contato + "%");
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        receita = new Receita();
                        receita.Id = Convert.ToInt32(rd["Id"]);
                        receita.Valor = (double)rd["Valor"];
                        receita.Descricao = rd["DescricaoReceita"].ToString();
                        receita.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        receita.Contato = rd["Contato"].ToString();
                        receita.FormaPagamento = rd["FormaPagamento"].ToString();
                        receita.Banco = rd["Banco"].ToString();
                        receitas.Add(receita);
                    }
                }
                return receitas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as receitas por Devedor do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Receita> BuscarPorFormaPagamento(string _formaPagamento)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Receita> receitas = new List<Receita>();
            Receita receita;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Receita.Id, Receita.Descricao AS DescricaoReceita, Receita.Valor, Receita.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Receita.IdUsuario FROM Receita
                                    INNER JOIN Contato ON Receita.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Receita.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Receita.IdBanco = Banco.Id
                                    WHERE FormaPagamento.Descricao LIKE @Descricao AND Receita.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _formaPagamento + "%");
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        receita = new Receita();
                        receita.Id = Convert.ToInt32(rd["Id"]);
                        receita.Valor = (double)rd["Valor"];
                        receita.Descricao = rd["DescricaoReceita"].ToString();
                        receita.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        receita.Contato = rd["Contato"].ToString();
                        receita.FormaPagamento = rd["FormaPagamento"].ToString();
                        receita.Banco = rd["Banco"].ToString();
                        receitas.Add(receita);
                    }
                }
                return receitas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as receitas por forma de pagamento do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Receita> BuscarPorBanco(string _banco)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Receita> receitas = new List<Receita>();
            Receita receita;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Receita.Id, Receita.Descricao AS DescricaoReceita, Receita.Valor, Receita.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Receita.IdUsuario FROM Receita
                                    INNER JOIN Contato ON Receita.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Receita.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Receita.IdBanco = Banco.Id
                                    WHERE Banco.Nome LIKE @Nome AND Receita.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _banco + "%");
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        receita = new Receita();
                        receita.Id = Convert.ToInt32(rd["Id"]);
                        receita.Valor = (double)rd["Valor"];
                        receita.Descricao = rd["DescricaoReceita"].ToString();
                        receita.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        receita.Contato = rd["Contato"].ToString();
                        receita.FormaPagamento = rd["FormaPagamento"].ToString();
                        receita.Banco = rd["Banco"].ToString();
                        receitas.Add(receita);
                    }
                }
                return receitas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as receitas por banco do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        internal void ExcluirPorIdContasReceber(int _idContasReceber, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Receita WHERE IdContasReceber = @Id", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", _idContasReceber);
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
                        if (transaction.Connection != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                            transaction.Rollback();

                        throw new Exception("Ocorreu erro ao tentar estornar uma Receita no banco de dados", ex);
                    }

                }
            }
        }
    }
}