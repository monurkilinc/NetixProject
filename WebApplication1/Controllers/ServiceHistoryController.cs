using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetixProject1.Models;

namespace NetixProject1.Controllers
{
    public class ServiceHistoryController : Controller
    {
        private readonly IServiceHistoryService servicehistoryservice;

        public ServiceHistoryController(IServiceHistoryService serviceHistoryService)
        {
            servicehistoryservice = serviceHistoryService;
        }
        public async Task<IActionResult> Index()
        {
            var serviceHistories = servicehistoryservice.GetListAll();
            var deletedServices = await servicehistoryservice.GetDeletedServices();
            var viewModel = new ComputerPersonalViewModel
            {
                ServiceHistories = serviceHistories,
                DeletedServices = deletedServices
            };
            return View(viewModel);
        }
    }
}
