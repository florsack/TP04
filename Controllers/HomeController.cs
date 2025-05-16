using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Ahorcado.inicializarAhorcado();
        ViewBag.Palabra = Ahorcado.palabra;
        ViewBag.intentosRestantes= 10 - Ahorcado.intentos;
        ViewBag.sonIguales = false;
        ViewBag.letrasEncontradas = Ahorcado.letrasEncontradas;
        ViewBag.letras = Ahorcado.letras;
        return View();
    }
    public IActionResult Ingresos(string l, string p){
        ViewBag.letras = Ahorcado.letras;
        Ahorcado.chequearLetra(l);
        ViewBag.letrasEncontradas = Ahorcado.letrasEncontradas;
        ViewBag.Palabra = Ahorcado.palabra;
        if (Ahorcado.chequearPalabra(p) == true){
            return RedirectToAction("Ganador");
        }
        ViewBag.intentosRestantes= 10 - Ahorcado.intentos;
        if (Ahorcado.intentos >= 10)
        {
            return RedirectToAction("Perdedor");
        }
        return View("Index");
    }
    
    public IActionResult Perdedor(){
        ViewBag.Palabra = Ahorcado.palabra;
        return View("Perdedor");
    }
    public IActionResult Ganador(){
        
        return View("Ganador");
    }
}