using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EJ5.Models;

namespace EJ5.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Verificar(int edad, string estadoLaboral, int ingresoEconomico,int monto, string poseeDeudas,string confirmacion)
    {
        if(edad>= 18 && estadoLaboral =="si" && ingresoEconomico>= 250000 && monto > (ingresoEconomico*5) && poseeDeudas=="no" && confirmacion == "aceptar"){
            return View("Aceptado");
        }
        else{
              return View("Rechazado");
        }
      
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
