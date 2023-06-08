using AutoMapper;
using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Office2010.Excel;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IMapper _mapper;
        private readonly IServiceDAL serviceDAL;
        private readonly IServiceHistoryDAL servicehistoryDAL;

        public ServiceManager(IServiceDAL ServiceDAL, IServiceHistoryDAL serviceHistoryDAL, IMapper mapper)
        {
            _mapper = mapper;
            servicehistoryDAL = serviceHistoryDAL;   
            serviceDAL = ServiceDAL;
        }
        public void TAdd(Service t)
        {
            serviceDAL.Insert(t);
        }
        public void TDelete(Service t)
        {
            serviceDAL.Delete(t);
        }
        public void TUpdate(Service t)
        {
            serviceDAL.Update(t);
        }

        public List<Service> GetAllPersonelList()
        {
            return serviceDAL.GetAllPersonelList();
        }
       
        Service IServiceService.GetComputerListByID(int id)
        {
            return serviceDAL.GetComputerListByID(id);
        }
        
        public Service TGetById(int id)
        {
            return serviceDAL.TGetById(id);
        }

        public Service GetListServiceAll(int id)
        {
            return serviceDAL.GetListServiceAll(id);
        }

        public List<Service> GetListAll()
        {
            return serviceDAL.GetListAll();
        }

        public Service GetListAll(int id)
        {
            return serviceDAL.GetListAll(id);
        }

        public void TAdd(ServiceHistory serviceHistory)
        {
            servicehistoryDAL.Insert(serviceHistory);
        }
    }
}
