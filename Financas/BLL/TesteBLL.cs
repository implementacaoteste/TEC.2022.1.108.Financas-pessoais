using DAL;

namespace BLL
{
    public class TesteBLL
    {
        public bool TestarConexao(string _conexao)
        {
            return new TesteDAL().TestarConexao(_conexao);
        }
    }
}
