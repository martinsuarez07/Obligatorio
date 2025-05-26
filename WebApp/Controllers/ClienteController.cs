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
            ViewBag.Mensaje = "Alta exitosa";
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
            } catch (Exception ex) {
                ViewBag.Mensaje = ex.Message;
                return View();
            }
            ViewBag.Cliente = s.Cliente;
            return RedirectToAction("Index");
        }

    }
}


