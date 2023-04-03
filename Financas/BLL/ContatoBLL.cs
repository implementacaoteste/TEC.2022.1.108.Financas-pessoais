using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContatoBLL
    {
        public void Inserir(Contato _contato)
        {
            new ContatoDAL().Inserir(_contato);
        }
        public void Alterar(Contato _contato)
        {
            new ContatoDAL().Alterar(_contato);
        }
        public void Excluir(int _id)
        {
            new ContatoDAL().Excluir(_id);
        }
        public void BuscarPorId(int _id)
        {
            new ContatoDAL().BuscarPorId(_id);
        }
    }
}
