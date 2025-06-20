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
            string correo = CorreoLogueado();
            if (correo == null)
            {
                return RedirectToAction("Login", "Login");
            }
            List<Vuelo> v = s.Vuelo;
            ViewBag.Vuelo = v;
            return View();
        }
        [HttpGet]
        public IActionResult VerVuelos()
        {
            string correo = CorreoLogueado();
            if (correo == null)
            {
                return RedirectToAction("Login", "Login");
            }
            ViewBag.Vuelo = s.Vuelo;
            return View();
        }

        

        public IActionResult BuscarRuta()
        {
            string correo = CorreoLogueado();
            if (correo == null)
            {
                return RedirectToAction("Login", "Login");
            }
            return View();
        }

        [HttpPost]
        public IActionResult BuscarPorRuta(string codOrigen, string codDestino)
        {
            string correo = CorreoLogueado();
            if (correo == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var vuelosFiltrados = s.BuscarVuelosPorRuta(codOrigen, codDestino);
            ViewBag.VuelosFiltrados = vuelosFiltrados;
            return View("BuscarRuta");
        }
        private string CorreoLogueado()
        {
            return HttpContext.Session.GetString("correo");
        }

    }
}