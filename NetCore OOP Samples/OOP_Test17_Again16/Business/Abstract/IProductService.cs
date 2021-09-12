using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService 
    {
        List<Product> GetAllProducts();
        List<ProductDetailDto> GetProductDetails();
    }
}
