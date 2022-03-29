using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DockerEssentials.Models;

namespace DockerEssentials.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepository _repository;
    private string message;

    public HomeController(
        ILogger<HomeController> logger,
        IRepository repository,
        IConfiguration config)
    {
        _logger = logger;
        _repository = repository;
        message = $"Docker - ({config["HOSTNAME"]})";
    }

    public IActionResult Index()
    {
        ViewBag.Message = message;
        return View(_repository.Produtos);
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
