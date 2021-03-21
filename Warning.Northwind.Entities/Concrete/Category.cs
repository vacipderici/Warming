using System;
using System.Collections.Generic;
using System.Text;
using Warning.Core.Entities;

namespace Warning.Northwind.Entities.Concrete
{
    [Microsoft.EntityFrameworkCore.Keyless]
    public class Category: IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
