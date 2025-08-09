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
                ViewData["Mensaje"] = "Contacto enviado correctamente.";
                return View("Index");
            }

            // Si el modelo no es válido, se regresa a la vista con los errores.
            return View("Index", contacto);
        }
    }
}