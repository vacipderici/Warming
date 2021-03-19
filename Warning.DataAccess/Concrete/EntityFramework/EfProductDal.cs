using System;
using System.Collections.Generic;
using System.Text;
using Warning.Core.DataAccess.EntitiyFramework;
using Warning.Northwind.DataAccess.Abstract;
using Warning.Northwind.Entities.Concrete;

namespace Warning.Northwind.DataAccess.Concrete.EntityFramework
{
  public  class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
