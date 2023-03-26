using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RickAndMorty.Database;
using RickAndMorty.Database.Interface;
using RickAndMorty.WebApplication.Extensions;
using RickAndMorty.WebApplication.Models;

namespace RickAndMorty.WebApplication.Controllers;

public class CharacterController : Controller
{
    private readonly IRepository _repository;

    public CharacterController()
    {
        _repository = new Repository();
        _repository.InitializeDatabase();
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(CharacterModel character)
    {
        _repository.Save(character.Map());
        return Redirect("~/");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
