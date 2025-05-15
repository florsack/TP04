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
        ViewBag.letrasEncontradas = Ahorcado.letrasEncontradas;
        ViewBag.letras = Ahorcado.letras;
<<<<<<< HEAD
=======
        return View();
    }
    public IActionResult Ingresos(string l, string p){
        ViewBag.palabra = p;
        ViewBag.sonPalabrasIguales = Ahorcado.chequearPalabra(p);
        Ahorcado.chequearLetra(l);
        ViewBag.letrasEncontradas = Ahorcado.letrasEncontradas;
>>>>>>> b34eca8735b409e22a94fbee673e320a8128b83d
        return View();
    }
    public IActionResult Ingresos(string l, string p){
        ViewBag.palabra = p;
        ViewBag.sonPalabrasIguales = Ahorcado.chequearPalabra(p);
        Ahorcado.chequearLetra(l);
        ViewBag.letrasEncontradas = Ahorcado.letrasEncontradas;
        return View();
    }
}