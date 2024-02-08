using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

[Authorize]
public class RelatorioController : Controller
{
    private readonly ProjectContext _db;

    public RelatorioController(ProjectContext db)
    {
        _db = db;
    }

    // READ
    public IActionResult Get()
    {
        var Relatorios = _db.Relatorios.ToList();
        return View(Relatorios);
    }

    public IActionResult GetInfo(int id)
    {
        var Relatorio = _db.Relatorios.Find(id);

        if (Relatorio == null)
        {
            return NotFound();
        }
        ViewData["Agenda"] = _db.Agendas.Find(Relatorio.FkAgendaCodAgenda);
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();
        ViewData["Servicos"] = _db.Servicos.ToList();

        return View(Relatorio);
    }

    // CREATE
    public IActionResult Create(int id)
    {
        ViewData["CodAgenda"] = id;
        return View(new Relatorio());
    }

    [HttpPost]
    public IActionResult CriarRelatorio(Relatorio Relatorio)
    {
        if (ModelState.IsValid)
        {
            _db.Relatorios.Add(Relatorio);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Create", Relatorio);
    }

    // UPDATE
    public IActionResult Edit(int id)
    {
        var Relatorio = _db.Relatorios.Find(id);

        if (Relatorio == null)
        {
            return NotFound();
        }

        return View(Relatorio);
    }

    [HttpPost]
    public IActionResult EditarRelatorio(Relatorio Relatorio)
    {
        if (ModelState.IsValid)
        {
            var FuncAntigo = _db.Relatorios.Find(Relatorio.CodRelatorio);
            _db.Entry(FuncAntigo).CurrentValues.SetValues(Relatorio);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }
        
        return View("Edit", Relatorio);
    }

    // DELETE
    public IActionResult Delete(int id)
    {
        var Relatorio = _db.Relatorios.Find(id);

        if (Relatorio == null)
        {
            return NotFound();
        }

        return View(Relatorio);
    }

    public IActionResult DeletarRelatorio(Relatorio Relatorio)
    {
        if (ModelState.IsValid)
        {
            var item = _db.Relatorios.Find(Relatorio.CodRelatorio);
            _db.Relatorios.Remove(item);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Delete", Relatorio);
    }
}
