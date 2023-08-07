using MVC.Example.DataAccessLayer.Abstract;
using MVC.Example.DataAccessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Example.DataAccessLayer.Repositories
{
    class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        private readonly Context _cnn;
        public GenericRepository(Context cnn)
        {
            _cnn = cnn;
        }
        public void Delete(T t)
        {
            _cnn.Remove(t);
            _cnn.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _cnn.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return _cnn.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _cnn.Add(t);
            _cnn.SaveChanges();
        }

        public void Update(T t)
        {
            _cnn.Update(t);
            _cnn.SaveChanges();
        }
    }
}
