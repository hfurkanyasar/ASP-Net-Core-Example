using MVC.Example.BusinessLayer.Abstract;
using MVC.Example.DataAccessLayer.Abstract;
using MVC.Example.DataAccessLayer.Concrate;
using MVC.Example.DataAccessLayer.Repositories;
using MVC.Example.EntityLayer.Concrate;
using System;
using System.Collections.Generic;


namespace MVC.Example.BusinessLayer.Concrate
{
    public class CategoryManeger : ICategoryService
    {
        private readonly Context _cnn;

        ICategoryDAL _categoryDal;
        public CategoryManeger(Context cnn,
        ICategoryDAL categoryDal)
        {
            _cnn = cnn;
            _categoryDal = categoryDal;
        }

        public CategoryManeger(CategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        CategoryRepository catRepo = new CategoryRepository();
        private CategoryRepository categoryRepository;

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);

            
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.GetByID(id); ;
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }
    }
}
