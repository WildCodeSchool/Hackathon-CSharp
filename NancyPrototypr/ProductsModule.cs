﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EcoConception
{
    public class ProductsModule : AbstractModule
    {
        public override IEnumerable<Product> Products { get => Database.GetAllProducts();  }
        public override IEnumerable<Category> Categories { get; }

        public ProductsModule()
        {

        }

    }
}