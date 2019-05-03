using System.Threading.Tasks;
using BrqWebApi.Models;

namespace BrqWebApi.Interfaces
{
    public interface IAuthenticationRepository
    {
        Task<Usuarios> Login(string login, string senha);
    }
}