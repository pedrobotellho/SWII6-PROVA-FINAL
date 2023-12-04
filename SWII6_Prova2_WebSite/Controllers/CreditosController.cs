using Microsoft.AspNetCore.Mvc;
using SWII6_Prova2_WebSite.Models;
using SWII6_Prova2_WebSite.Services;

namespace SWII6_Prova2_WebSite.Controllers
{
    public class CreditosController : Controller
    {
        // GET: Creditos
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
