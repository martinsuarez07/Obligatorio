using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        Sistema _sistema = Sistema.Instancia;
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ingresar(string correo, string password)
        {

            if (string.IsNullOrEmpty(correo))
            {
                ViewBag.ErrorMessage = "Ingresar correo electrónico";
                return View();
            }

            if (string.IsNullOrEmpty(password))
            {

                ViewBag.ErrorMessage = "Ingresar contrasenia";
                return View();
            }


            try
            {
                Cliente unC = _sistema.ObtenerClientes(correo, password);
                if (unC == null)
                {
                    ViewBag.ErrorMessage = "Usuario y/o password incorrecto";
                }

                HttpContext.Session.SetString("correo", unC.Correo);
                HttpContext.Session.SetString("password", unC.Password);

                if (unC is Cliente cliente)
                {
                    HttpContext.Session.SetString("rol", "cliente");
                    return Redirect("/");

                }
                else
                {
                    HttpContext.Session.SetString("ClienteCorreo", correo);
                    return Redirect("/");

                }

            }
            catch (Exception e)
            {

                ViewBag.mensaje = e.Message;
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
