using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDAL adminDAL;

        public AdminManager(IAdminDAL AdminDAL)
        {
            adminDAL = AdminDAL;
        }
        public Admin GetListAll(int id)
        {
            return adminDAL.TGetById(id);
        }
        public List<Admin> GetList()
        {
           return adminDAL.GetListAll();
        }
        public List<Admin> GetList(int id)
        {
            throw new NotImplementedException();
        }
        public List<Admin> GetListAll()
        {
            throw new NotImplementedException();
        }
        public void TAdd(Admin t)
        {
            adminDAL.Insert(t);
        }
        public void TDelete(Admin t)
        {
            adminDAL.Delete(t);
        }
        public Admin TGetById(int id)
        {
            return adminDAL.TGetById(id);
        }
        public void TUpdate(Admin t)
        {
            adminDAL.Update(t);
        }
    }
}
