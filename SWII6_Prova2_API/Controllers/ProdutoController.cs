using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWII6_Prova2_API.Models;

namespace SWII6_Prova2_API.Controllers
{
    [Route("produtos")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {

        private readonly Context _context;

        public ProdutoController(Context context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            if (id <= 0 || _context.Produtos == null)
                return NotFound();

            var produto = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);

            if (produto == null)
                return NotFound();

            return Ok(produto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var produtos = await _context.Produtos.ToListAsync();

            if (produtos == null || produtos.Count <= 0)
                return NotFound();

            return Ok(produtos);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return Created("", produto);
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (id <= 0 || _context.Produtos == null)
                return NotFound();

            var produto = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);

            if (produto == null)
                return NotFound();

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Produto produto)
        {
            if (id <= 0 || _context.Produtos == null)
                return NotFound();

            var produtoFind = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);

            if (produtoFind == null)
                return NotFound();

            produtoFind.Nome = produto.Nome;
            produtoFind.Preco = produto.Preco;
            produtoFind.Status = produto.Status;
            produtoFind.IdUsuarioUpdate = produto.IdUsuarioUpdate;

            _context.Produtos.Update(produtoFind);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
