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
            List<Cliente> clientes = s.GetClientes();
            ViewBag.Cliente = clientes;
          
            return View();
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
            string correo = HttpContext.Session.GetString("correo");
            string contra = HttpContext.Session.GetString("password");
            Cliente unU = (Cliente)s.LoguinRetUsuario(contra, correo);
            return View(unU);
        }
    }
}


