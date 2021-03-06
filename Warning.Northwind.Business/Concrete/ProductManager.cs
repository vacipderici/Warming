using System;
using System.Collections.Generic;
using System.Text;
using Warning.Northwind.Business.Abstract;
using Warning.Northwind.DataAccess.Abstract;
using Warning.Northwind.Entities.Concrete;

namespace Warning.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { PRoductId = productId});
        }

        public List<Product> GetAll()
        {
           return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId == 0) ;
        }

        public Product GetById(int productId)
        {
         return  _productDal.Get(p => p.PRoductId == productId);

        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
