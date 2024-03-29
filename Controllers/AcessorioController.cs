using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

public class AcessorioController : Controller
{
    private readonly ProjectContext _db;

    public AcessorioController(ProjectContext db)
    {
        _db = db;
    }

    // READ
    public IActionResult Get()
    {
        var acessorios = _db.Acessorios.ToList();
        return View(acessorios);
    }

    public IActionResult GetInfo(int id)
    {

        var acessorio = _db.Acessorios.Find(id);

        if (acessorio == null)
        {
            return NotFound();
        }

        return View(acessorio);
    }

    // CREATE
    public IActionResult Create()
    {
        return View(new Acessorio());
    }

    [HttpPost]
    public IActionResult CriarAcessorio(Acessorio acessorio)
    {
        if (ModelState.IsValid) 
        {
            _db.Acessorios.Add(acessorio);
            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                ViewData["uniqueAlert"] = "Nome do acessório existente";
                return View("Create", acessorio);
            }

            return RedirectToAction("Get");
        }
        return View("Create", acessorio);
    }

    // UPDATE
    public IActionResult Edit(int id)
    {
        var acessorio = _db.Acessorios.Find(id);

        if (acessorio == null)
        {
            return NotFound("Acessorio não encontrado");
        }

        return View(acessorio);
    }

    [HttpPost]
    public IActionResult EditarAcessorio(Acessorio acessorio)
    {
        if (ModelState.IsValid)
        {
            var AcessorioAntigo = _db.Acessorios.Find(acessorio.CodAcessorio);
            _db.Entry(AcessorioAntigo).CurrentValues.SetValues(acessorio);
            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                ViewData["uniqueAlert"] = "Nome do acessório existente";
                return View("Edit", acessorio);
            }

            return RedirectToAction("Get");
        }

        return View("Edit", acessorio);
    }

    // DELETE
    public IActionResult Delete(int id)
    {
        var acessorio = _db.Acessorios.Find(id);

        if (acessorio == null)
        {
            return NotFound();
        }

        return View(acessorio);
    }

    public IActionResult DeletarAcessorio(Acessorio acessorio)
    {
        if (ModelState.IsValid)
        {
            var item = _db.Acessorios.Find(acessorio.CodAcessorio);
            _db.Acessorios.Remove(item);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Delete", acessorio);
    }
}
