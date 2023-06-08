using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IServiceHistoryDAL : IGenericDAL<ServiceHistory>
    {
        ServiceHistory GetById(int id);
        List<ServiceHistory> GetListAll();
        Task<List<ServiceHistory>> GetDeletedServices();
        Task<IEnumerable<ServiceHistory>> GetAllAsync();
    }
}
