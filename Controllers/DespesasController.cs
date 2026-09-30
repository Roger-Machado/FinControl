using FinControl.Data;
using FinControl.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinControl.Controllers
{
    public class DespesasController : Controller
    {
        private readonly FinControlContext _context;

        public DespesasController(FinControlContext context)
        {
            _context = context;
        }

        // LISTAR DESPESAS
        public IActionResult Index()
        {
            var despesas = _context.Despesas.ToList();

            return View(despesas);
        }

        // ABRIR TELA DE CADASTRO
        public IActionResult Create()
        {
            return View();
        }

        // SALVAR NOVA DESPESA
        [HttpPost]
        public IActionResult Create(Despesa despesa)
        {
            if (despesa.Valor <= 0)
            {
                ModelState.AddModelError(
                    nameof(despesa.Valor),
                    "O valor deve ser maior que zero."
                );
            }

            if (!ModelState.IsValid)
            {
                return View(despesa);
            }

            _context.Despesas.Add(despesa);
            _context.SaveChanges();

            TempData["Sucesso"] = "Despesa cadastrada com sucesso!";

            return RedirectToAction(nameof(Index));
        }

        // ABRIR TELA DE EDIÇÃO
        public IActionResult Edit(int id)
        {
            var despesa = _context.Despesas.Find(id);

            if (despesa == null)
            {
                return NotFound();
            }

            return View(despesa);
        }

        // SALVAR EDIÇÃO
        [HttpPost]
        public IActionResult Edit(Despesa despesa)
        {
            if (despesa.Valor <= 0)
            {
                ModelState.AddModelError(
                    nameof(despesa.Valor),
                    "O valor deve ser maior que zero."
                );
            }

            if (!ModelState.IsValid)
            {
                return View(despesa);
            }

            _context.Despesas.Update(despesa);
            _context.SaveChanges();

            TempData["Sucesso"] = "Despesa atualizada com sucesso!";

            return RedirectToAction(nameof(Index));
        }

        // ABRIR TELA DE CONFIRMAÇÃO DE EXCLUSÃO
        public IActionResult Delete(int id)
        {
            var despesa = _context.Despesas.Find(id);

            if (despesa == null)
            {
                return NotFound();
            }

            return View(despesa);
        }

        // EXCLUIR DO BANCO
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var despesa = _context.Despesas.Find(id);

            if (despesa != null)
            {
                _context.Despesas.Remove(despesa);
                _context.SaveChanges();

                TempData["Sucesso"] = "Despesa excluída com sucesso!";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}