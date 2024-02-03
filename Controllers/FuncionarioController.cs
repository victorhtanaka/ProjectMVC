using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

public class FuncionarioController : Controller
{
    private readonly ProjectContext _db;

    public FuncionarioController(ProjectContext db)
    {
        _db = db;
    }

    // READ
    public IActionResult Get()
    {
        var funcionarios = _db.Funcionarios.ToList();
        return View(funcionarios);
    }

    public IActionResult GetInfo(int id)
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

        return RedirectToAction("Get");
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

    [HttpPost]
    public IActionResult EditarFuncionario(Funcionario funcionario)
    {
        if (ModelState.IsValid)
        {
            var FuncAntigo = _db.Funcionarios.Find(funcionario.CodFuncionario);
            _db.Entry(FuncAntigo).CurrentValues.SetValues(funcionario);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Edit", funcionario);
    }

    // DELETE
    public IActionResult Delete(int id)
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

    public IActionResult DeletarFuncionario(Funcionario funcionario)
    {
        if (ModelState.IsValid)
        {
            var item = _db.Funcionarios.Find(funcionario.CodFuncionario);
            _db.Funcionarios.Remove(item);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Delete", funcionario);
    }
}
