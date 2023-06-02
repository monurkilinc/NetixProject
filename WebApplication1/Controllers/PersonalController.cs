using BussinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.Excel;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NetixProject1.Models;


namespace NetixProject1.Controllers
{
    public class PersonalController : Controller
    {
        private readonly IPersonalService personalservice;
        private readonly IComputerService computerservice;

        public PersonalController(IComputerService computerservice, IPersonalService personalservice)
        {
            this.personalservice = personalservice;
            this.computerservice = computerservice;
        }
        public IActionResult Index()
        {
            var values = personalservice.GetListAll();
            var model = new ComputerPersonalViewModel
            {
                Personals = values,
            };
            return View(model);
        }
        public IActionResult PersonalListDashboard()
        {
            
            var com=computerservice.GetListAll();
            var model = new ComputerPersonalViewModel
            {
                Computers=com,
              
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult AddPersonel([FromRoute] int id)
        {
            var values = personalservice.GetListAll(id);
            var model = new ComputerPersonalViewModel
            {
                Personals = (ICollection<Personal>)values,
            };
            return View(model);
        }
    
        [HttpPost]
        public IActionResult AddPersonel(Personal p)
        {
            personalservice.TAdd(p);
            return RedirectToAction("PersonalListDashboard");
        }
        [HttpGet]
        public IActionResult DeletePersonel([FromRoute] int id)
        {
            var values = personalservice.TGetById(id);
            personalservice.TDelete(values);
            return RedirectToAction("PersonalListDashboard");
        }
        [HttpGet]
        public IActionResult EditPersonel(int id)
        {
            var personel = personalservice.GetListAll(id);
            var model = new ComputerPersonalViewModel
            {
                Personal = personel,
                
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditPersonel(Personal p)
        {
              personalservice.TUpdate(p);
              return RedirectToAction("PersonalListDashboard");
        }
        public ActionResult PersonalComputerDifference()
        {
            var viewModel = new ComputerPersonalViewModel() 
            {
                Computers = computerservice.GetEmtyComputer(),
                Personals = personalservice.PersonalComputerDifference()
            };
            return View(viewModel);
        }
    }   
}