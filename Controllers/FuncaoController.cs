using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

[Authorize]
public class FuncaoController : Controller
{
    private readonly ProjectContext _db;

    public FuncaoController(ProjectContext db)
    {
        _db = db;
    }

    // READ
    public IActionResult Get()
    {
        var Funcoes = _db.Funcoes.ToList();
        return View(Funcoes);
    }

    public IActionResult GetInfo(int id)
    {

        var Funcao = _db.Funcoes.Find(id);

        if (Funcao == null)
        {
            return NotFound();
        }

        return View(Funcao);
    }

    // CREATE
    public IActionResult Create()
    {
        return View(new Funcao());
    }

    [HttpPost]
    public IActionResult CriarFuncao(Funcao Funcao)
    {
        if (ModelState.IsValid)
        {
            _db.Funcoes.Add(Funcao);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }
        return View("Create", Funcao);
    }

    // UPDATE
    public IActionResult Edit(int id)
    {
        var Funcao = _db.Funcoes.Find(id);

        if (Funcao == null)
        {
            return NotFound("Funcao não encontrada");
        }

        return View(Funcao);
    }

    [HttpPost]
    public IActionResult EditarFuncao(Funcao Funcao)
    {
        if (ModelState.IsValid)
        {
            var FuncaoAntiga = _db.Funcoes.Find(Funcao.CodFuncao);
            _db.Entry(FuncaoAntiga).CurrentValues.SetValues(Funcao);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Edit", Funcao);
    }

    // DELETE
    public IActionResult Delete(int id)
    {
        var Funcao = _db.Funcoes.Find(id);

        if (Funcao == null)
        {
            return NotFound();
        }

        return View(Funcao);
    }

    public IActionResult DeletarFuncao(Funcao Funcao)
    {
        if (ModelState.IsValid)
        {
            var item = _db.Funcoes.Find(Funcao.CodFuncao);
            _db.Funcoes.Remove(item);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Delete", Funcao);
    }
}
