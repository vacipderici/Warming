﻿using System;
using System.Collections.Generic;
using System.Text;
using Warning.Core.DataAccess;
using Warning.Northwind.Entities.Concrete;

namespace Warning.Northwind.DataAccess.Abstract
{
  public  interface IProductDal: IEntityRepository<Product>
    {
        //Custom Operations

    }
}
