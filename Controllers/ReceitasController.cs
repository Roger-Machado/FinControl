using Microsoft.AspNetCore.Mvc;

namespace FinControl.Controllers
{
    public class ReceitasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}