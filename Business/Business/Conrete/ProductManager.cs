using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Business.Abstract;
using Business.ValidationRules.FluentValidation;
using DataAccess.DAL.Abstract;
using Entities.Concrete;
using FluentValidation;

namespace Business.Business.Conrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _productDal.GetAll(filter);
        }
        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _productDal.Get(filter);
        }
        public void Add(Product product)
        {
            var productValidator = new ProductValidator();
            var result = productValidator.Validate(product);
            if (result.Errors.Count > 0)
                throw new ValidationException(result.Errors);
            _productDal.Add(product);
        }
        public void Update(Product product)
        {
            var productValidator = new ProductValidator();
            var result = productValidator.Validate(product);
            if (result.Errors.Count > 0)
                throw new ValidationException(result.Errors);
            _productDal.Update(product);
        }
        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetProducts(string key)
        {
            return _productDal.GetAll(p => p.Name.ToLower().Contains(key.ToLower()));
        }

        public List<Product> GetProductsByCategory(string value)
        {
            return _productDal.GetAll(p => p.Category == value);
        }

        public List<Product> GetProductsByCompany(string cmbCompanyText)
        {
            return _productDal.GetAll(p => p.Company == cmbCompanyText);
        }
    }
}
