using DocumentFormat.OpenXml.Office2010.Excel;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IServiceDAL : IGenericDAL<Service>
    {

        
        List<Service> GetAllPersonelList();
        List<Service> GetComputerListByID(int id);
        Service GetListServiceAll(int id);
        
    }
}
