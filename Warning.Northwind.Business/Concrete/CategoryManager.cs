using System;
using System.Collections.Generic;
using System.Text;
using Warning.Northwind.Business.Abstract;
using Warning.Northwind.DataAccess.Abstract;
using Warning.Northwind.Entities.Concrete;

namespace Warning.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //Aslinda buraya EFProduct DAl geliyor yarin nhibarnete yapsak yine olacak. Cunku referansini tutuyor.
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal){
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
