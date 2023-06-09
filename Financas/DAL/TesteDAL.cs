using System;
using System.Data.SqlClient;

namespace DAL
{
    public class TesteDAL
    {
        public bool TestarConexao(string _conexao)
        {
            SqlConnection cn = new SqlConnection(_conexao);

            try
            {
                cn.Open();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao testar a conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
