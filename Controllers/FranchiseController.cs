using Microsoft.AspNetCore.Mvc;
using Lokko.Models;

namespace Lokko.Controllers
{
    public class FranchiseController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Franchise(FranchiseModel model)
        {
            return View(model);
        }
    }
}
