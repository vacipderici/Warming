﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warning.Northwind.Entities.Concrete;

namespace Warning.Northwind.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}
