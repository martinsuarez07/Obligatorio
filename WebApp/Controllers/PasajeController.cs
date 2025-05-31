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
        [HttpGet]
        public IActionResult Comprar(string numeroVuelo)
        {
            Vuelo vuelo = null;
            foreach (Vuelo v in s.Vuelo)
            {
                if (v.NumeroVuelo == numeroVuelo)
                {
                    vuelo = v;
                    break;
                }
            }

            if (vuelo == null)
            {
                ViewBag.Mensaje = "Vuelo no encontrado.";
                return RedirectToAction("VerVuelos", "Vuelo");
            }

            ViewBag.Vuelo = vuelo;
            return View();
        }

        [HttpPost]
        public IActionResult Comprar(string numeroVuelo, DateTime fecha, TipoEquipaje tipoEquipaje)
        {
            Vuelo vuelo = null;
            foreach (Vuelo v in s.Vuelo)
            {
                if (v.NumeroVuelo == numeroVuelo)
                {
                    vuelo = v;
                    break;
                }
            }

            if (vuelo == null)
            {
                ViewBag.Mensaje = "Vuelo no encontrado.";
                return RedirectToAction("VerVuelos", "Vuelo");
            }

            if (!vuelo.contieneFrecuencia(fecha.DayOfWeek))
            {
                ViewBag.Mensaje = "No hay vuelos ese día.";
            }
            else
            {
                ViewBag.Mensaje = "¡Puedes comprar el pasaje para esa fecha!";
            }

            ViewBag.Vuelo = vuelo;
            return View();
        }
      
        
    }
}
