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
    infoDiscos.InicializarGrupo();  
    ViewBag.discos = infoDiscos.albumes; 
    return View();
}
public IActionResult InformacionDisco(int id)
        {
            if (infoDiscos.albumes.ContainsKey(id))
            {
                ViewBag.album = infoDiscos.albumes[id];
              
            }

             return View("InformacionDisco");
        }
   
   
    }

   

