using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    
  public IActionResult Index()
        {
            discos.infoDiscos(); // Asegúrate de inicializar una sola vez en una app real
            ViewBag.discos = discos.canciones();
            return View(discos);

        }
    public IActionResult InformacionDisco(int id)
        {
            if (Grupo.albumes.ContainsKey(id))
            {
                ViewBag.albumes = Grupo.albumes[id];
              
            }

             return View("InformacionDisco",id);
        }
   
    }

   

