using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06___JJOO.Models;

namespace TP06.Models;

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
        List<Deporte> deportes = BD.ListarDeportes();
        
        ViewBag.Deportes = deportes;
        
        return View();
    }

        public IActionResult Paises()
        {
            List<Pais> paises = BD.ListarPaises();
            ViewBag.Paises = paises;
            return View();
        }

        public IActionResult VerDetalleDeporte(int idDeporte)
        {
            Deporte deporte = BD.VerInfoDeporte(idDeporte);
            List<Deportista> deportistas = BD.ListarDeportistasxDeporte(idDeporte);

            ViewBag.Deporte = deporte;
            ViewBag.Deportistas = deportistas;
            return View();
        }

        public IActionResult VerDetallePais(int idPais)
        {
            Pais pais = BD.VerInfoPais(idPais);
            List<Deportista> deportistas = BD.ListarDeportistasxPais(idPais);

            ViewBag.Pais = pais;
            ViewBag.Deportistas = deportistas;
            return View();
        }

        public IActionResult VerDetalleDeportista(int idDeportista)
        {
            Deportista deportista = BD.VerInfoDeportista(idDeportista);
            ViewBag.Deportista = deportista;
            return View();
        }

        public IActionResult AgregarDeportista()
{
    List<Deporte> deportes = BD.ListarDeportes(); 
    List<Pais> paises = BD.ListarPaises();
    
    ViewBag.Deportes = deportes;
    ViewBag.Paises = paises;
    
    return View();
}

[HttpPost]
public IActionResult GuardarDeportista(Deportista deportista)
{
    BD.AgregarDeportista(deportista);
    
    return RedirectToAction("Index");
}


       public IActionResult EliminarDeportista(int idCandidato)
{
    BD.EliminarDeportista(idCandidato);

    List<Pais> paises = BD.ListarPaises();
    ViewBag.Paises = paises;

    return View("Index");
}

        public IActionResult Creditos()
        {
            return View();
        }

    public IActionResult Historia()
    {
        return View();
    }
    }

    

