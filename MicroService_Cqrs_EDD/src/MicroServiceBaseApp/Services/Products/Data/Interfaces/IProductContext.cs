using MongoDB.Driver;
using Products.Entities;

namespace Products.Data.Interfaces
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}