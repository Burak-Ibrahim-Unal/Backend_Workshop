using OOP_Test4.Entity;
using OOP_Test4.Dal;

namespace OOP_Test4.Dal
{
    public interface IProductRepository : IRepository<Product>
    {
        Product[] GetProductByCategory(int id);
    }
}