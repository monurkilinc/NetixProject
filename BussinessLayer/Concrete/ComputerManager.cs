using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ComputerManager : IComputerService
    {
        private readonly IComputerDAL computerDAL;
        
        public ComputerManager(IComputerDAL ComputerDAL)
        {
            this.computerDAL=ComputerDAL;
            
        }
        public Computer GetListAll(int id)
        {
            return computerDAL.GetListAll(id);
        }
        public List<Computer> GetListAll()
        { 
            return computerDAL.GetListAll();
        }
        public void TAdd(Computer t)
        {
              computerDAL.Insert(t);
        }
        public void TDelete(Computer t)
        {
             computerDAL.Delete(t);
        }
        public void TUpdate(Computer t)
        {
            computerDAL.Update(t);
        }
       
        public Computer TGetById(int id)
        {
            return computerDAL.TGetById(id);
        }

        public List<Computer> GetEmptyComputer()
        {
            return computerDAL.GetEmptyComputer();
        }

       
    }
}
