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
            
            var values = personalservice.GetListDetailAll();
            var com=computerservice.GetListAll();
            var model = new ComputerPersonalViewModel
            {
                Personals= values,
                Computers=com,
              
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult AddPersonel([FromRoute] int id)
        {
            var viewModel = new ComputerPersonalViewModel()
            {
                Personals = personalservice.PersonalComputerDifference(),
                Computers = computerservice.GetEmptyComputer()
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult AddPersonel(Personal p, int computerId)
        {
           
            p.ComputerId = computerId;
            personalservice.TAdd(p);
            return RedirectToAction("PersonalListDashboard");
        }
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
           
            var currentComputer = personel.Computer;
            var availableComputers = computerservice.GetEmptyComputer().ToList();
            availableComputers.Add(currentComputer);
            var model = new ComputerPersonalViewModel
            {
                Personal = personel,
                Computers = availableComputers,
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditPersonel(Personal p,int computerId)
        {
            var computer = computerservice.TGetById(computerId);
            p.Computer = computer;
            personalservice.TUpdate(p);
            return RedirectToAction("PersonalListDashboard");
        }
    }   
}