using Microsoft.AspNetCore.Mvc;
using Dominio;

namespace WebApp.Controllers
{
    public class ClienteController : Controller
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
            List<Cliente> clientes = s.GetClientes();
            ViewBag.Cliente = clientes;
          
            return View();
        }
        [HttpGet]
        public IActionResult RegistrarClienteOcacional()
        {
            string correo = CorreoLogueado();
            if (correo == null)
            {
                return RedirectToAction("Login", "Login");
            }
            return View();
        }
        [HttpPost]
        public IActionResult RegistrarClienteOcacional(string ci, string nombre, string correo, string password, string nacionalidad)
        {
            string corrreo = CorreoLogueado();
            if (corrreo == null)
            {
                return RedirectToAction("Login", "Login");
            }
            try
            {
                Ocacional o = new Ocacional(ci, nombre, correo, password, nacionalidad);
                s.AgregarCliente(o);
                ViewBag.Mensaje = "Alta exitosa";
            } catch (Exception ex) {
                ViewBag.Mensaje = ex.Message;
                return View();
            }
            ViewBag.Cliente = s.Cliente;
            return RedirectToAction("Login", "Login");
        }
         public IActionResult VerPerfil()
        {
            string corrreo = CorreoLogueado();
            if (corrreo == null)
            {
                return RedirectToAction("Login", "Login");
            }
            string correo = HttpContext.Session.GetString("correo");
            string contra = HttpContext.Session.GetString("password");
            Cliente unU = (Cliente)s.LoguinRetUsuario(contra, correo);
            return View(unU);
        }

        public IActionResult VerClienteCi()
        {
            string corrreo = CorreoLogueado();
            if (corrreo == null)
            {
                return RedirectToAction("Login", "Login");
            }
            string correo = HttpContext.Session.GetString("correo");
            Administrador adminLogueado = s.ObtenerAdmin(correo);

            if (adminLogueado == null)
            {
                return RedirectToAction("Login", "Login");
            }

            // Obtener y ordenar los clientes por su cédula
            List<Cliente> clienteOrdenados = s.GetClientes();
            clienteOrdenados.Sort(); //  CompareTo de la clase Cliente

            return View(clienteOrdenados); // Pasar el modelo a la vista
        }

    
        [HttpPost]
        public IActionResult EditarCliente(string ci, int? nuevoPunto)
        {
            string correo = CorreoLogueado();
            if (correo == null)
            {
                return RedirectToAction("Login", "Login");
            }
            Cliente cliente = s.ObtenerClientePorCi(ci);
            if (cliente is Ocacional o)
            {
                o.CambiarEstadoRegalo(); // Alternar true/false
            }
            else if (cliente is Premium p)
            {
                if (nuevoPunto != null && nuevoPunto > 0)
                {
                    p.EditarPuntos(nuevoPunto.Value); // Método que agregaremos abajo
                }
            }

            return RedirectToAction("VerClienteCi");
        }
        private string CorreoLogueado()
        {
            return HttpContext.Session.GetString("correo");
        }


    }
}


