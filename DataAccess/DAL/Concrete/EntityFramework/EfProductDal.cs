using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DAL.Abstract;
using DataAccess.DAL.Concrete.EntityFramework.Context;
using DataAccess.DAL.Concrete.EntityFramework.Repository;
using Entities.Concrete;

namespace DataAccess.DAL.Concrete.EntityFramework
{
    public class EfProductDal : EfBaseRepository<Product, StokTakipContext>, IProductDal
    {

    }
}
