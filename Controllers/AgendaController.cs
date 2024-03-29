using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        ViewData["Servicos"] = _db.Servicos.ToList();
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
        ViewData["Servicos"] = _db.Servicos.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();

        return View(Agenda);
    }

    // CREATE
    public IActionResult Create()
    {
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Servicos"] = _db.Servicos.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();
        ViewData["Filiais"] = _db.Filiais.ToList();

        return View(new Agenda());
    }

    [HttpPost]
    public IActionResult CriarAgenda(Agenda agenda)
    {
        if (ModelState.IsValid)
        {
            _db.Agendas.Add(agenda);
            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateException) 
            {
                ViewData["uniqueAlert"] = "Ja existe um agendamento com a mesma data e o mesmo funcionario";
                ViewData["Clientes"] = _db.Clientes.ToList();
                ViewData["Servicos"] = _db.Servicos.ToList();
                ViewData["Funcionarios"] = _db.Funcionarios.ToList();
                ViewData["Filiais"] = _db.Filiais.ToList();

                return View("Create", agenda);
            }

            return RedirectToAction("Get");
        }
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Servicos"] = _db.Servicos.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();
        ViewData["Filiais"] = _db.Filiais.ToList();

        return View("Create", agenda);
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
        ViewData["Servicos"] = _db.Servicos.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();
        ViewData["Filiais"] = _db.Filiais.ToList();

        return View(Agenda);
    }

    [HttpPost]
    public IActionResult EditarAgenda(Agenda Agenda)
    {
        if (ModelState.IsValid)
        {
            var FuncAntigo = _db.Agendas.Find(Agenda.CodAgenda);
            _db.Entry(FuncAntigo).CurrentValues.SetValues(Agenda);
            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateException) 
            {
                ViewData["uniqueAlert"] = "Ja existe um agendamento com a mesma data e o mesmo funcionario";
                ViewData["Clientes"] = _db.Clientes.ToList();
                ViewData["Servicos"] = _db.Servicos.ToList();
                ViewData["Funcionarios"] = _db.Funcionarios.ToList();
                ViewData["Filiais"] = _db.Filiais.ToList();

                return View("Edit", Agenda);
            }

            return RedirectToAction("Get");
        }
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Servicos"] = _db.Servicos.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();
        ViewData["Filiais"] = _db.Filiais.ToList();
        
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
        ViewData["Servicos"] = _db.Servicos.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();
        ViewData["Filiais"] = _db.Filiais.ToList();

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
