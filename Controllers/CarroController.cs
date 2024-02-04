using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

public class CarroController : Controller
{
    private readonly ProjectContext _db;

    public CarroController(ProjectContext db)
    {
        _db = db;
    }

    // READ
    public IActionResult Get()
    {
        var carros = _db.Carros.ToList();
        return View(carros);
    }

    public IActionResult GetInfo(int id)
    {

        var carro = _db.Carros.Find(id);

        if (carro == null)
        {
            return NotFound();
        }
        ViewData["Filiais"] = _db.Filiais.ToList();

        return View(carro);
    }

    // CREATE
    public IActionResult Create()
    {

        ViewData["Carro"] = new Carro();
        ViewData["Filiais"] = _db.Filiais.ToList();

        return View();
    }

    [HttpPost]
    public IActionResult CriarCarro(Carro carro)
    {
        _db.Carros.Add(carro);
        _db.SaveChanges();

        return RedirectToAction("Get");
    }

    // UPDATE
    public IActionResult Edit(int id)
    {
        var carro = _db.Carros.Find(id);

        if (carro == null)
        {
            return NotFound();
        }
        ViewData["Filiais"] = _db.Filiais.ToList();

        return View(carro);
    }

    [HttpPost]
    public IActionResult EditarCarro(Carro carro)
    {
        if (ModelState.IsValid)
        {
            var CarroAntigo = _db.Carros.Find(carro.CodCarro);
            _db.Entry(CarroAntigo).CurrentValues.SetValues(carro);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Edit", carro);
    }

    // DELETE
    public IActionResult Delete(int id)
    {
        var carro = _db.Carros.Find(id);

        if (carro == null)
        {
            return NotFound();
        }
        ViewData["Filiais"] = _db.Filiais.ToList();

        return View(carro);
    }

    public IActionResult DeletarCarro(Carro carro)
    {
        if (ModelState.IsValid)
        {
            var item = _db.Carros.Find(carro.CodCarro);
            _db.Carros.Remove(item);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Delete", carro);
    }
}