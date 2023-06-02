using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IPersonalDAL:IGenericDAL<Personal>
    {
        List<Personal> GetListDetailAll();
        Personal GetID(int id);
        Personal GetListAll(int id);
        List<Personal> PersonalComputerDifference();
    }
}
