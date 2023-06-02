using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NetixProject1.Models;

namespace NetixProject1.Controllers
{
    public class ComputerController : Controller
    {
        private readonly IComputerService computerservice;
        private readonly IPersonalService personalservice;
        public ComputerController(IComputerService computerservice, IPersonalService personalservice)
        {
            this.personalservice = personalservice;
            this.computerservice = computerservice;
        }
        public IActionResult Index()
        {
            var values = computerservice.GetListAll();
            var model = new ComputerPersonalViewModel
            {
                Computers =values,
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult AddComputer([FromRoute] int id)
        {   
            var values=computerservice.GetListAll(id);
            var model = new ComputerPersonalViewModel
            {
                Computers = (ICollection<Computer>)values,
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddComputer(Computer p)
        {
            computerservice.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteComputer([FromRoute] int id)
        {
            var values = computerservice.GetListAll(id);
            computerservice.TDelete(values);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditComputer(int id)
        {
            var values = computerservice.GetListAll(id);
            var model = new ComputerPersonalViewModel
            {
                Computer =values,
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditComputer(Computer p)
        {
            computerservice.TUpdate(p);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            var computer = computerservice.GetEmtyComputer();
            var viewModel = new ComputerPersonalViewModel()
            {
                Computers = computer,
            };
            ViewBag.ViewModel = viewModel;
            return View(viewModel);
        }
    }
}