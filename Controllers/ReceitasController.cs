using FinControl.Data;
using FinControl.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinControl.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly FinControlContext _context;

        public ReceitasController(FinControlContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var receitas = _context.Receitas.ToList();

            return View(receitas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Receita receita)
        {
            _context.Receitas.Add(receita);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}