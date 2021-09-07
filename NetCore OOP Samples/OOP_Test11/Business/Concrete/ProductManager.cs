using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _iProductDal;
        public ProductManager(IProductDal iProductDal)
        {
            _iProductDal = iProductDal;
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _iProductDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetAllByUnitPrice(decimal minUnitPrice, decimal maxUnitPrice)
        {
            return _iProductDal.GetAll(p => p.UnitPrice >= minUnitPrice && p.UnitPrice <= maxUnitPrice);
        }

        public List<Product> GetAllProducts()
        {
            return _iProductDal.GetAll();
        }
    }
}
