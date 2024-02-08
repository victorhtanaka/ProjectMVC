using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

[Authorize]
public class ConsultaController : Controller
{
    private readonly ProjectContext _db;

    public ConsultaController(ProjectContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult IndexFilialMais()
    {
        return View(new DateFilter());
    }
    public IActionResult GetFilialMais(DateFilter Dates)
    {
        ViewData["Vendas"] = _db.Vendas.ToList();
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Filiais"] = _db.Filiais.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();
        ViewData["Dates"] = Dates;
        return View();
    }

    public IActionResult IndexFilialVendas()
    {
        return View(new DateFilter());
    }

    public IActionResult GetFilialVendas(DateFilter Dates)
    {
        ViewData["Vendas"] = _db.Vendas.ToList();
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Filiais"] = _db.Filiais.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();
        ViewData["Dates"] = Dates;
        return View();
    }

    public IActionResult IndexFuncionarioMais()
    {
        return View(new DateFilter());
    }

    public IActionResult GetFuncionarioMais(DateFilter Dates)
    {
        ViewData["Vendas"] = _db.Vendas.ToList();
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Filiais"] = _db.Filiais.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();
        ViewData["Dates"] = Dates;
        return View();
    }

    public IActionResult IndexModeloMais()
    {
        return View(new DateFilter());
    }

    public IActionResult GetModeloMais(DateFilter Dates)
    {
        ViewData["Vendas"] = _db.Vendas.ToList();
        ViewData["Clientes"] = _db.Clientes.ToList();
        ViewData["Filiais"] = _db.Filiais.ToList();
        ViewData["Carros"] = _db.Carros.ToList();
        ViewData["Funcionarios"] = _db.Funcionarios.ToList();
        ViewData["Dates"] = Dates;
        return View();
    }

    
}