using MongoDB.Driver;
using MicroserviceBaseApp.Products.Entities;

namespace MicroserviceBaseApp.Products.Data.Interfaces
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}