using System;
using System.Collections.Generic;
using System.Text;
using Warning.Northwind.Entities.Concrete;

namespace Warning.Northwind.Business.Abstract
{
   public interface IProductService
    {
        //Burada kurallari isletebiliriz. Ayrica IEntityRepository'in hepsine muhtac degiliz.
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);

        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
    }
}
