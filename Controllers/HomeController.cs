using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FinControl.Models;
using FinControl.Data;

namespace FinControl.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly FinControlContext _context;

    public HomeController(
    ILogger<HomeController> logger,
    FinControlContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        decimal totalReceitas = _context.Receitas
            .Sum(r => (decimal?)r.Valor) ?? 0;

        decimal totalDespesas = _context.Despesas
            .Sum(d => (decimal?)d.Valor) ?? 0;

        decimal saldoAtual = totalReceitas - totalDespesas;

        ViewBag.TotalReceitas = totalReceitas;
        ViewBag.TotalDespesas = totalDespesas;
        ViewBag.SaldoAtual = saldoAtual;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
