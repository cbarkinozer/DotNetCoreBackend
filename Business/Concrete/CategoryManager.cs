using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public List<Category> GetAll(ICategoryDal categoryDal)
        {
            //Bussiness codes
            return _categoryDal.GetAll();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetById(int categoryId)
        {
            return _categoryDal.Get(c=>c.CategoryId==categoryId);
        }
    }
}
