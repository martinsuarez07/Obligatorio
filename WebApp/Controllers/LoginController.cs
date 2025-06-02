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
        public IActionResult Login(string correo, string password)
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
                Usuario unU = _sistema.LoguinRetUsuario(password, correo);
                if (unU == null)
                {
                    ViewBag.ErrorMessage = "Usuario y/o password incorrecto";
                }
                else
                {
                    HttpContext.Session.SetString("correo", unU.Correo);
                    HttpContext.Session.SetString("password", unU.Password);
                    if (unU is Cliente cliente)
                    {
                        HttpContext.Session.SetString("rol", "cliente");
                        return Redirect("Vuelo/VerVuelos");

                    }
                    else
                    {
                        HttpContext.Session.SetString("rol", "administrador");
                        return Redirect("Pasaje/VerPasajes");

                    }
                }
                return View();
               
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
