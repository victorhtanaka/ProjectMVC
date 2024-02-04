using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

public class ServicoController : Controller
{
    private readonly ProjectContext _db;

    public ServicoController(ProjectContext db)
    {
        _db = db;
    }

    // READ
    public IActionResult Get()
    {
        var Servicos = _db.Servicos.ToList();
        return View(Servicos);
    }

    public IActionResult GetInfo(int id)
    {

        var Servico = _db.Servicos.Find(id);

        if (Servico == null)
        {
            return NotFound();
        }

        return View(Servico);
    }

    // CREATE
    public IActionResult Create()
    {

        ViewData["Servico"] = new Servico();

        return View();
    }

    [HttpPost]
    public IActionResult CriarServico(Servico Servico)
    {
        _db.Servicos.Add(Servico);
        _db.SaveChanges();

        return RedirectToAction("Get");
    }

    // UPDATE
    public IActionResult Edit(int id)
    {
        var Servico = _db.Servicos.Find(id);

        if (Servico == null)
        {
            return NotFound("Servico não encontrada");
        }

        return View(Servico);
    }

    [HttpPost]
    public IActionResult EditarServico(Servico Servico)
    {
        if (ModelState.IsValid)
        {
            var ServicoAntiga = _db.Servicos.Find(Servico.CodServico);
            _db.Entry(ServicoAntiga).CurrentValues.SetValues(Servico);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Edit", Servico);
    }

    // DELETE
    public IActionResult Delete(int id)
    {
        var Servico = _db.Servicos.Find(id);

        if (Servico == null)
        {
            return NotFound();
        }

        return View(Servico);
    }

    public IActionResult DeletarServico(Servico Servico)
    {
        if (ModelState.IsValid)
        {
            var item = _db.Servicos.Find(Servico.CodServico);
            _db.Servicos.Remove(item);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Delete", Servico);
    }
}
