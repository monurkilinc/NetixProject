using Microsoft.AspNetCore.Mvc;

namespace NetixProject.Controlles
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult DashboardMenuBarPartial()
        {
            return PartialView();
        }
        public PartialViewResult DashboardPartial()
        {
            return PartialView();
        }
        public PartialViewResult DashboardRightPartial()
        {
            return PartialView();
        }
    }
}
