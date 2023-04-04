using System.Collections.Generic;

namespace Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public float Renda { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
