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
        return View();
    }

    // READ
    public IActionResult Get()
    {
        var funcionarios = _db.Funcionarios.ToList();
        return View(funcionarios);
    }

    // CREATE
    public IActionResult Create()
    {

        ViewData["Funcionario"] = new Funcionario();
        ViewData["Filiais"] = _db.Filiais.ToList();
        ViewData["Funcoes"] = _db.Funcoes.ToList();

        return View();
    }

    [HttpPost]
    public IActionResult CriarFuncionario(Funcionario funcionario)
    {
        _db.Funcionarios.Add(funcionario);
        _db.SaveChanges();

        return RedirectToAction("Index");
    }

    // UPDATE
    public IActionResult Edit(int id)
    {
        var funcionario = _db.Funcionarios.Find(id);

        if (funcionario == null)
        {
            return NotFound();
        }
        ViewData["Filiais"] = _db.Filiais.ToList();
        ViewData["Funcoes"] = _db.Funcoes.ToList();

        return View(funcionario);
    }

    [HttpPut]
    public IActionResult EditarFuncionario(Funcionario funcionario)
    {
        if (ModelState.IsValid)
        {
            _db.Funcionarios.Update(funcionario);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        return View("Editar", funcionario);
    }

    // DELETE
}
