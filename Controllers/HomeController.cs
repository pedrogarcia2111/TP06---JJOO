using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06___JJOO.Models;

namespace TP06___JJOO.Controllers;

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

    public IActionResult Deportes()
    {

    }

    public IActionResult Paises()
    {

    }

    public IActionResult VerDetalleDeporte(int idDeporte)
    {
        
    }
}
