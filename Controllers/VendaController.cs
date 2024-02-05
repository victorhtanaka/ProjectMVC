using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

public class VendaController : Controller
{
    private readonly ProjectContext _db;

    public VendaController(ProjectContext db)
    {
        _db = db;
    }

    // READ
    public IActionResult Get()
    {
        var Vendas = _db.Vendas.ToList();
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();
        return View(Vendas);
    }

    public IActionResult GetInfo(int id)
    {

        var Venda = _db.Vendas.Find(id);

        if (Venda == null)
        {
            return NotFound();
        }
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();

        return View(Venda);
    }

    // CREATE
    public IActionResult Create()
    {

        ViewData["Venda"] = new Venda();
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();

        return View();
    }

    [HttpPost]
    public IActionResult CriarVenda(Venda Venda)
    {
        _db.Vendas.Add(Venda);
        _db.SaveChanges();

        return RedirectToAction("Get");
    }

    // UPDATE
    public IActionResult Edit(int id)
    {
        var Venda = _db.Vendas.Find(id);

        if (Venda == null)
        {
            return NotFound();
        }
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();

        return View(Venda);
    }

    [HttpPost]
    public IActionResult EditarVenda(Venda Venda)
    {
        if (ModelState.IsValid)
        {
            var FuncAntigo = _db.Vendas.Find(Venda.CodVenda);
            _db.Entry(FuncAntigo).CurrentValues.SetValues(Venda);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Edit", Venda);
    }

    // DELETE
    public IActionResult Delete(int id)
    {
        var Venda = _db.Vendas.Find(id);

        if (Venda == null)
        {
            return NotFound();
        }
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();

        return View(Venda);
    }

    public IActionResult DeletarVenda(Venda Venda)
    {
        if (ModelState.IsValid)
        {
            var item = _db.Vendas.Find(Venda.CodVenda);
            _db.Vendas.Remove(item);
            _db.SaveChanges();

            return RedirectToAction("Get");
        }

        return View("Delete", Venda);
    }
}
