using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lokko.Models;

namespace Lokko.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Contact()
        {
            return View();
        }
    public IActionResult Privacy()
    {
        return View();
    }
     public IActionResult Hakkimizda()
    {
        return View();
    }

    public IActionResult Franchise()
    {
        return View();
    }

    public IActionResult Urunler()
    {
        return View();
    }
     public IActionResult Basvuruonay()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
