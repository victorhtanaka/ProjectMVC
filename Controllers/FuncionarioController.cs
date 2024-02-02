using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

public class FuncionarioController : Controller
{
    private readonly ProjectContext _db;

    public FuncionarioController(ProjectContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var funcionarios = _db.Funcionarios.ToList();
        return View(funcionarios);
    }

    public IActionResult Create()
    {

        ViewData["Funcionario"] = new Funcionario();
        ViewData["Filiais"] = _db.Filiais.ToList();

        return View();
    }

    [HttpPost]
    public IActionResult CriarFuncionario(Funcionario funcionario)
    {
        _db.Funcionarios.Add(funcionario);
        _db.SaveChanges();

        return RedirectToAction("Index");
    }
}
