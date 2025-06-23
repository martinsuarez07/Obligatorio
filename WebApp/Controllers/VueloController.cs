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

            try
            {
                List<Vuelo> v = s.Vuelo;
                ViewBag.Vuelo = v;
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Error al cargar los vuelos: " + ex.Message;
                ViewBag.ColorMensaje = "red";
                ViewBag.Vuelo = new List<Vuelo>();
            }

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

            try
            {
                ViewBag.Vuelo = s.Vuelo;
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Error al cargar los vuelos: " + ex.Message;
                ViewBag.ColorMensaje = "red";
             
            }

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

            try
            {
                var vuelosFiltrados = s.BuscarVuelosPorRuta(codOrigen, codDestino);
                ViewBag.VuelosFiltrados = vuelosFiltrados;

                if (vuelosFiltrados.Count == 0)
                {
                    ViewBag.Mensaje = "No se encontraron vuelos para esa ruta.";
                    ViewBag.ColorMensaje = "orange";
                }
            }
            catch (Exception ex)
            {
                ViewBag.VuelosFiltrados = new List<Vuelo>();
                ViewBag.Mensaje = "Error al buscar vuelos: " + ex.Message;
                ViewBag.ColorMensaje = "red";
            }

            return View("BuscarRuta");
        }

        private string CorreoLogueado()
        {
            return HttpContext.Session.GetString("correo");
        }

    }
}