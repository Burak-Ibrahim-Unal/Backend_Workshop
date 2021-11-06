using OOP_Test4.Entity;
using OOP_Test4.Dal;

namespace OOP_Test4.Dal
{
    public class ProductManager : IProductRepository
    {

        IProductRepository _repository;
        public ProductManager(IProductRepository repo)
        {
            _repository=repo;
        }
        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }
        public void Create(Product p)
        {
            _repository.Create(p);
        }
        public void Update(Product p)
        {
            throw new System.NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product[] GetProductByCategory(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}