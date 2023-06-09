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
    public class DespesasDAL
    {
        public void Inserir(Despesas _despesas, ContasPagar _contasPagar = null, SqlTransaction _transaction = null)
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
                        cmd.Parameters.AddWithValue("@Valor", _despesas.Valor);
                        cmd.Parameters.AddWithValue("@Descricao", _despesas.Descricao);
                        cmd.Parameters.AddWithValue("@IdContato", _despesas.IdContato);
                        cmd.Parameters.AddWithValue("@IdBanco", _despesas.IdBanco);
                        cmd.Parameters.AddWithValue("@IdFormaPagamento", _despesas.IdFormaPagamento);
                        cmd.Parameters.AddWithValue("@DataEmissao", _despesas.DataEmissao);
                        cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);
                        if (_contasPagar != null)
                            cmd.Parameters.AddWithValue("@IdContasPagar", _contasPagar.Id);
                        else
                            cmd.CommandText = cmd.CommandText.Replace("@IdContasPagar", "null");

                        cmd.CommandText = "INSERT INTO Despesas(";

                        foreach (SqlParameter item in cmd.Parameters)
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
                        if (_contasPagar != null)
                        {
                            _contasPagar.DataPagamento = _despesas.DataEmissao;
                            _contasPagar.IdBanco = _despesas.IdBanco;
                            _contasPagar.IdFormaPagamento = _despesas.IdFormaPagamento;
                            new ContasPagarDAL().Alterar(_contasPagar, transaction);
                        }

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction.Connection != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                            transaction.Rollback();
                        throw new Exception("Ocorreu erro ao tentar inserir uma despesa no banco de dados", ex);
                    }

                }
            }
        }
        public void Alterar(Despesas _despesas, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            List<SqlParameter> sqlParametersRemover = new List<SqlParameter>();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Valor", _despesas.Valor);
                        cmd.Parameters.AddWithValue("@Descricao", _despesas.Descricao);
                        cmd.Parameters.AddWithValue("@IdContato", _despesas.IdContato);
                        cmd.Parameters.AddWithValue("@IdBanco", _despesas.IdBanco);
                        cmd.Parameters.AddWithValue("@IdFormaPagamento", _despesas.IdFormaPagamento);
                        cmd.Parameters.AddWithValue("@DataEmissao", _despesas.DataEmissao);
                        cmd.Parameters.AddWithValue("@Id", _despesas.Id);

                        cmd.CommandText = "UPDATE Despesas\r\nSET";

                        foreach (SqlParameter item in cmd.Parameters)
                        {
                            if (item.Value != null && item.ParameterName != "@Id")
                                cmd.CommandText += "\r\t" + item.ParameterName.Replace("@", "") + " = " + item.ParameterName + ",";
                            else if (item.ParameterName != "@Id")
                            {
                                sqlParametersRemover.Add(item);
                                cmd.CommandText += "\r\t" + item.ParameterName.Replace("@", "") + " = NULL,";
                            }
                        }

                        foreach (SqlParameter item in sqlParametersRemover)
                            cmd.Parameters.Remove(item);

                        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1) + "\r\nWHERE Id = @Id";

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
                        throw new Exception("Ocorreu erro ao tentar alterar uma  despesa no banco de dados", ex);
                    }
                }
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
                cmd.CommandText = @"SELECT Despesas.Id,Despesas.IdContasPagar, Despesas.Descricao AS DescricaoDespesas, Despesas.Valor, Despesas.DataEmissao, Contato.Nome AS Contato, Despesas.IdBanco, Despesas.IdFormapagamento, Despesas.IdContato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Despesas.IdUsuario FROM Despesas
                                    INNER JOIN Contato ON Despesas.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Despesas.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Despesas.IdBanco = Banco.Id
                                    WHERE Despesas.Id = @Id AND Despesas.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        despesas = new Despesas();
                        despesas.Id = Convert.ToInt32(rd["Id"]);
                        despesas.Valor = (double)rd["Valor"];
                        despesas.Descricao = rd["DescricaoDespesas"].ToString();
                        despesas.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        despesas.Contato = rd["Contato"].ToString();
                        despesas.IdContato = Convert.ToInt32(rd["IdContato"]);
                        despesas.FormaPagamento = rd["FormaPagamento"].ToString();
                        despesas.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        despesas.Banco = rd["Banco"].ToString();
                        despesas.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        despesas.IdContasPagar = Convert.ToInt32(rd["IdContasPagar"].ToString() == "" ? 0 : rd["IdContasPagar"]);
                    }
                }
                return despesas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar uma despesa por id do banco de dados", ex);
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
                cmd.CommandText = @"SELECT Despesas.Id, Despesas.Descricao AS DescricaoDespesas, Despesas.Valor, Despesas.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Despesas.IdUsuario FROM Despesas
                                    INNER JOIN Contato ON Despesas.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Despesas.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Despesas.IdBanco = Banco.Id
                                    WHERE Despesas.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        despesas = new Despesas();
                        despesas.Id = Convert.ToInt32(rd["Id"]);
                        despesas.Valor = (double)rd["Valor"];
                        despesas.Descricao = rd["DescricaoDespesas"].ToString();
                        despesas.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        despesas.Contato = rd["Contato"].ToString();
                        despesas.FormaPagamento = rd["FormaPagamento"].ToString();
                        despesas.Banco = rd["Banco"].ToString();
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
                cmd.CommandText = @"SELECT Despesas.Id, Despesas.Descricao AS DescricaoDespesas, Despesas.Valor, Despesas.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Despesas.IdUsuario FROM Despesas
                                    INNER JOIN Contato ON Despesas.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Despesas.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Despesas.IdBanco = Banco.Id
                                    WHERE Despesas.Descricao LIKE @Descricao AND Despesas.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        despesas = new Despesas();
                        despesas.Id = Convert.ToInt32(rd["Id"]);
                        despesas.Valor = (double)rd["Valor"];
                        despesas.Descricao = rd["DescricaoDespesas"].ToString();
                        despesas.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        despesas.Contato = rd["Contato"].ToString();
                        despesas.FormaPagamento = rd["FormaPagamento"].ToString();
                        despesas.Banco = rd["Banco"].ToString();
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

        public List<Despesas> BuscarPorBanco(string _banco)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Despesas> todasDespesas = new List<Despesas>();
            Despesas despesas;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Despesas.Id, Despesas.Descricao AS DescricaoDespesas, Despesas.Valor, Despesas.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Despesas.IdUsuario FROM Despesas
                                    INNER JOIN Contato ON Despesas.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Despesas.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Despesas.IdBanco = Banco.Id
                                    WHERE Banco.Nome LIKE @Nome AND Despesas.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _banco + "%");
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        despesas = new Despesas();
                        despesas.Id = Convert.ToInt32(rd["Id"]);
                        despesas.Valor = (double)rd["Valor"];
                        despesas.Descricao = rd["DescricaoDespesas"].ToString();
                        despesas.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        despesas.Contato = rd["Contato"].ToString();
                        despesas.FormaPagamento = rd["FormaPagamento"].ToString();
                        despesas.Banco = rd["Banco"].ToString();
                        todasDespesas.Add(despesas);
                    }
                }
                return todasDespesas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as despesas por banco do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Despesas> BuscarPorFormaPagamento(string _formaPagamento)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Despesas> todasDespesas = new List<Despesas>();
            Despesas despesas;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Despesas.Id, Despesas.Descricao AS DescricaoDespesas, Despesas.Valor, Despesas.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Despesas.IdUsuario FROM Despesas
                                    INNER JOIN Contato ON Despesas.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Despesas.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Despesas.IdBanco = Banco.Id
                                    WHERE FormaPagamento.Descricao LIKE @Descricao AND Despesas.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _formaPagamento + "%");
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        despesas = new Despesas();
                        despesas.Id = Convert.ToInt32(rd["Id"]);
                        despesas.Valor = (double)rd["Valor"];
                        despesas.Descricao = rd["DescricaoDespesas"].ToString();
                        despesas.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        despesas.Contato = rd["Contato"].ToString();
                        despesas.FormaPagamento = rd["FormaPagamento"].ToString();
                        despesas.Banco = rd["Banco"].ToString();
                        todasDespesas.Add(despesas);
                    }
                }
                return todasDespesas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as despesas por forma de pagamento do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Despesas> BuscarPorContato(string _contato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Despesas> todasDespesas = new List<Despesas>();
            Despesas despesas;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Despesas.Id, Despesas.Descricao AS DescricaoDespesas, Despesas.Valor, Despesas.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Despesas.IdUsuario FROM Despesas
                                    INNER JOIN Contato ON Despesas.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Despesas.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Despesas.IdBanco = Banco.Id
                                    WHERE Contato.Nome LIKE @Nome AND Despesas.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _contato + "%");
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        despesas = new Despesas();
                        despesas.Id = Convert.ToInt32(rd["Id"]);
                        despesas.Valor = (double)rd["Valor"];
                        despesas.Descricao = rd["DescricaoDespesas"].ToString();
                        despesas.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        despesas.Contato = rd["Contato"].ToString();
                        despesas.FormaPagamento = rd["FormaPagamento"].ToString();
                        despesas.Banco = rd["Banco"].ToString();
                        todasDespesas.Add(despesas);
                    }
                }
                return todasDespesas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as despesas por Devedor do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Despesas> BuscarPorEmissao(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Despesas> todasDespesas = new List<Despesas>();
            Despesas despesas;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Despesas.Id, Despesas.Descricao AS DescricaoDespesas, Despesas.Valor, Despesas.DataEmissao, Contato.Nome AS Contato, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, Despesas.IdUsuario FROM Despesas
                                    INNER JOIN Contato ON Despesas.IdContato = Contato.Id 
                                    INNER JOIN FormaPagamento ON Despesas.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON Despesas.IdBanco = Banco.Id
                                    WHERE Despesas.DataEmissao BETWEEN @DataInicial AND @DataFinal AND Despesas.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@DataInicial", _periodoInicial);
                cmd.Parameters.AddWithValue("@DataFinal", _periodoFinal);
                cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        despesas = new Despesas();
                        despesas.Id = Convert.ToInt32(rd["Id"]);
                        despesas.Valor = (double)rd["Valor"];
                        despesas.Descricao = rd["DescricaoDespesas"].ToString();
                        despesas.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        despesas.Contato = rd["Contato"].ToString();
                        despesas.FormaPagamento = rd["FormaPagamento"].ToString();
                        despesas.Banco = rd["Banco"].ToString();
                        todasDespesas.Add(despesas);
                    }
                }
                return todasDespesas;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as despesas por periodo do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void ExcluirPorIdContasPagar(int _idContasPagar, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Despesas WHERE IdContasPagar = @Id", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", _idContasPagar);
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

                        throw new Exception("Ocorreu erro ao tentar estornar uma Despesa no banco de dados", ex);
                    }

                }
            }
        }
    }
}
