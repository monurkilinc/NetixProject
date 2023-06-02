using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace NetixProject.Controlles
{
    public class PersonalController : Controller
    {
        private readonly IPersonalService personalService;
       
        public PersonalController(IPersonalService PersonalService)
        {
            this.personalService = PersonalService;
        }
        public IActionResult Index()
        {
            var values = personalService.GetList();
            return View(values);
        }
        public IActionResult PersonalListDashboard() 
        {
            var values= personalService.GetComputerlListDashboard( );
            return View(values); 
        }
        [HttpGet]
        public IActionResult DeletePersonel([FromRoute] int id)
        {
            var values = personalService.TGetById(id);
            personalService.TDelete(values);
            return RedirectToAction("PersonalListDashboard");
        }
        [HttpGet]
        public IActionResult EditPersonel([FromRoute]int id)
        {
            var values=personalService.TGetById(id);
            personalService.TUpdate(values);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPersonel(Personal p)
        {
            personalService.TUpdate(p);
            return RedirectToAction("PersonalListDashboard");
        }
    }
}