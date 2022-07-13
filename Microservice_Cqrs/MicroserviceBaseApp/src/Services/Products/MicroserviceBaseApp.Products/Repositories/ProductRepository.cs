using MicroserviceBaseApp.Products.Entities;
using MongoDB.Driver;
using MicroserviceBaseApp.Products.Data;
using MicroserviceBaseApp.Products.Data.Interfaces;
using MicroserviceBaseApp.Products.Repositories.Interfaces;

namespace MicroserviceBaseApp.Products.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductContext _productContext;


        public ProductRepository(IProductContext productContext)
        {
            _productContext = productContext;

        }


        public async Task Create(Product product)
        {
            await _productContext.Products.InsertOneAsync(product);
        }

        public async Task<bool> Delete(Guid id)
        {
            var filteredProduct = Builders<Product>.Filter.Eq(p => p.Id, id);
            DeleteResult deleteResult = await _productContext.Products.DeleteOneAsync(filteredProduct);

            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;

        }

        public async Task<Product> GetProduct(Guid id)
        {
            return await _productContext.Products.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            var filteredProduct = Builders<Product>.Filter.Eq(p => p.Category, categoryName);
            return await _productContext.Products.Find(filteredProduct).ToListAsync();

        }

        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            var filteredProduct = Builders<Product>.Filter.ElemMatch(p => p.Name
            , name);
            return await _productContext.Products.Find(filteredProduct).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productContext.Products.Find(p => true).ToListAsync();
        }

        public async Task<bool> Update(Product product)
        {
            var updatedProduct = await _productContext.Products.ReplaceOneAsync(filter: g => 
                g.Id == product.Id, replacement: product);

                return  updatedProduct.IsAcknowledged && updatedProduct.ModifiedCount > 0;
        }
    }
}