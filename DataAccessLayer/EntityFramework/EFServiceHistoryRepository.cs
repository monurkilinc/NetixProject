using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using DocumentFormat.OpenXml.InkML;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context = DataAccessLayer.Concrete.Context;

namespace DataAccessLayer.EntityFramework
{
    public class EFServiceHistoryRepository : GenericRepository<ServiceHistory>, IServiceHistoryDAL
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
                if (res != null)
                {
                    return res;
                }
                else
                {
                    return new List<ServiceHistory>();
                }
            }
        }
        async Task<List<ServiceHistory>> IServiceHistoryDAL.GetDeletedServices()
        {
            using (var c = new Context())
            {
                return await c.ServiceHistories.OrderByDescending(sh => sh.ServiceId).ToListAsync();
            }
        }
        public async Task<IEnumerable<ServiceHistory>> GetAllAsync()
        {
            using (var c = new Context())
            { 
                return await c.ServiceHistories.ToListAsync();
            }
        }

    }

}
