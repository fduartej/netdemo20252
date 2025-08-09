using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using netdemo.Models;

namespace netdemo.Controllers;


public class CalcController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Operation(string operacion,int a, int b)
    {
        int result = 0;

        switch (operacion)
        {
            case "sumar":
                result = a + b;
                break;
            case "restar":
                result = a - b;
                break;
            case "multiplicar":
                result = a * b;
                break;
            case "dividir":
                result = a / b;
                break;
            default:
                return BadRequest("Operación no válida");
        }

        return View("Index", result);
    }
}