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

namespace NetixProject1.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService serviceService;
        private readonly IPersonalService personalService;
        private readonly IComputerService computerService;

       
        public ServiceController(IServiceService serviceService, IPersonalService personalService, IComputerService computerService)
        {
            this.serviceService = serviceService;
            this.personalService = personalService;
            this.computerService = computerService;
           
        }
        public IActionResult Index()
        {
            var per=personalService.GetListAll();
            var values=serviceService.GetAllPersonelList();
            var model = new ComputerPersonalViewModel
            {
                Personals=per,
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
        public IActionResult AddService(Service p,int id)
        {
            var computer = computerService.TGetById(id);
            p.ComputerId = computer.ComputerId; 
            serviceService.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteService([FromRoute]int id)
        {
            var values = serviceService.TGetById(id);
            var serviceHistory = new ServiceHistory()  
            {
                ServiceId = values.ServiceId,
                ServiceWorker = values.ServiceWorker,
                ServiceDelayStatus = values.ServiceDelayStatus,
                DeviceStatus = values.DeviceStatus,
                DeviceServiceReason = values.DeviceServiceReason,
                DeviceChangingParts = values.DeviceChangingParts,
                DeviceDateEntry = values.DeviceDateEntry,
                DeviceDeliverEntry = values.DeviceDeliverEntry,
                DeviceProcessingTime = values.DeviceProcessingTime,
               
            };

            serviceService.TAdd(serviceHistory);
            values.ServisStatus = false;  
            serviceService.TUpdate(values);  
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

