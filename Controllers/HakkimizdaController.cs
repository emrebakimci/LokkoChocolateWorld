using Microsoft.AspNetCore.Mvc;

namespace Lokko.Controllers
{
    public class HakkimizdaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }
    }
}