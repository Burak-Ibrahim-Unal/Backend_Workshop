using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAllProducts();
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult<List<Product>> GetAllByUnitPrice(decimal minUnitPrice, decimal maxUnitPrice);
        IDataResult<List<ProductDetailDto>> GetProductDetails();

        IResult Add(Product p);
        IDataResult<Product> GetById(int productId);
    }
}
