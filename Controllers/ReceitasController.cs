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

        // MÉTODO PARA ABRIR A TELA DE EDIÇÃO
        public IActionResult Edit(int id)
        {
            var receita = _context.Receitas.Find(id);

            if (receita == null)
            {
                return NotFound();
            }

            return View(receita);
        }

        // MÉTODO PARA SALVAR A EDIÇÃO
        [HttpPost]
        public IActionResult Edit(Receita receita)
        {
            if (ModelState.IsValid)
            {
                _context.Receitas.Update(receita);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(receita);
        }

        // MÉTODO PARA EXIBIR A TELA DE CONFIRMAÇÃO
        public IActionResult Delete(int id)
        {
            var receita = _context.Receitas.Find(id);

            if (receita == null)
            {
                return NotFound();
            }

            return View(receita);
        }

        // MÉTODO PARA EXCLUIR DO BANCO
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var receita = _context.Receitas.Find(id);

            if (receita != null)
            {
                _context.Receitas.Remove(receita);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}