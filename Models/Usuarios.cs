using System;
using System.Collections.Generic;

namespace BrqWebApi.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Logs = new HashSet<Logs>();
        }

        public int UsuarioId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool? Ativo { get; set; }
        public string Nome { get; set; }

        public ICollection<Logs> Logs { get; set; }
    }
}
