﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IComputerDAL : IGenericDAL<Computer>
    {

        Computer GetListAll(int id);
        List<Computer>GetEmptyComputer();
        Computer GetLisPersonelServiceHistory(int id);
    }
}
