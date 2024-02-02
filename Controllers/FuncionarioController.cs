using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

public class FuncionarioController : Controller
{
    private ProjectContext _db;

    public FuncionarioController(ProjectContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var funcionarios = _db.Funcionarios.ToList();
        return View(funcionarios);
    }
}