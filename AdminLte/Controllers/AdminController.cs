using Microsoft.AspNetCore.Mvc;

namespace AdminLte.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
