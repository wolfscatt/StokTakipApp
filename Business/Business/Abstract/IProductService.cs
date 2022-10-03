using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(Expression<Func<Product, bool>> filter = null);
        Product Get(Expression<Func<Product, bool>> filter);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetProducts(string key);
        List<Product> GetProductsByCategory(string value);
        List<Product> GetProductsByCompany(string cmbCompanyText);
    }
}
