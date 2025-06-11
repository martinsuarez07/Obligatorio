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
            ViewBag.Pasaje = s.Pasaje;
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
            ViewBag.Frecuencias = vuelo.Frecuencia; // Mostrar los días disponibles
            ViewBag.FechasDisponibles = vuelo.ObtenerProximasFechasDisponibles();

            return View("Comprar", vuelo);
        }

        [HttpPost]
        public IActionResult ConfirmarCompra(string numeroVuelo, DateTime fecha, string tipoEquipaje)
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

            // Conversión del tipo de equipaje
            TipoEquipaje tipo = TipoEquipaje.ligth;
            if (tipoEquipaje == "cabina") tipo = TipoEquipaje.cabina;
            else if (tipoEquipaje == "bodega") tipo = TipoEquipaje.bodega;
            string correo = HttpContext.Session.GetString("correo");
            Cliente clienteLogueado = s.ObtenerCliente(correo);
            // Como no hay cliente logueado, se pasa null (el constructor debe permitirlo)
            Pasaje nuevo = new Pasaje(0, vuelo, fecha, clienteLogueado, tipo, 0);
            decimal precioCalculado = nuevo.CalcularPrecio();
            nuevo.Precio = precioCalculado;

            try
            {
                s.AgregarPasaje(nuevo);
                
                ViewBag.Mensaje = "Pasaje comprado con éxito. Precio: $" + precioCalculado.ToString("F2");
                ViewBag.ColorMensaje = "green";
            }
            catch (Exception e)
            {
                ViewBag.ColorMensaje = "red";
                ViewBag.Mensaje = "Error: " + e.Message;
            }

            ViewBag.Vuelo = vuelo;
            ViewBag.Frecuencias = vuelo.Frecuencia;

            return View("Comprar", vuelo);
        }

       
        private int CompararPorPrecioDescendente(Pasaje p1, Pasaje p2)
        {
            if (p1.Precio > p2.Precio)
                return -1;
            if (p1.Precio < p2.Precio)
                return 1;
            return 0;
        }
        public IActionResult VerPasajesComprados()
        {
            string correo = HttpContext.Session.GetString("correo");
            Cliente clienteLogueado = s.ObtenerCliente(correo);

            List<Pasaje> pasajesCliente = new List<Pasaje>();

            foreach (Pasaje p in s.Pasaje)
            {
                if (p.Cliente != null && clienteLogueado != null && p.Cliente.Correo == clienteLogueado.Correo)
                {
                    pasajesCliente.Add(p);
                }
            }

            pasajesCliente.Sort(CompararPorPrecioDescendente);

            ViewBag.Pasajes = pasajesCliente;
            return View();
        }
        private int CompararPorFecha(Pasaje p1, Pasaje p2)
        {
            if (p1.Fecha > p2.Fecha)
                return 1;
            if (p1.Fecha < p2.Fecha)
                return -1;
            return 0;
        }
        public IActionResult VerPasajesCompradosFecha()
        {
            string correo = HttpContext.Session.GetString("correo");
            Administrador adminLogueado = s.ObtenerAdmin(correo);

            if (adminLogueado == null)
            {
                return RedirectToAction("Login", "Login");
            }

            List<Pasaje> pasajesOrdenados = s.Pasaje;
            pasajesOrdenados.Sort(CompararPorFecha);

            ViewBag.PasajesFecha = pasajesOrdenados;
            return View();
        }

    }
}