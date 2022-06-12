using MongoDB.Driver;
using MicroserviceBaseApp.Products.Data.Interfaces;
using MicroserviceBaseApp.Products.Entities;
using MicroserviceBaseApp.Products.Settings;

namespace MicroserviceBaseApp.Products.Data
{
    public class ProductContext : IProductContext
    {

        public ProductContext(IProductDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionStrings);
            var database = client.GetDatabase(settings.DatabaseName);

            Products = database.GetCollection<Product>(settings.CollectionName);
            ProductContextSeed.SeedData(Products);


        }
        public IMongoCollection<Product> Products { get; }
    }
}