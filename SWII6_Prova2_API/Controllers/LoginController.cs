using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWII6_Prova2_API.Models;

namespace SWII6_Prova2_API.Controllers
{
    [Route("login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly Context _context;

        public LoginController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Nome == login.Nome && u.Senha == login.Senha && u.Status);

            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }
    }
}
