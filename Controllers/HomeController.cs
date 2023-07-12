using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fooli.Models;

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
    var googleMapsApiKey = Environment.GetEnvironmentVariable("GoogleMapsApiKey");

    // Create an instance of the List model and populate other properties
    var list = new List
    {
    };

    // Pass the model and the API key to the view
    ViewBag.GoogleMapsApiKey = googleMapsApiKey;
    return View(list);
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
