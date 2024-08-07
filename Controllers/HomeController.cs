using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mi_Web_Personal_Individual.Models;

namespace Mi_Web_Personal_Individual.Controllers;

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

    public IActionResult Gusta()
    { 
        ViewBag.Imagenes = ContactoClase.Imagenes;
        ViewBag.Titulos =ContactoClase.Titulos;
        ViewBag.Texto = ContactoClase.Textos;
        
        return View();
    }
    public IActionResult Contacto( )
    {
      
        
        return View();
    }
    public IActionResult GuardarContacto(string Nombre, string Apellido, string Email, string Region){
       
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
