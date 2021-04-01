using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warning.Northwind.Entities.Concrete;

namespace Warning.Northwind.MvcWebUI.Services
{
   public interface ICartSessionService
    {

        Cart GetCart();
        void SetCart();

    }
}
