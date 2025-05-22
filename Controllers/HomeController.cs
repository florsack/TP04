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
        Ahorcado juego = new Ahorcado();
        juego.inicializarAhorcado();
        HttpContext.Session.SetString("juego", objeto.ObjectToString(juego));
        ViewBag.Palabra = juego.palabra;
        ViewBag.intentosRestantes= 9 - juego.intentos;
        ViewBag.ingresosMalos = juego.ingresosMalos;
        ViewBag.sonIguales = false;
        ViewBag.letrasEncontradas = juego.letrasEncontradas;
        ViewBag.letras = juego.letras;
        return View();
    }
    public IActionResult Ingresos(string l, string p){
        Ahorcado juego = objeto.StringToObject<Ahorcado>(HttpContext.Session.GetString("juego"));
        ViewBag.letras = juego.letras;
        juego.chequearLetra(l);
        ViewBag.letrasEncontradas = juego.letrasEncontradas;
        ViewBag.ingresosMalos = juego.ingresosMalos;
        ViewBag.Palabra = juego.palabra;
        if (juego.chequearPalabra(p) == true){
            return RedirectToAction("Ganador");
        }
        ViewBag.intentosRestantes= 9 - juego.intentos;
        if (juego.intentos >= 9)
        {
            return RedirectToAction("Perdedor");
        }
        HttpContext.Session.SetString("juego", objeto.ObjectToString(juego));
        return View("Index");
    }
    
    public IActionResult Perdedor(){
        Ahorcado juego = objeto.StringToObject<Ahorcado>(HttpContext.Session.GetString("juego"));
        ViewBag.Palabra = juego.palabra;
        return View("Perdedor");
    }
    public IActionResult Ganador(){
        return View("Ganador");
    }
}