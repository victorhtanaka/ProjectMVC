using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

[Authorize]
public class AgendaController : Controller
{
    private readonly ProjectContext _db;

    public AgendaController(ProjectContext db)
    {
        _db = db;
    }

    // READ
    public IActionResult Get()
    {
        var Agendas = _db.Agendas.ToList();
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();
        return View(Agendas);
    }

    public IActionResult GetInfo(int id)
    {

        var Agenda = _db.Agendas.Find(id);

        if (Agenda == null)
        {
            return NotFound();
        }
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();

        return View(Agenda);
    }

    // CREATE
    public IActionResult Create()
    {

        ViewData["Agenda"] = new Agenda();
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();

        return View();
    }

    [HttpPost]
    public IActionResult CriarAgenda(Agenda Agenda)
    {
        _db.Agendas.Add(Agenda);
        _db.SaveChanges();

        return RedirectToAction("Get");
    }

    // UPDATE
    public IActionResult Edit(int id)
    {
        var Agenda = _db.Agendas.Find(id);

        if (Agenda == null)
        {
            return NotFound();
        }
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();

        return View(Agenda);
    }

    [HttpPost]
    public IActionResult EditarAgenda(Agenda Agenda)
    {
        if (ModelState.IsValid)
        {
            var FuncAntigo = _db.Agendas.Find(Agenda.CodAgenda);
            _db.Entry(FuncAntigo).CurrentValues.SetValues(Agenda);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Edit", Agenda);
    }

    // DELETE
    public IActionResult Delete(int id)
    {
        var Agenda = _db.Agendas.Find(id);

        if (Agenda == null)
        {
            return NotFound();
        }
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();

        return View(Agenda);
    }

    public IActionResult DeletarAgenda(Agenda Agenda)
    {
        if (ModelState.IsValid)
        {
            var item = _db.Agendas.Find(Agenda.CodAgenda);
            _db.Agendas.Remove(item);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Delete", Agenda);
    }
}
