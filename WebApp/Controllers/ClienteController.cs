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

            try
            {
                List<Cliente> clientes = s.GetClientes();
                ViewBag.Cliente = clientes;
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Error al cargar clientes: " + ex.Message;
                return View();
            }
          
        }

        [HttpGet]
        public IActionResult RegistrarClienteOcacional()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult RegistrarClienteOcacional(string ci, string nombre, string correo, string password, string nacionalidad)
        {
           
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
            string correoSesion = CorreoLogueado();
            if (correoSesion == null)
            {
                return RedirectToAction("Login", "Login");
            }

            try
            {
                string correo = HttpContext.Session.GetString("correo");
                string contra = HttpContext.Session.GetString("password");

                Cliente unU = (Cliente)s.LoguinRetUsuario(contra, correo);

                if (unU == null)
                {
                    ViewBag.Mensaje = "No se encontró el usuario.";
                    return View("Error");
                }

                return View(unU);
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                return View();
            }
            
        }


        public IActionResult VerClienteCi()
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

                List<Cliente> clienteOrdenados = s.GetClientes();
                clienteOrdenados.Sort();

                return View(clienteOrdenados);
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Error al mostrar los clientes: " + ex.Message;
               
            }
            return View("Error");
        }



        [HttpPost]
        [HttpPost]
        public IActionResult EditarCliente(string ci, int? nuevoPunto)
        {
            string correo = CorreoLogueado();
            if (correo == null)
            {
                return RedirectToAction("Login", "Login");
            }

            try
            {
                Cliente cliente = s.ObtenerClientePorCi(ci);

                if (cliente == null)
                {
                    ViewBag.Mensaje = "Cliente no encontrado.";
                    return View("Error");
                }

                if (cliente is Ocacional o)
                {
                    o.CambiarEstadoRegalo();
                }
                else if (cliente is Premium p)
                {
                    if (nuevoPunto != null && nuevoPunto > 0)
                    {
                        p.EditarPuntos(nuevoPunto.Value);
                    }
                }

                return RedirectToAction("VerClienteCi");
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = "Error al editar cliente: " + ex.Message;
                return View();
            }
          
        }

        private string CorreoLogueado()
        {
            return HttpContext.Session.GetString("correo");
        }


    }
}


