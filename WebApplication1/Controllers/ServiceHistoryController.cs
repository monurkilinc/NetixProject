using BusinessLayer.Abstract;
using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetixProject1.Models;

namespace NetixProject1.Controllers
{
    public class ServiceHistoryController : Controller
    {
        private readonly IServiceHistoryService servicehistoryservice;
        private readonly IServiceService serviceservice;

        public ServiceHistoryController(IServiceHistoryService serviceHistoryService, IServiceService serviceService)
        {
            servicehistoryservice = serviceHistoryService;
            serviceservice = serviceService;
        }
        public async Task<IActionResult> Index()
        {
            var serviceHistories = servicehistoryservice.GetListAll();
            var deletedServices = await servicehistoryservice.GetDeletedServices();
            var service = serviceservice.GetAllPersonelList();
            //var comtoper=serviceservice.GetAllPersonelList();

            var viewModel = new ComputerPersonalViewModel
            {
                Services=service,
                ServiceHistories = serviceHistories,
                DeletedServices = deletedServices
            };
            return View(viewModel);
        }
    }
}
