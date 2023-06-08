using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceHistoryManager : IServiceHistoryService
    {
        private readonly IServiceHistoryDAL servicehistoryDAL;

        public ServiceHistoryManager(IServiceHistoryDAL serviceHistoryDAL)
        {
            servicehistoryDAL = serviceHistoryDAL;
        }

        public List<ServiceHistory> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ServiceHistory>> GetAllAsync()
        {
            return servicehistoryDAL.GetAllAsync();
        }

        public ServiceHistory GetById(int id)
        {
            return servicehistoryDAL.GetById(id);
        }

        public Task<List<ServiceHistory>> GetDeletedServices()
        {
            return servicehistoryDAL.GetDeletedServices();
        }

        public List<ServiceHistory> GetListAll()
        {
            return servicehistoryDAL.GetListAll();
        }

        public ServiceHistory GetListAll(int id)
        {
            return servicehistoryDAL.TGetById(id);
        }

        public void TAdd(ServiceHistory t)
        {
            servicehistoryDAL.Insert(t);
        }

        public void TDelete(ServiceHistory t)
        {
            throw new NotImplementedException();
        }

        public ServiceHistory TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ServiceHistory t)
        {
            throw new NotImplementedException();
        }
    }
}
