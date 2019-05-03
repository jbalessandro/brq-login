using System;
using System.Collections.Generic;

namespace BrqWebApi.Models
{
    public partial class Logs
    {
        public int LogId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Data { get; set; }
        public bool Logado { get; set; }

        public Usuarios Usuario { get; set; }
    }
}
