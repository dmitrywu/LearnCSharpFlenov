using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using V1E14.Models;

namespace V1E14.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        FileUploadToDb fileUploadToDb = new FileUploadToDb();
        fileUploadToDb.UploadFile("data.txt", "Hello world");
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
