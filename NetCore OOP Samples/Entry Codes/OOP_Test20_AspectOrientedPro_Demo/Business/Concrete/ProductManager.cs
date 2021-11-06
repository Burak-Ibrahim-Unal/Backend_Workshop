using Business.Abstract;
//using Core.CrossCuttingConcerns.Caching.Abstract;
//using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Logging.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        //private ILogger _logger; //contrary to solid principles
        //private ICache _cache; //contrary to solid principles

        //public ProductManager(IProductDal productDal, ILogger logger, ICache cache) //contrary to solid principles
        //{
        //    _productDal = productDal;
        //    _logger = logger;
        //    _cache = cache;
        //}

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;

        }

        [LogAspect]
        public List<Product> GetAll()
        {
            //_logger.Log(); //contrary to solid principles
            //_cache.Cache(); //contrary to solid principles
            return _productDal.GetAll();
        }
    }
}
