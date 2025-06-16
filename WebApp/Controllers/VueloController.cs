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
            string mensaje = s.ComprarVuelo(numeroVuelo);
            ViewBag.Mensaje = mensaje;
            ViewBag.Vuelo = s.Vuelo;
            return View("VerVuelos");
        }

        public IActionResult BuscarRuta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BuscarPorRuta(string codOrigen, string codDestino)
        {
            var vuelosFiltrados = s.BuscarVuelosPorRutas(codOrigen, codDestino);
            ViewBag.VuelosFiltrados = vuelosFiltrados;
            return View("BuscarRuta");
        }


    }
}