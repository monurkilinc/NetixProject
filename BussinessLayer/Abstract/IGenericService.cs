using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IGenericService<T>   
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);

        List<T> GetListAll();
        T TGetById(int id);
        T GetListAll(int id);
    }
}
