using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFComputerRepository : GenericRepository<Computer>, IComputerDAL
    {
        public List<Computer> GetEmtyComputer()
        {
            using (var c = new Context())
            {
                var rep = c.Computers.ToList();
                return rep;
            }
        }
        Computer IComputerDAL.GetListAll(int id)
        {
            using(var c= new Context())
            {
                var rep=c.Computers.Where(x=>x.ComputerId==id).FirstOrDefault();
                return rep;
            }
        }
        
    }
}
