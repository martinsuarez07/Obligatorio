using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class VueloController : Controller
    {
        Sistema s = Sistema._instancia;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VerVuelos()
        {
            return View();
        }
    }
}
