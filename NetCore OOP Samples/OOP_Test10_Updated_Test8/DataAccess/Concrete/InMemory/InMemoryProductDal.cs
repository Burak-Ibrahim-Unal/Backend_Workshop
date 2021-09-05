using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Lets assume that we pull records from database
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Laptop",UnitPrice=5000,UnitsInStock=4},
                new Product{ProductId=2,CategoryId=2,ProductName="Tablet",UnitPrice=2000,UnitsInStock=10},
                new Product{ProductId=3,CategoryId=2,ProductName="MobilPhone",UnitPrice=3000,UnitsInStock=40},
                new Product{ProductId=4,CategoryId=3,ProductName="Tv",UnitPrice=3000,UnitsInStock=7},
            };
        }

        public void Add(Product p) // We add product that comes from Business layer
        {
            _products.Add(p);
        }

        public void Delete(Product p)
        {
            #region Without Linq
            //Product ProductToDelete = null; // null doesnt have referance... Dont use extra memory space with new Product()
            //foreach (var product in _products)
            //{
            //    if (p.ProductId == product.ProductId)
            //    {
            //        ProductToDelete = product;
            //    }

            //}

            //_products.Remove(ProductToDelete);
            #endregion

            Product ProductToDelete = _products.SingleOrDefault(x => x.ProductId == p.ProductId); // With Linq
            _products.Remove(ProductToDelete);
        }

        public Product GetProduct(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            // With Linq
            return _products.Where(x => x.CategoryId == categoryId).ToList(); // Add more conditions with &&
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }



        public void Update(Product p)
        {
            //Find the product whose id is the same as the id of the product we search 
            Product ProductToUpdate = _products.SingleOrDefault(x => x.ProductId == p.ProductId); // With Linq
            //And update informations... Without Entity Framework / Hibernate...
            ProductToUpdate.ProductName = p.ProductName;
            ProductToUpdate.CategoryId = p.CategoryId;
            ProductToUpdate.UnitPrice = p.UnitPrice;
            ProductToUpdate.UnitsInStock = p.UnitsInStock;


        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
