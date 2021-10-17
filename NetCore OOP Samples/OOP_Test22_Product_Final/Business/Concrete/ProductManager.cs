using Business.Abstract;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        IProductDal _productDal;
        ICategoryService _categoryService;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public ProductManager(IProductDal productDal, ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            //Add adding rules here...Business layer...
            IResult result = BusinessRules.Run(CheckProductCountOfCategory(product.CategoryId),
                                               CheckProductNameExists(product.ProductName), 
                                               CheckCategoryLimitExceeded());

            if (result != null)
            {
                return result;
            }

            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }


        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {
            if (_productDal.GetAll(p => p.CategoryId == product.CategoryId).Count >= 10)
            {
                return new ErrorResult(Messages.ProductCountCategoryError);
            }
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == categoryId));
        }
        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetAllByUnitPrice(decimal minUnitPrice, decimal maxUnitPrice)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= minUnitPrice && p.UnitPrice <= maxUnitPrice));
        }

        public IDataResult<List<Product>> GetAllProducts()
        {
            if (DateTime.Now.Hour == 3)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintanceTime);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }



        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            if (DateTime.Now.Hour == 16)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintanceTime);
            }
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }


        private IResult CheckProductCountOfCategory(int categoryID)
        {
            // select count(*) from products where CategoryId=categoryId
            var result = _productDal.GetAll(p => p.CategoryId == categoryID).Count >= 10;
            if (result)
            {
                return new ErrorResult(Messages.ProductCountCategoryError);
            }
            return new SuccessResult();
        }

        private IResult CheckProductNameExists(string productName)
        {
            // select count(*) from products where ProductName=productName
            //Way1:
            var result = _productDal.GetAll(p => p.ProductName.ToLower() == productName.ToLower()).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }

            #region 2nd Method
            ////Way2
            //var result2 = _productDal.GetAll(p => p.ProductName.ToLower() == productName.ToLower()).Count > 0;
            //if (result2)
            //{
            //    return new ErrorResult(Messages.ProductNameAlreadyExists);
            //} 
            #endregion
            #region 3rd Method
            ////Way3
            //var result3 = _productDal.GetAll(p => p.ProductName.ToLower() == productName.ToLower());
            //if (result3 == null)
            //{
            //    return new ErrorResult(Messages.ProductNameAlreadyExists);
            //} 
            #endregion
            return new SuccessResult();
        }

        private IResult CheckCategoryLimitExceeded()
        {
            // select count(*) from products where CategoryId=categoryId, max category count 15 
            var result = _categoryService.GetAllCategorys();
            if (result.Data.Count > 15)
            {
                return new ErrorResult(Messages.CategoryLimitExceeded);
            }
            return new SuccessResult();
        }

    }
}
