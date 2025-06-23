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
            string correo = CorreoLogueado();
            if (correo == null)
            {
                return RedirectToAction("Login", "Login");
            }

            try
            {
                ViewBag.Pasaje = s.Pasaje;
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Error al cargar los pasajes: " + ex.Message;
                return View();
            }
       
        }


        [HttpGet]
        
        public IActionResult VerPasajes()
        {
            string correo = CorreoLogueado();
            if (correo == null)
            {
                return RedirectToAction("Login", "Login");
            }

            try
            {
                ViewBag.Pasaje = s.PasajesOrdenadosFecha();
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Error al cargar pasajes: " + ex.Message;
            return View();

            }
        }


        [HttpGet]
        public IActionResult Comprar(string numeroVuelo)
        {
            string correo = CorreoLogueado();
            if (correo == null)
            {
                return RedirectToAction("Login", "Login");
            }

            try
            {
                Vuelo vuelo = s.ObtenerVueloPorNumero(numeroVuelo);

                if (vuelo == null)
                {
                    ViewBag.Mensaje = "Vuelo no encontrado.";
                    return RedirectToAction("VerVuelos", "Vuelo");
                }

                ViewBag.Vuelo = vuelo;
                ViewBag.Frecuencias = vuelo.Frecuencia;
                ViewBag.FechasDisponibles = vuelo.ObtenerProximasFechasDisponibles();

                return View("Comprar", vuelo);
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Error al cargar la compra: " + ex.Message;
            return View();
                
            }
        }


        [HttpPost]
        public IActionResult ConfirmarCompra(string numeroVuelo, DateTime fecha, string tipoEquipaje)
        {
            string corrreo = CorreoLogueado();
            if (corrreo == null)
            {
                return RedirectToAction("Login", "Login");
            }

            try
            {
                Vuelo vuelo = s.ObtenerVueloPorNumero(numeroVuelo);
                if (vuelo == null)
                {
                    ViewBag.Mensaje = "Vuelo no encontrado.";
                    ViewBag.ColorMensaje = "red";
                    return RedirectToAction("VerVuelos", "Vuelo");
                }

                if (!vuelo.contieneFrecuencia(fecha.DayOfWeek))
                {
                    ViewBag.Mensaje = "No hay vuelos ese día.";
                    ViewBag.ColorMensaje = "red";
                    ViewBag.Vuelo = vuelo;
                    ViewBag.Frecuencias = vuelo.Frecuencia;
                    return View("Comprar", vuelo);
                }

                TipoEquipaje tipo = TipoEquipaje.ligth;
                if (tipoEquipaje == "cabina") tipo = TipoEquipaje.cabina;
                else if (tipoEquipaje == "bodega") tipo = TipoEquipaje.bodega;

                string correo = HttpContext.Session.GetString("correo");
                Cliente clienteLogueado = s.ObtenerCliente(correo);

                Pasaje nuevo = new Pasaje(0, vuelo, fecha, clienteLogueado, tipo, 0);
                decimal precioCalculado = nuevo.CalcularPrecio();
                nuevo.Precio = precioCalculado;

                s.AgregarPasaje(nuevo);

                ViewBag.Mensaje = "Pasaje comprado con éxito. Precio: $" + precioCalculado.ToString("F2");
                ViewBag.ColorMensaje = "green";
            }
            catch (Exception e)
            {
                ViewBag.ColorMensaje = "red";
                ViewBag.Mensaje = "Error: " + e.Message;
            }

            ViewBag.Vuelo = s.ObtenerVueloPorNumero(numeroVuelo);
            ViewBag.Frecuencias = ViewBag.Vuelo?.Frecuencia;

            return View("Comprar", ViewBag.Vuelo);
        }




        public IActionResult VerPasajesComprados()
        {
            string corrreo = CorreoLogueado();
            if (corrreo == null)
            {
                return RedirectToAction("Login", "Login");
            }

            try
            {
                string correo = HttpContext.Session.GetString("correo");
                Cliente clienteLogueado = s.ObtenerCliente(correo);

                if (clienteLogueado == null)
                {
                    ViewBag.Mensaje = "Cliente no encontrado.";
                    return View("Error");
                }

                List<Pasaje> pasajesCliente = s.PasajesOrdenadosDescPrecio(correo);
                ViewBag.Pasajes = pasajesCliente;

                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Error al obtener los pasajes: " + ex.Message;
            return View();

            }
        }


        public IActionResult VerPasajesCompradosFecha()
        {
            string corrreo = CorreoLogueado();
            if (corrreo == null)
            {
                return RedirectToAction("Login", "Login");
            }

            try
            {
                string correo = HttpContext.Session.GetString("correo");
                Administrador adminLogueado = s.ObtenerAdmin(correo);

                if (adminLogueado == null)
                {
                    return RedirectToAction("Login", "Login");
                }

                List<Pasaje> pasajesOrdenados = s.PasajesOrdenadosFecha();
                ViewBag.PasajesFecha = pasajesOrdenados;

                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Error al mostrar los pasajes: " + ex.Message;
            return View();

            }
        }


        private string CorreoLogueado()
        {
            return HttpContext.Session.GetString("correo");
        }
    }
}