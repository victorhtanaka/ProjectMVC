using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers;

[Authorize]
public class SalarioController : Controller
{
    private readonly ProjectContext _db;

    public SalarioController(ProjectContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        return View(new DateFilter());
    }

    public IActionResult Get(DateFilter Dates)
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