using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetAllProducts();
        List<Product> GetAllByCategory(int categoryId);
        List<Product> GetAllUnitPrice(decimal min, decimal max);
        List<ProductDetailDTO> GetProductDetails();
    }
}
