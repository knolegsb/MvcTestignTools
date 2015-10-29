﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTestingTools.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }
    }
}