using System;
using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models
{
    public class ProductStorage : IProductStorage
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product{ Name = "Football", Price = 25 },
            new Product{ Name = "Surf board", Price = 179 },
            new Product{ Name = "Baseball bat", Price = 64 }
        }.AsQueryable<Product>();
    }
}