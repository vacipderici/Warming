using System;
using System.Collections.Generic;
using System.Text;
using Warning.Core.Entities;

namespace Warning.Northwind.Entities.Concrete
{
   public class Category: IEntity
    {
        public int CayegoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
