using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

[Authorize]
public class FilialController : Controller
{
    private readonly ProjectContext _db;

    public FilialController(ProjectContext db)
    {
        _db = db;
    }

    // READ
    public IActionResult Get()
    {
        var filiais = _db.Filiais.ToList();
        return View(filiais);
    }

    public IActionResult GetInfo(int id)
    {

        var filial = _db.Filiais.Find(id);

        if (filial == null)
        {
            return NotFound();
        }
        ViewData["Filiais"] = _db.Filiais.ToList();
        ViewData["Funcoes"] = _db.Funcoes.ToList();

        return View(filial);
    }

    // CREATE
    public IActionResult Create()
    {
        return View(new Filial());
    }

    [HttpPost]
    public IActionResult CriarFilial(Filial filial)
    {
        if (ModelState.IsValid)
        {
            _db.Filiais.Add(filial);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }
        return View("Create", filial);
    }

    // UPDATE
    public IActionResult Edit(int id)
    {
        var filial = _db.Filiais.Find(id);

        if (filial == null)
        {
            return NotFound("Filial não encontrada");
        }

        return View(filial);
    }

    [HttpPost]
    public IActionResult EditarFilial(Filial filial)
    {
        if (ModelState.IsValid)
        {
            var FilialAntiga = _db.Filiais.Find(filial.CodFilial);
            _db.Entry(FilialAntiga).CurrentValues.SetValues(filial);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Edit", filial);
    }

    // DELETE
    public IActionResult Delete(int id)
    {
        var filial = _db.Filiais.Find(id);

        if (filial == null)
        {
            return NotFound();
        }
        ViewData["Filiais"] = _db.Filiais.ToList();
        ViewData["Funcoes"] = _db.Funcoes.ToList();

        return View(filial);
    }

    public IActionResult DeletarFilial(Filial filial)
    {
        if (ModelState.IsValid)
        {
            var item = _db.Filiais.Find(filial.CodFilial);
            _db.Filiais.Remove(item);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Delete", filial);
    }
}
