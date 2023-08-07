using MVC.Example.DataAccessLayer.Abstract;
using MVC.Example.DataAccessLayer.Concrate;
using MVC.Example.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Example.DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDAL
    {
        private readonly Context _cnn;

        public CategoryRepository()
        {
        }

        public CategoryRepository(Context cnn)
        {
            _cnn = cnn;
        }
        public void AddCategory(Category category)
        {
            _cnn.Add(category);
            _cnn.SaveChanges();
        }

        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            _cnn.Remove(category);
            _cnn.SaveChanges();
        }

        public Category GetByID(int id)
        {
            return _cnn.Categories.Find(id);
        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
           return _cnn.Categories.ToList();
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            _cnn.Update(category);
            _cnn.SaveChanges();
        }
    }
}
