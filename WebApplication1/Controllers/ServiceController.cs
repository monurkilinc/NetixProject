using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using DataAccessLayer.Concrete;
using NetixProject1.Models;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.InkML;
using BusinessLayer.Abstract;
using AutoMapper;

namespace NetixProject1.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService serviceService;
        private readonly IPersonalService personalService;
        private readonly IComputerService computerService;
        private readonly IServiceHistoryService serviceHistoryService;
        private readonly IMapper _mapper;

        public ServiceController(IServiceService serviceservice, IPersonalService personalservice, IComputerService computerservice, IServiceHistoryService servicehistoryservice, IMapper mapper)
        {
            _mapper=mapper;
            serviceService = serviceservice;
            personalService = personalservice;
            computerService = computerservice;
            serviceHistoryService = servicehistoryservice;
        }
        public IActionResult Index()
        {
            var per = personalService.GetListAll();
            var values = serviceService.GetAllPersonelList();
            var model = new ComputerPersonalViewModel
            {
                Personals = per,
                Services = values,
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult AddService(int id)
        {
            var values = serviceService.GetAllPersonelList();
            var model = new ComputerPersonalViewModel
            {
                Services = values,
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddService(Service p, int id)
        {
            var computer = computerService.TGetById(id);
            p.ComputerId = computer.ComputerId;
            serviceService.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteServiceAsync(int id)
        {
            var service =serviceService.GetComputerListByID(id);
            var serviceHistory = _mapper.Map<ServiceHistory>(service);
            serviceHistoryService.TAdd(serviceHistory);
            serviceService.TDelete(service);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService([FromRoute] int id)
        {
            var personel = personalService.GetPersonalByComputerId(id);
            var values = serviceService.GetComputerListByID(id);
            var model = new ComputerPersonalViewModel
            {
                Personal = personel,
                Service = values,

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditService(Service p)
        {
            serviceService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}

