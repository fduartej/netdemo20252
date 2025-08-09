using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using netdemo.Models;

namespace netdemo.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Enviar(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                // Aquí puedes manejar el envío del formulario, como guardar en una base de datos o enviar un correo electrónico.
                ViewBag.Mensaje = "Formulario enviado correctamente.";
                return View("Index");
            }

            // Si el modelo no es válido, vuelve a mostrar el formulario con los errores.
            return View("Index", contacto);
        }
    }
}