using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DAL.Abstract.IRepository;
using Entities.Concrete;

namespace DataAccess.DAL.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
