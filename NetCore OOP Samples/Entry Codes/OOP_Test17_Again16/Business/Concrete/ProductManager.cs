using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetAllProductDetails();
        }

        public List<Product> GetAllProducts()
        {
            return _productDal.GetAll();
        }
    }
}
