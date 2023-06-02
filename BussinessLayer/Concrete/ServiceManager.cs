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
        private readonly IServiceDAL serviceDAL;
        
        public ServiceManager(IServiceDAL ServiceDAL)
        {
            
            this.serviceDAL = ServiceDAL;
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
       
        public List<Service> GetComputerListByID(int id)
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
            throw new NotImplementedException();
        }

        public Service GetListAll(int id)
        {
            throw new NotImplementedException();
        }
    }
}
