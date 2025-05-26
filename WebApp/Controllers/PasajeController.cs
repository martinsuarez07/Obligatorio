using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class PasajeController : Controller
    {
        Sistema s = Sistema.Instancia;
        [HttpGet]
        public IActionResult Index()
        {
            List<Pasaje> p = s.Pasaje;
            ViewBag.Pasaje = p;
            return View();
        }
        [HttpGet]
        public IActionResult VerPasajes()
        {
            ViewBag.Pasaje = s.Pasaje;
            return View();
        }
        
        
    }
}
