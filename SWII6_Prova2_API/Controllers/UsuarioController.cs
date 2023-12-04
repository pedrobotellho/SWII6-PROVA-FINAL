using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWII6_Prova2_API.Models;

namespace SWII6_Prova2_API.Controllers
{
    [Route("usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly Context _context;

        public UsuarioController(Context context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            if (id <= 0 || _context.Usuarios == null)
                return NotFound();

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == id);

            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var usuarios = await _context.Usuarios.ToListAsync();

            if (usuarios == null || usuarios.Count() <= 0)
                return NotFound();

            return Ok(usuarios);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return Created("", usuario);
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (id <= 0 || _context.Usuarios == null)
                return NotFound();

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == id);

            if (usuario == null)
                return NotFound();

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Usuario usuario)
        {
            if (id <= 0 || _context.Usuarios == null)
                return NotFound();

            var usuarioFind = await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == id);

            if (usuarioFind == null)
                return NotFound();

            usuarioFind.Nome = usuario.Nome;
            usuarioFind.Senha = usuario.Senha;
            usuarioFind.Status = usuario.Status;

            _context.Usuarios.Update(usuarioFind);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
