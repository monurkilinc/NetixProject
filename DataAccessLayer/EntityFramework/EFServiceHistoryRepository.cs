using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFServiceHistoryRepository:GenericRepository<ServiceHistory>, IServiceHistoryDAL
    {
       
        public ServiceHistory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ServiceHistory> GetListAll()
        {
            using (var c = new Context())
            {
                var res = c.ServiceHistories.ToList();
                return res;
            }
        }

        async Task<List<ServiceHistory>> IServiceHistoryDAL.GetDeletedServices()
        {
            using (var c = new Context())
            { 
                return await c.ServiceHistories.OrderByDescending(sh => sh.ServiceId).ToListAsync();
            }
        }
    }

}
