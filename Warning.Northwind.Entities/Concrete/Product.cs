using System;
using System.Collections.Generic;
using System.Text;
using Warning.Core.Entities;

namespace Warning.Northwind.Entities.Concrete
{
  public  class Product : IEntity
    {
        public int PRoductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitStock { get; set; }
    }
}
