using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.DAL.Concrete.EntityFramework.Context
{
    public class StokTakipContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Company> Companies { get; set; }

    }
}
