using Business.Abstract;
using Business.Constants;
using Core.Entities.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using static Core.Entities.Utilities.Results.IDataResult;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2) 
            {
                return new ErrorResult("The product name must be minimum 2 characters");
            }
            _productDal.Add(product);
            return new Result(true,"product added");
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour==22) 
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new IDataResult (_productDal.GetAll(),true,Messages.ProductsListed);
        }

        public SuccessDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.CategoryId==id));
        }

        public SuccessDataResult<List<Product>> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p=>p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.UnitPrice>=min&&p.UnitPrice<=max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }
    }
}
