using System.Threading.Tasks;
using BrqWebApi.Interfaces;
using BrqWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BrqWebApi.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly BRQDBContext _context;

        public AuthenticationRepository(BRQDBContext context)
        {
            _context = context;
        }

        public async Task<Usuarios> Login(string login, string senha)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Login == login && x.Senha == senha && x.Ativo == true);

            if (usuario == null)
            {
                return null;
            }

            // TODO: implementar HASH
            usuario.Senha = string.Empty;

            return usuario;
        }
    }
}