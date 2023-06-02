using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using DocumentFormat.OpenXml.Office2010.Excel;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFPersonalRepository : GenericRepository<Personal>, IPersonalDAL
    {
        Personal IPersonalDAL.GetListAll(int id)
        {
            using (var c = new Context())
            { 
                var rep=c.Personals.Include(x => x.Computer).Where(predicate: y => y.PersonalId == id).FirstOrDefault();
                return rep;
            }
        }

        Personal IPersonalDAL.GetID(int id)
        {
            using (var c = new Context())
            {
                return c.Personals.Include(x => x.Computer).Where(predicate: y => y.PersonalId == id).FirstOrDefault();
            }
        }

        public List<Personal> GetListDetailAll()
        {
            using (var c = new Context())
            {
                return c.Personals.Include(x => x.Computer).ToList();
            }
        }

        List<Personal> IPersonalDAL.GetListDetailAll()
        {
            using (var c = new Context())
            {
                return c.Personals.Include(x => x.Computer).ToList();
            }
        }

        List<Personal> IPersonalDAL.PersonalComputerDifference()
        {
            using (var c = new Context())
            {
                var test = c.Personals
                   .Include(x => x.Computer)
                   .ToList();

                var personalIds = c.Personals
                    .Include(x=>x.Computer)
                    .Select(x => x.PersonalId)
                    .ToList();

                return c.Personals.Where(x => !personalIds.Contains(x.PersonalId)).ToList();
            }
        }
    }
}
