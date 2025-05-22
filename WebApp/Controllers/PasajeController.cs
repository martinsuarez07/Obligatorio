using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class PasajeController : Controller
    {
        Sistema s = Sistema._instancia;
        public IActionResult Index()
        {
            List<Pasaje> p = s.Pasaje;
            ViewBag.Pasaje = p;
            return View();
        }

        public IActionResult VerPasajes()
        {
             return View();
        }
        public IActionResult VerPasajes(int id, Vuelo vuelo, DateTime fecha, Cliente cliente, TipoEquipaje tipo, decimal precio)
        {
            ViewBag.Pasaje = s.Pasaje;
            return View();
        }
    }
}
