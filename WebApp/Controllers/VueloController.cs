using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class VueloController : Controller
    {
        Sistema s = Sistema.Instancia;

        [HttpGet]
        public IActionResult Index()
        {
            List<Vuelo> v = s.Vuelo;
            ViewBag.Vuelo = v;
            return View();
        }
        [HttpGet]
        public IActionResult VerVuelos()
        {
            ViewBag.Vuelo = s.Vuelo;
            return View();
        }

        [HttpPost]
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

            if (vuelo != null)
            {
                // Lógica de compra del vuelo
                ViewBag.Mensaje = $"¡Compra realizada para el vuelo {vuelo.NumeroVuelo}!";
            }
            else
            {
                ViewBag.Mensaje = "No se encontró el vuelo.";
            }

            ViewBag.Vuelo = s.Vuelo;
            return View("VerVuelos");
        }
        public IActionResult BuscarRuta()
        {
            return View();
        }

    }
}
