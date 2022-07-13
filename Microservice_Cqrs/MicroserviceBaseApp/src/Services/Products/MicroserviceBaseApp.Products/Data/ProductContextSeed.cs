using MongoDB.Driver;
using MicroserviceBaseApp.Products.Entities;

namespace MicroserviceBaseApp.Products.Data
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool isProductExist = productCollection.Find(p => true).Any();
            if (!isProductExist)
            {
                productCollection.InsertManyAsync(GetConfigureProducts());
            }
        }

        private static IEnumerable<Product> GetConfigureProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    Name="Product1",
                    Summary="Summary1",
                    Description="Description1",
                    Image="Image1",
                    Price= 1,
                    Category="Catergory1"
                },
                new Product
                {
                    Name="Product1",
                    Summary="Summary2",
                    Description="Description2",
                    Image="Image2",
                    Price= 2,
                    Category="Catergory2"
                },
                new Product
                {
                    Name="Product3",
                    Summary="Summary3",
                    Description="Description3",
                    Image="Image3",
                    Price= 3,
                    Category="Catergory1"
                },
                new Product
                {
                    Name="Product4ß",
                    Summary="Summary4",
                    Description="Description4",
                    Image="Image4",
                    Price= 4,
                    Category="Catergory3"
                },
                new Product
                {
                    Name="Product5",
                    Summary="Summary5",
                    Description="Description5",
                    Image="Image5",
                    Price= 5,
                    Category="Catergory2"
                }
            };
        }
    }
}