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
        ViewBag.sonIguales = false;
        ViewBag.letrasEncontradas = Ahorcado.letrasEncontradas;
        ViewBag.letras = Ahorcado.letras;
        return View();
    }
    public IActionResult Ingresos(string l, string p){
        ViewBag.Palabra = Ahorcado.palabra;
        ViewBag.sonIguales = Ahorcado.chequearPalabra(p);
        ViewBag.letras = Ahorcado.letras;
        Ahorcado.chequearLetra(l);
        ViewBag.letrasEncontradas = Ahorcado.letrasEncontradas;
        return View("Index");
    }
    public IActionResult Ganador(){
        return View("Ganador");
    }
}