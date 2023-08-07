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
    public class BlogRepository : IBlogDAL
    {
        private readonly Context _cnn;
        public BlogRepository(Context cnn)
        {
            _cnn = cnn;
        }
        public void AddBlog(Blog blog)
        {
            _cnn.Add(blog);
            _cnn.SaveChanges();
        }

        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            _cnn.Remove(blog);
            _cnn.SaveChanges();
        }

        public Blog GetByID(int id)
        {
            return _cnn.Blogs.Find(id);
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            return _cnn.Blogs.ToList();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            _cnn.Update(blog);
            _cnn.SaveChanges();

        }
    }
}
