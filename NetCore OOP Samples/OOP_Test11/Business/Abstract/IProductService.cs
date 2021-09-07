using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        List<Product> GetAllByCategoryId(int categoryId);
        List<Product> GetAllByUnitPrice(decimal minUnitPrice, decimal maxUnitPrice);
        List<ProductDetailDTO> GetProductDetails();

    }
}
