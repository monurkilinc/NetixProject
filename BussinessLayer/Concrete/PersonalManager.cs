using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class PersonalManager : IPersonalService
    {
        private readonly IPersonalDAL personalDAL;
        public PersonalManager(IPersonalDAL PersonalDAL)
        {
            personalDAL = PersonalDAL;
        }
        public Personal TGetById(int id)
        {
            return personalDAL.TGetById(id);
        }
        public Personal TGetByID(int id)
        {
            return personalDAL.TGetById(id) ;
        }
        public void TAdd(Personal t)
        {
            personalDAL.Insert(t);
        }
        public void TDelete(Personal t)
        {
            personalDAL.Delete(t);
        }
        public void TUpdate(Personal t)
        {
            personalDAL.Update(t);
        }
        public Computer GetComputer()
        {
            return GetComputer();
        }
        public List<Personal> GetListDetailAll()
        {
            return personalDAL.GetListDetailAll();
        }
        List<Personal> IPersonalService.PersonalComputerDifference()
        {
            return personalDAL.PersonalComputerDifference();
        }
        public List<Personal> GetListAll()
        {
            return personalDAL.GetListAll();
        }
        public Personal GetListAll(int id)
        {
            return personalDAL.GetListAll(id);
        }
    }
}
