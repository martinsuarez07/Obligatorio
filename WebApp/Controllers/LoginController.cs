using Dominio;
using Microsoft.AspNetCore.Mvc;

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
        // Validaciones básicas
        if (string.IsNullOrEmpty(correo))
        {
            ViewBag.ErrorMessage = "Ingresar correo electrónico";
            return View();
        }

        if (string.IsNullOrEmpty(password))
        {
            ViewBag.ErrorMessage = "Ingresar contraseña";
            return View();
        }

        try
        {
            Usuario unU = _sistema.LoguinRetUsuario(password, correo);

            if (unU == null)
            {
                ViewBag.ErrorMessage = "Usuario y/o contraseña incorrectos";
                return View();
            }

            // Guardar en sesión
            HttpContext.Session.SetString("correo", unU.Correo);
            HttpContext.Session.SetString("password", unU.Password);

            if (unU is Cliente)
            {
                HttpContext.Session.SetString("rol", "cliente");
                return RedirectToAction("VerVuelos", "Vuelo");
            }
            else
            {
                HttpContext.Session.SetString("rol", "administrador");
                return RedirectToAction("VerPasajesCompradosFecha", "Pasaje");
            }
        }
        catch (Exception e)
        {
            ViewBag.ErrorMessage = "Ocurrió un error inesperado: " + e.Message;
            return View();
        }
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }
}
