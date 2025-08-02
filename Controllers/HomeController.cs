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
        return View(NewCliente());
    }

    private static Cliente NewCliente()
    {
        List<Curso> cursos = new List<Curso>();
        Cliente cliente = new Cliente();
        cliente.Cursos = cursos;
        return cliente;
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Registrar(String nombre)
    {
        ViewData["mensaje1"] = "Hola como estas bienvenido " +nombre;
        return View("Index", NewCliente());
    }

    public IActionResult RegistrarCliente(Cliente cliente)
    {
        if (ModelState.IsValid)
        {
            ViewData["mensaje2"] = "Hola como estas bienvenido como has estado " + cliente.Nombre + " " + cliente.Apellido;
            List<Curso> cursos = new List<Curso>();
            Curso curso = new Curso();
            curso.Nombre = "Curso de Programación1";
            curso.Descripcion = "Aprende los conceptos básicos de la programación 1.";
            curso.Duracion = 5;
            cursos.Add(curso);

            curso = new Curso();
            curso.Nombre = "Curso de Programación2";
            curso.Descripcion = "Aprende los conceptos básicos de la programación 2.";
            curso.Duracion = 6;
            cursos.Add(curso);

            cliente.Cursos = cursos;
        }

        return View("Index", cliente);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
