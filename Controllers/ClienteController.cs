using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

public class ClienteController : Controller
{
    private readonly ProjectContext _db;

    public ClienteController(ProjectContext db)
    {
        _db = db;
    }

    // READ
    public IActionResult Get()
    {
        var Clientes = _db.Clientes.ToList();
        return View(Clientes);
    }

    public IActionResult GetInfo(int id)
    {

        var Cliente = _db.Clientes.Find(id);

        if (Cliente == null)
        {
            return NotFound();
        }

        return View(Cliente);
    }

    // CREATE
    public IActionResult Create()
    {

        return View();
    }

    [HttpPost]
    public IActionResult CriarCliente(Cliente Cliente)
    {
        _db.Clientes.Add(Cliente);
        _db.SaveChanges();

        return RedirectToAction("Get");
    }

    // UPDATE
    public IActionResult Edit(int id)
    {
        var Cliente = _db.Clientes.Find(id);

        if (Cliente == null)
        {
            return NotFound();
        }

        return View(Cliente);
    }

    [HttpPost]
    public IActionResult EditarCliente(Cliente Cliente)
    {
        if (ModelState.IsValid)
        {
            var FuncAntigo = _db.Clientes.Find(Cliente.CodCliente);
            _db.Entry(FuncAntigo).CurrentValues.SetValues(Cliente);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Edit", Cliente);
    }

    // DELETE
    public IActionResult Delete(int id)
    {
        var Cliente = _db.Clientes.Find(id);

        if (Cliente == null)
        {
            return NotFound();
        }

        return View(Cliente);
    }

    public IActionResult DeletarCliente(Cliente Cliente)
    {
        if (ModelState.IsValid)
        {
            var item = _db.Clientes.Find(Cliente.CodCliente);
            _db.Clientes.Remove(item);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Delete", Cliente);
    }
}