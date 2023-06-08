using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IServiceService : IGenericService<Service>
    {
        List<Service> GetAllPersonelList();
        Service GetComputerListByID(int id);
        Service GetListServiceAll(int id);
        void TAdd(ServiceHistory serviceHistory);
    }
}
