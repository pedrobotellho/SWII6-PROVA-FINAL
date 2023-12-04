using Microsoft.AspNetCore.Mvc;
using SWII6_Prova2_WebSite.Models;
using SWII6_Prova2_WebSite.Services;
using System.Diagnostics;

namespace SWII6_Prova2_WebSite.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutoService _produtoService;

        public ProdutosController()
        {
            _produtoService = ProdutoService.getInstance();
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            var produtos = await _produtoService.GetAll();
            return View(produtos);
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var produto = await _produtoService.Get((int)id);
            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdutoModel produto)
        {
            if (ModelState.IsValid)
            {
                await _produtoService.Create(produto);
                return RedirectToAction(nameof(Index));
            }

            return View(produto);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var produto = await _produtoService.Get((int)id);

            if (produto == null)
                return NotFound();

            return View(produto);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProdutoModel produto)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _produtoService.Update(produto);
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var produto = await _produtoService.Get((int)id);

            if (produto == null)
                return NotFound();

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _produtoService.Get(id);
            if (produto != null)
            {
                await _produtoService.Delete(produto.Id);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}