using Microsoft.AspNetCore.Mvc;

namespace NetixProject.Controlles
{
    public class ComputerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
