﻿using System;
using System.Collections.Generic;
using ASPNET.Models;
namespace ASPNET
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

    }
}