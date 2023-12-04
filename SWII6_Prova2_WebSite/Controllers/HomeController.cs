using Microsoft.AspNetCore.Mvc;
using SWII6_Prova2_WebSite.Models;
using SWII6_Prova2_WebSite.Services;

namespace SWII6_Prova2_WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoginService _loginService;

        public HomeController()
        {
            _loginService = LoginService.getInstance(); ;
        }

        // GET: Home
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // POST: Home
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                var userId = await _loginService.Logar(usuario);
                _loginService.UsuarioId = userId;
                return RedirectToAction(nameof(Index));
            }

            return View(usuario);
        }
    }
}
