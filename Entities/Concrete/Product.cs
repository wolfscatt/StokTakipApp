using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Product :IEntity
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
