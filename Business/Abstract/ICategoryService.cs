using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using static Core.Entities.Utilities.Results.IDataResult;

namespace Business.Abstract
{
    public interface ICategoryService
    {
       IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);
    }
}
