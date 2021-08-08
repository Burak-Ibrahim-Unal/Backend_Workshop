using OOP_Test4.Entity;
using OOP_Test4.Dal;

namespace OOP_Test4.Dal
{
    public class MysqlProductDal : IProductRepository
    {
        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }
        public void Create(Product p)
        {
            System.Console.WriteLine("MysqlProduct created.");
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