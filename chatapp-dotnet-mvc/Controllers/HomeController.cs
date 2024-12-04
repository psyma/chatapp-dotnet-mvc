using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using chatapp_dotnet_mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace chatapp_dotnet_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
     
    public IActionResult Index()
    {
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