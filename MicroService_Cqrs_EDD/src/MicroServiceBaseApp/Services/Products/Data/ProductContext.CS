using MongoDB.Driver;
using Products.Data.Interfaces;
using Products.Entities;
using Products.Settings;

namespace Products.Data
{
    public class ProductContext : IProductContext
    {
        public ProductContext(IProductDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionStrings);
            var database = client.GetDatabase(settings.DatabaseName);

            Products= database.GetCollection<Product>(settings.CollectionName);



        }
        public IMongoCollection<Product> Products { get; }
    }
}