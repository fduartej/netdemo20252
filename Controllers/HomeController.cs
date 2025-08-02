using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using netdemo.Models;

namespace netdemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Registrar(String nombre)
    {
        ViewData["mensaje1"] = "Hola como estas bienvenido " +nombre;
        return View("Index");
    }

    public IActionResult RegistrarCliente(Cliente cliente)
    {
        if(ModelState.IsValid)
        {
            ViewData["mensaje2"] = "Hola como estas bienvenido como has estado " +cliente.Nombre + " " + cliente.Apellido;
        }
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
