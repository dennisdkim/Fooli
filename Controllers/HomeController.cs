using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fooli.Models;
using DotNetEnv;


namespace Fooli.Controllers;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;

  public HomeController(ILogger<HomeController> logger)
  {
    _logger = logger;
  }

  public IActionResult Index()
  {
    DotNetEnv.Env.Load(); // Load the environment variables from the .env file

    var googleMapsApiKey = DotNetEnv.Env.GetString("GoogleMapsApiKey");
    ViewData["GoogleMapsApiKey"] = googleMapsApiKey;
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
