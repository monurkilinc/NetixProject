using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IServiceHistoryService : IGenericService<ServiceHistory>
    {
        List<ServiceHistory> GetListAll();
        ServiceHistory GetById(int id);
        Task<List<ServiceHistory>> GetDeletedServices();
        Task<IEnumerable<ServiceHistory>> GetAllAsync();
        List<Service> GetAllPersonelList();
    }
}
