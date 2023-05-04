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
    public class ContasPagarDAL
    {
        public void Inserir(ContasPagar _contasPagar, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO ContasPagar(ValorPagar, Descricao, IdContato, IdBanco, IdFormaPagamento, DataEmissao,IdUsuario)
                                                         VALUES(@ValorPagar, @Descricao, @IdContato, @IdBanco, @IdFormaPagamento, @DataEmissao, @IdUsuario)", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@ValorPagar", _contasPagar.ValorPagar);
                        cmd.Parameters.AddWithValue("@Descricao", _contasPagar.Descricao);
                        cmd.Parameters.AddWithValue("@IdContato", _contasPagar.IdContato);
                        cmd.Parameters.AddWithValue("@IdBanco", _contasPagar.IdBanco);
                        cmd.Parameters.AddWithValue("@IdFormaPagamento", _contasPagar.IdFormaPagamento);
                        cmd.Parameters.AddWithValue("@DataEmissao", _contasPagar.DataEmissao);
                        cmd.Parameters.AddWithValue("@IdUsuario", Constantes.IdUsuarioLogado);
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
                        throw new Exception("Ocorreu erro ao tentar inserir uma Conta a pagar no banco de dados", ex);
                    }

                }
            }
        }
        public void Alterar(ContasPagar _contasPagar, SqlTransaction _transaction = null)
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
                        cmd.Parameters.AddWithValue("@ValorPagar", _contasPagar.ValorPagar);
                        cmd.Parameters.AddWithValue("@Descricao", _contasPagar.Descricao);
                        cmd.Parameters.AddWithValue("@IdContato", _contasPagar.IdContato);
                        cmd.Parameters.AddWithValue("@IdBanco", _contasPagar.IdBanco);
                        cmd.Parameters.AddWithValue("@IdFormaPagamento", _contasPagar.IdFormaPagamento);
                        cmd.Parameters.AddWithValue("@DataEmissao", _contasPagar.DataEmissao);
                        cmd.Parameters.AddWithValue("@DataPagamento", _contasPagar.DataPagamento);
                        cmd.Parameters.AddWithValue("@Id", _contasPagar.Id);

                        cmd.CommandText = "UPDATE ContasPagar\r\nSET";

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
                cmd.CommandText = @"SELECT ContasPagar.Id, ContasPagar.Descricao AS DescricaoContasPagar, ContasPagar.ValorPagar, ContasPagar.DataEmissao, ContasPagar.DataPagamento, ContasPagar.IdBanco, ContasPagar.IdContato, ContasPagar.IdFormaPagamento, Contato.Nome AS Credor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, ContasPagar.IdUsuario  FROM ContasPagar
                                    INNER JOIN Contato ON ContasPagar.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasPagar.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasPagar.IdBanco = Banco.Id
                                    WHERE ContasPagar.Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["Id"]);
                        contasPagar.ValorPagar = (double)rd["ValorPagar"];
                        contasPagar.Descricao = rd["DescricaoContasPagar"].ToString();
                        contasPagar.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasPagar.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasPagar.Contato = rd["Credor"].ToString();
                        contasPagar.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasPagar.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasPagar.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasPagar.Banco = rd["Banco"].ToString();
                        contasPagar.IdBanco = Convert.ToInt32(rd["IdBanco"]);
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
                cmd.CommandText = @"SELECT ContasPagar.Id, ContasPagar.Descricao AS DescricaoContasPagar, ContasPagar.ValorPagar, ContasPagar.DataEmissao, ContasPagar.DataPagamento, ContasPagar.IdBanco, ContasPagar.IdContato, ContasPagar.IdFormaPagamento, Contato.Nome AS Credor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, ContasPagar.IdUsuario  FROM ContasPagar
                                    INNER JOIN Contato ON ContasPagar.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasPagar.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasPagar.IdBanco = Banco.Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["Id"]);
                        contasPagar.ValorPagar = (double)rd["ValorPagar"];
                        contasPagar.Descricao = rd["DescricaoContasPagar"].ToString();
                        contasPagar.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasPagar.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasPagar.Contato = rd["Credor"].ToString();
                        contasPagar.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasPagar.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasPagar.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasPagar.Banco = rd["Banco"].ToString();
                        contasPagar.IdBanco = Convert.ToInt32(rd["IdBanco"]);
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
                cmd.CommandText = @"SELECT ContasPagar.Id, ContasPagar.Descricao AS DescricaoContasPagar, ContasPagar.ValorPagar, ContasPagar.DataEmissao, ContasPagar.DataPagamento, ContasPagar.IdBanco, ContasPagar.IdContato, ContasPagar.IdFormaPagamento, Contato.Nome AS Credor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, ContasPagar.Idusuario  FROM ContasPagar
                                    INNER JOIN Contato ON ContasPagar.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasPagar.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasPagar.IdBanco = Banco.Id
                                    WHERE ContasPagar.Descricao LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["Id"]);
                        contasPagar.ValorPagar = (double)rd["ValorPagar"];
                        contasPagar.Descricao = rd["DescricaoContasPagar"].ToString();
                        contasPagar.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasPagar.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasPagar.Contato = rd["Credor"].ToString();
                        contasPagar.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasPagar.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasPagar.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasPagar.Banco = rd["Banco"].ToString();
                        contasPagar.IdBanco = Convert.ToInt32(rd["IdBanco"]);
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
        public List<ContasPagar> BuscarPorPeriodo(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasPagar> contaPagar = new List<ContasPagar>();
            ContasPagar contasPagar;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasPagar.Id, ContasPagar.Descricao AS DescricaoContasPagar, ContasPagar.ValorPagar, ContasPagar.DataEmissao, ContasPagar.DataPagamento, ContasPagar.IdBanco, ContasPagar.IdContato, ContasPagar.IdFormaPagamento, Contato.Nome AS Credor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, ContasPagar.IdUsuario  FROM ContasPagar
                                    INNER JOIN Contato ON ContasPagar.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasPagar.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasPagar.IdBanco = Banco.Id
                                    WHERE ContasPagar.DataEmissao BETWEEN @DataInicial AND @DataFinal";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@DataInicial", _periodoInicial);
                cmd.Parameters.AddWithValue("@DataFinal", _periodoFinal);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["Id"]);
                        contasPagar.ValorPagar = (double)rd["ValorPagar"];
                        contasPagar.Descricao = rd["DescricaoContasPagar"].ToString();
                        contasPagar.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasPagar.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasPagar.Contato = rd["Credor"].ToString();
                        contasPagar.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasPagar.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasPagar.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasPagar.Banco = rd["Banco"].ToString();
                        contasPagar.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        contaPagar.Add(contasPagar);
                    }
                }
                return contaPagar;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a pagar por periodo do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<ContasPagar> BuscarPorContato(string _contato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasPagar> contaPagar = new List<ContasPagar>();
            ContasPagar contasPagar;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasPagar.Id, ContasPagar.Descricao AS DescricaoContasPagar, ContasPagar.ValorPagar, ContasPagar.DataEmissao, ContasPagar.DataPagamento, ContasPagar.IdBanco, ContasPagar.IdContato, ContasPagar.IdFormaPagamento, Contato.Nome AS Credor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, ContasPagar.IdUsuario  FROM ContasPagar
                                    INNER JOIN Contato ON ContasPagar.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasPagar.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasPagar.IdBanco = Banco.Id
                                    WHERE Contato.Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _contato + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["Id"]);
                        contasPagar.ValorPagar = (double)rd["ValorPagar"];
                        contasPagar.Descricao = rd["DescricaoContasPagar"].ToString();
                        contasPagar.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasPagar.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasPagar.Contato = rd["Credor"].ToString();
                        contasPagar.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasPagar.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasPagar.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasPagar.Banco = rd["Banco"].ToString();
                        contasPagar.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        contaPagar.Add(contasPagar);
                    }
                }
                return contaPagar;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a pagar por Devedor do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<ContasPagar> BuscarPorFormaPagamento(string _formaPagamento)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasPagar> contaPagar = new List<ContasPagar>();
            ContasPagar contasPagar;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasPagar.Id, ContasPagar.Descricao AS DescricaoContasPagar, ContasPagar.ValorPagar, ContasPagar.DataEmissao, ContasPagar.DataPagamento, ContasPagar.IdBanco, ContasPagar.IdContato, ContasPagar.IdFormaPagamento, Contato.Nome AS Credor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco,ContasPagar.IdUsuario  FROM ContasPagar
                                    INNER JOIN Contato ON ContasPagar.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasPagar.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasPagar.IdBanco = Banco.Id
                                    WHERE FormaPagamento.Descricao LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _formaPagamento + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["Id"]);
                        contasPagar.ValorPagar = (double)rd["ValorPagar"];
                        contasPagar.Descricao = rd["DescricaoContasPagar"].ToString();
                        contasPagar.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasPagar.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasPagar.Contato = rd["Credor"].ToString();
                        contasPagar.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasPagar.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasPagar.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasPagar.Banco = rd["Banco"].ToString();
                        contasPagar.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        contaPagar.Add(contasPagar);
                    }
                }
                return contaPagar;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a pagar por forma de pagamento do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasPagar> BuscarPorBanco(string _banco)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasPagar> contaPagar = new List<ContasPagar>();
            ContasPagar contasPagar;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasPagar.Id, ContasPagar.Descricao AS DescricaoContasPagar, ContasPagar.ValorPagar, ContasPagar.DataEmissao, ContasPagar.DataPagamento, ContasPagar.IdBanco, ContasPagar.IdContato, ContasPagar.IdFormaPagamento, Contato.Nome AS Credor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, ContasPagar.IdUsuario  FROM ContasPagar
                                    INNER JOIN Contato ON ContasPagar.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasPagar.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasPagar.IdBanco = Banco.Id
                                    WHERE Banco.Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _banco + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["Id"]);
                        contasPagar.ValorPagar = (double)rd["ValorPagar"];
                        contasPagar.Descricao = rd["DescricaoContasPagar"].ToString();
                        contasPagar.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasPagar.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasPagar.Contato = rd["Credor"].ToString();
                        contasPagar.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasPagar.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasPagar.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasPagar.Banco = rd["Banco"].ToString();
                        contasPagar.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        contaPagar.Add(contasPagar);
                    }
                }
                return contaPagar;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a pagar por banco do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasPagar> BuscarPagamento(DateTime _periodoInicial, DateTime _periodoFinal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ContasPagar> contaPagar = new List<ContasPagar>();
            ContasPagar contasPagar;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ContasPagar.Id, ContasPagar.Descricao AS DescricaoContasPagar, ContasPagar.ValorPagar, ContasPagar.DataEmissao, ContasPagar.DataPagamento, ContasPagar.IdBanco, ContasPagar.IdContato, ContasPagar.IdFormaPagamento, Contato.Nome AS Credor, FormaPagamento.Descricao AS FormaPagamento, Banco.Nome AS Banco, ContasPagar.IdUsuario  FROM ContasPagar
                                    INNER JOIN Contato ON ContasPagar.IdContato = Contato.Id
                                    INNER JOIN FormaPagamento ON ContasPagar.IdFormaPagamento = FormaPagamento.Id
                                    INNER JOIN Banco ON ContasPagar.IdBanco = Banco.Id
                                    WHERE ContasPagar.DataPagamento BETWEEN @DataInicial AND @DataFinal";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@DataInicial", _periodoInicial);
                cmd.Parameters.AddWithValue("@DataFinal", _periodoFinal);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["Id"]);
                        contasPagar.ValorPagar = (double)rd["ValorPagar"];
                        contasPagar.Descricao = rd["DescricaoContasPagar"].ToString();
                        contasPagar.DataEmissao = Convert.ToDateTime(rd["DataEmissao"]);
                        if (rd["DataPagamento"].ToString() != "")
                            contasPagar.DataPagamento = Convert.ToDateTime(rd["DataPagamento"]);
                        contasPagar.Contato = rd["Credor"].ToString();
                        contasPagar.IdContato = Convert.ToInt32(rd["IdContato"]);
                        contasPagar.FormaPagamento = rd["FormaPagamento"].ToString();
                        contasPagar.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        contasPagar.Banco = rd["Banco"].ToString();
                        contasPagar.IdBanco = Convert.ToInt32(rd["IdBanco"]);
                        contaPagar.Add(contasPagar);
                    }
                }
                return contaPagar;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as contas a pagar por pagamento do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void EstornarBaixa(ContasPagar _contasPagar, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            _contasPagar.DataPagamento = null;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                try
                {
                    if (_transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }

                    Alterar(_contasPagar, transaction);
                    new DespesasDAL().ExcluirPorIdContasPagar(_contasPagar.Id, transaction);

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
