using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IPersonalService : IGenericService<Personal>
    {
        Computer GetComputer();
        List<Personal> GetListDetailAll();
        Personal TGetByID(int id);
        List<Personal> PersonalComputerDifference();
        Personal GetPersonalByComputerId(int id);
    }
}
