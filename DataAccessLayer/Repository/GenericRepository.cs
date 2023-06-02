using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public abstract class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        
        public T TGetById(int id)
        {
            using var c=new Context();
            return c.Set<T>().Find(id);
        }
        public List<T> GetListAll()
        {
            using var c= new Context();
            return c.Set<T>().ToList();
        }
        public List<T> GetListAll(int id)
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }
        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }
        public  void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
        public virtual void Delete(T t)
        {
            using var c = new Context(); 
            c.Remove(t);
            c.SaveChanges();
        }

        
    }
}
