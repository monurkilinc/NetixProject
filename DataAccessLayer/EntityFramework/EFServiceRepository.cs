﻿using DataAccessLayer.Abstract;
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
    public class EFServiceRepository : GenericRepository<Service>, IServiceDAL
    {
        public List<Service> GetAllPersonelList()
        {
            using (var c = new Context())
            {
                var res = c.Services.Include(s => s.Computer).ThenInclude(s => s.Personal).ToList();
                return res;
            }
        }
        
        public Service GetComputerListByID(int id)
        {
            using (var c = new Context())
            {
                var res = c.Services.Include(s => s.Computer).Where(s => s.ComputerId == id).FirstOrDefault();
                return res;
            }
        }

        Service IServiceDAL.GetListAll(int id)
        {
            using (var c = new Context())
            {
                var res = c.Services.Where(s => s.ServiceId == id).FirstOrDefault();
                return res;
            }
        }

        Service IServiceDAL.GetListServiceAll(int id)
        {
            using (var c = new Context())
            {
                var rep = c.Services.Where(x => x.ServiceId == id).FirstOrDefault();
                return rep;
            }
        }
    }
}
