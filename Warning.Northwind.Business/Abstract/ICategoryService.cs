using System;
using System.Collections.Generic;
using System.Text;
using Warning.Northwind.Entities.Concrete;

namespace Warning.Northwind.Business.Abstract
{
  public  interface ICategoryService
    {
        List<Category> GetAll();
    }
}
