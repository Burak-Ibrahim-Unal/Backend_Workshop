using OOP_Test4.Entity;
using OOP_Test4.Dal;

namespace OOP_Test4.Dal
{
    public class EfProductDal : IProductRepository
    {
        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }
        public void Create(Product p)
        {
            System.Console.WriteLine("EfProduct created.");
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