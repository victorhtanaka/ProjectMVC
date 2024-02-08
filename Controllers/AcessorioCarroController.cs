using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

public class AcessorioCarroController : Controller
{
    private readonly ProjectContext _db;

    public AcessorioCarroController(ProjectContext db)
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
        ViewData["Acessorios"] = _db.Acessorios.ToList();
        ViewData["AcessoriosCarros"] = _db.AcessoriosCarros.ToList();
        return View(carro);
    }

    // CREATE
    public IActionResult Create(int id)
    {

        var carro = _db.Carros.Find(id);
        if (carro == null)
        {
            return NotFound();
        }

        ViewData["Acessorios"] = _db.Acessorios.ToList();
        ViewData["Carro"] = carro;
        return View(new AcessorioCarro());
    }

    [HttpPost]
    public IActionResult CriarAcessorioCarro(AcessorioCarro acessorioCarro)
    {
        _db.AcessoriosCarros.Add(acessorioCarro);
        _db.SaveChanges();

        return RedirectToAction("Get");
    }

    // DELETE
    public IActionResult Delete(int id)
    {

        var acessorioCarro = _db.AcessoriosCarros.Find(id);

        if (acessorioCarro == null)
        {
            return NotFound();
        }

        ViewData["Acessorios"] = _db.Acessorios.ToList();
        ViewData["Carro"] = _db.Carros.Find(acessorioCarro.FkCarroCodCarro);

        return View(acessorioCarro);
    }

    public IActionResult DeletarAcessorioCarro(AcessorioCarro acessorioCarro)
    {
        _db.AcessoriosCarros.Remove(acessorioCarro);
        _db.SaveChanges();

        return RedirectToAction("Get");
    }
}
