using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetAllProducts();
        List<Product> GetAllByCategory();
        List<Product> GetAllUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
    }
}
