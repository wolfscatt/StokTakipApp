using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Business.Abstract;
using Business.Business.Conrete;
using DataAccess.DAL.Abstract;
using DataAccess.DAL.Concrete.EntityFramework;
using Ninject.Modules;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
        }
    }
}
