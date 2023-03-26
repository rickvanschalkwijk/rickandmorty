using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RickAndMorty.Database;
using RickAndMorty.Database.Interface;
using RickAndMorty.WebApplication.Extensions;
using RickAndMorty.WebApplication.Models;

namespace RickAndMorty.WebApplication.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepository _repository;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _repository = new Repository();
        _repository.InitializeDatabase();
    }

    public IActionResult Index()
    {
        var characters = _repository.GetAll();
        ViewData["Characters"] = characters.Map();
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
