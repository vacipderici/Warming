using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warning.Northwind.Entities.Concrete;

namespace Warning.Northwind.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
    }
}
