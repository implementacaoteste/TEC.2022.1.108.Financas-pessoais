using Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContasReceberDAL
    {
        public void Inserir(ContasReceber _contasReceber, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO ContasReceber(ValorReceber, Descricao, IdContato, IdBanco, IdFormaPagamento, DataEmissao)
                                                         VALUES(@ValorReceber, @Descricao, @IdContato, @IdBanco, @IdFormaPagamento, @DataEmissao)", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@ValorReceber", _contasReceber.ValorReceber);
                        cmd.Parameters.AddWithValue("@Descricao", _contasReceber.Descricao);
                        cmd.Parameters.AddWithValue("@IdContato", _contasReceber.IdContato);
                        cmd.Parameters.AddWithValue("@IdBanco", _contasReceber.IdBanco);
                        cmd.Parameters.AddWithValue("@IdFormaPagamento", _contasReceber.IdFormaPagamento);
                        cmd.Parameters.AddWithValue("@DataEmissao", _contasReceber.DataEmissao);
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
                        throw new Exception("Ocorreu erro ao tentar inserir uma  Conta a receber no banco de dados", ex);
                    }

                }
            }
        }
        public void Alterar(ContasReceber _contasReceber, SqlTransaction _transaction = null)
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
                        cmd.Parameters.AddWithValue("@ValorReceber", _contasReceber.ValorReceber);
                        cmd.Parameters.AddWithValue("@Descricao", _contasReceber.Descricao);
                        cmd.Parameters.AddWithValue("@IdContato", _contasReceber.IdContato);
                        cmd.Parameters.AddWithValue("@IdBanco", _contasReceber.IdBanco);
                        cmd.Parameters.AddWithValue("@IdFormaPagamento", _contasReceber.IdFormaPagamento);
                        cmd.Parameters.AddWithValue("@DataEmissao", _contasReceber.DataEmissao);
                        cmd.Parameters.AddWithValue("@DataPagamento", _contasReceber.DataPagamento);
                        cmd.Parameters.AddWithValue("@Id", _contasReceber.Id);

                        cmd.CommandText = "UPDATE ContasReceber\r\nSET";
                        
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
                        throw new Exception("Ocorreu erro ao tentar alterar uma  Conta a receber no banco de dados", ex);
                    }
                }
            }
        }

        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM ContasReceber WHERE Id = @Id", cn))
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
                        if (transaction.Connection != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                            transaction.Rollback();
                        throw new Exception("Ocorreu erro ao tentar excluir uma  Conta a receber no banco de dados", ex);
                    }

                }
            }
        }

        public ContasReceber BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            ContasReceber contasReceber = new ContasReceber();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasReceber.Id, ContasReceber.Descricao AS DescricaoContasReceber, ContasReceber.ValorReceber, ContasReceber.DataEmissao, ContasReceber.DataPagamento, ContasReceber.IdBanco, ContasReceber.IdContato, ContasReceber.IdFormaPagamento, Contato.Nome AS Devedor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco  FROM ContasReceber
                                    INNER JOIN Contato ON ContasReceber.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasReceber.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasReceber.IdBanco = Banco.Id  
                                    WHERE ContasReceber.Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["Id"]);
                        contasReceber.ValorReceber = (double)rd["ValorReceber"];
                        contasReceber.Descricao = rd["DescricaoContasReceber"].ToString();
                        contasReceber.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasReceber.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasReceber.Contato = rd["Devedor"].ToString();
                        contasReceber.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasReceber.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasReceber.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasReceber.Banco = rd["Banco"].ToString();
                        contasReceber.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                    }
                }
                return contasReceber;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a receber por id do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasReceber> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            List<ContasReceber> contaReceber = new List<ContasReceber>();
            ContasReceber contasReceber;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasReceber.Id, ContasReceber.Descricao AS DescricaoContasReceber, ContasReceber.ValorReceber, ContasReceber.DataEmissao, ContasReceber.DataPagamento, ContasReceber.IdBanco, ContasReceber.IdContato, ContasReceber.IdFormaPagamento, Contato.Nome AS Devedor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco  FROM ContasReceber
                                    INNER JOIN Contato ON ContasReceber.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasReceber.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasReceber.IdBanco = Banco.Id  ";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["Id"]);
                        contasReceber.ValorReceber = (double)rd["ValorReceber"];
                        contasReceber.Descricao = rd["DescricaoContasReceber"].ToString();
                        contasReceber.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasReceber.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasReceber.Contato = rd["Devedor"].ToString();
                        contasReceber.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasReceber.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasReceber.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasReceber.Banco = rd["Banco"].ToString();
                        contasReceber.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        contaReceber.Add(contasReceber);
                    }
                }
                return contaReceber;
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

        public List<ContasReceber> BuscarPorDescricao(string _descricao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasReceber> contaReceber = new List<ContasReceber>();
            ContasReceber contasReceber;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasReceber.Id, ContasReceber.Descricao AS DescricaoContasReceber, ContasReceber.ValorReceber, ContasReceber.DataEmissao, ContasReceber.DataPagamento, ContasReceber.IdBanco, ContasReceber.IdContato, ContasReceber.IdFormaPagamento, Contato.Nome AS Devedor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco  FROM ContasReceber
                                    INNER JOIN Contato ON ContasReceber.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasReceber.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasReceber.IdBanco = Banco.Id  
                                    WHERE ContasReceber.Descricao LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["Id"]);
                        contasReceber.ValorReceber = (double)rd["ValorReceber"];
                        contasReceber.Descricao = rd["DescricaoContasReceber"].ToString();
                        contasReceber.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasReceber.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasReceber.Contato = rd["Devedor"].ToString();
                        contasReceber.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasReceber.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasReceber.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasReceber.Banco = rd["Banco"].ToString();
                        contasReceber.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        contaReceber.Add(contasReceber);
                    }
                }
                return contaReceber;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a receber por descrição do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<ContasReceber> BuscarPorPeriodo(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasReceber> contaReceber = new List<ContasReceber>();
            ContasReceber contasReceber;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasReceber.Id, ContasReceber.Descricao AS DescricaoContasReceber, ContasReceber.ValorReceber, ContasReceber.DataEmissao, ContasReceber.DataPagamento, ContasReceber.IdBanco, ContasReceber.IdContato, ContasReceber.IdFormaPagamento, Contato.Nome AS Devedor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco  FROM ContasReceber
                                    INNER JOIN Contato ON ContasReceber.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasReceber.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasReceber.IdBanco = Banco.Id 
                                    WHERE ContasReceber.DataEmissao BETWEEN @DataInicial AND @DataFinal";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@DataInicial", _periodoInicial);
                cmd.Parameters.AddWithValue("@DataFinal", _periodoFinal);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["Id"]);
                        contasReceber.ValorReceber = (double)rd["ValorReceber"];
                        contasReceber.Descricao = rd["DescricaoContasReceber"].ToString();
                        contasReceber.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasReceber.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasReceber.Contato = rd["Devedor"].ToString();
                        contasReceber.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasReceber.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasReceber.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasReceber.Banco = rd["Banco"].ToString();
                        contasReceber.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        contaReceber.Add(contasReceber);
                    }
                }
                return contaReceber;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a receber por periodo do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<ContasReceber> BuscarPorContato(string _contato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasReceber> contaReceber = new List<ContasReceber>();
            ContasReceber contasReceber;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasReceber.Id, ContasReceber.Descricao AS DescricaoContasReceber, ContasReceber.ValorReceber, ContasReceber.DataEmissao, ContasReceber.DataPagamento, ContasReceber.IdBanco, ContasReceber.IdContato, ContasReceber.IdFormaPagamento, Contato.Nome AS Devedor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco  FROM ContasReceber
                                    INNER JOIN Contato ON ContasReceber.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasReceber.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasReceber.IdBanco = Banco.Id 
                                    WHERE Contato.Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _contato + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["Id"]);
                        contasReceber.ValorReceber = (double)rd["ValorReceber"];
                        contasReceber.Descricao = rd["DescricaoContasReceber"].ToString();
                        contasReceber.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasReceber.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasReceber.Contato = rd["Devedor"].ToString();
                        contasReceber.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasReceber.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasReceber.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasReceber.Banco = rd["Banco"].ToString();
                        contasReceber.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        contaReceber.Add(contasReceber);
                    }
                }
                return contaReceber;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a receber por Devedor do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<ContasReceber> BuscarPorFormaPagamento(string _formaPagamento)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasReceber> contaReceber = new List<ContasReceber>();
            ContasReceber contasReceber;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasReceber.Id, ContasReceber.Descricao AS DescricaoContasReceber, ContasReceber.ValorReceber, ContasReceber.DataEmissao, ContasReceber.DataPagamento, ContasReceber.IdBanco, ContasReceber.IdContato, ContasReceber.IdFormaPagamento, Contato.Nome AS Devedor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco  FROM ContasReceber
                                    INNER JOIN Contato ON ContasReceber.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasReceber.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasReceber.IdBanco = Banco.Id
                                    WHERE FormaPagamento.Descricao LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _formaPagamento + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["Id"]);
                        contasReceber.ValorReceber = (double)rd["ValorReceber"];
                        contasReceber.Descricao = rd["DescricaoContasReceber"].ToString();
                        contasReceber.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasReceber.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasReceber.Contato = rd["Devedor"].ToString();
                        contasReceber.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasReceber.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasReceber.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasReceber.Banco = rd["Banco"].ToString();
                        contasReceber.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        contaReceber.Add(contasReceber);
                    }
                }
                return contaReceber;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a receber por forma de pagamento do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasReceber> BuscarPorBanco(string _banco)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasReceber> contaReceber = new List<ContasReceber>();
            ContasReceber contasReceber;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasReceber.Id, ContasReceber.Descricao AS DescricaoContasReceber, ContasReceber.ValorReceber, ContasReceber.DataEmissao, ContasReceber.DataPagamento, ContasReceber.IdBanco, ContasReceber.IdContato, ContasReceber.IdFormaPagamento, Contato.Nome AS Devedor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco  FROM ContasReceber
                                    INNER JOIN Contato ON ContasReceber.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasReceber.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasReceber.IdBanco = Banco.Id 
                                    WHERE Banco.Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _banco + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["Id"]);
                        contasReceber.ValorReceber = (double)rd["ValorReceber"];
                        contasReceber.Descricao = rd["DescricaoContasReceber"].ToString();
                        contasReceber.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasReceber.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasReceber.Contato = rd["Devedor"].ToString();
                        contasReceber.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasReceber.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasReceber.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasReceber.Banco = rd["Banco"].ToString();
                        contasReceber.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        contaReceber.Add(contasReceber);
                    }
                }
                return contaReceber;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a receber por banco do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasReceber> BuscarPagamento(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasReceber> contaReceber = new List<ContasReceber>();
            ContasReceber contasReceber;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasReceber.Id, ContasReceber.Descricao AS DescricaoContasReceber, ContasReceber.ValorReceber, ContasReceber.DataEmissao, ContasReceber.DataPagamento, ContasReceber.IdBanco, ContasReceber.IdContato, ContasReceber.IdFormaPagamento, Contato.Nome AS Devedor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco  FROM ContasReceber
                                    INNER JOIN Contato ON ContasReceber.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasReceber.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasReceber.IdBanco = Banco.Id
                                    WHERE ContasReceber.DataPagamento BETWEEN @DataInicial AND @DataFinal";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@DataInicial", _periodoInicial);
                cmd.Parameters.AddWithValue("@DataFinal", _periodoFinal);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["Id"]);
                        contasReceber.ValorReceber = (double)rd["ValorReceber"];
                        contasReceber.Descricao = rd["DescricaoContasReceber"].ToString();
                        contasReceber.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasReceber.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasReceber.Contato = rd["Devedor"].ToString();
                        contasReceber.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasReceber.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasReceber.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasReceber.Banco = rd["Banco"].ToString();
                        contasReceber.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        contaReceber.Add(contasReceber);
                    }
                }
                return contaReceber;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a receber por periodo do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void EstornarBaixa(ContasReceber _contasReceber, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            _contasReceber.DataPagamento = null;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                try
                {
                    if (_transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }

                    Alterar(_contasReceber, transaction);
                    new ReceitaDAL().ExcluirPorIdContasReceber(_contasReceber.Id);

                    if (_transaction == null)
                        transaction.Commit();
                }
                catch (Exception ex)
                {
                    if (transaction.Connection != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                        transaction.Rollback();

                    throw new Exception("Ocorreu erro ao tentar estornar um pagamento de uma  Conta a receber no banco de dados", ex);
                }
            }
        }
    }
}
