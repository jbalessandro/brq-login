using System.Linq;
using System.Threading.Tasks;
using BrqWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BrqWebApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LogController: ControllerBase
    {
        private readonly BRQDBContext _context;

        public LogController(BRQDBContext context)
        {
            _context = context;
        }
        
        [HttpGet("{usuarioId}")]
        public async Task<IActionResult> Get(int usuarioId)
        {
            var logs = await _context.Logs.Where(x => x.UsuarioId == usuarioId).ToListAsync();
            return Ok(logs);
        }
    }
}