using System;
using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models
{
    public class ProductStorage : IProductStorage
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product{
                Name = "Football",
                Description = "lorem ipsun date value some price description attr some data vars to date",
                Price = 25
            },
            new Product{
                Name = "Surf board",
                Description = "lorem ipsun date value some price description attr some data vars to date",
                Price = 179
            },
            new Product{
                Name = "Baseball bat",
                Description = "lorem ipsun date value some price description attr some data vars to date",
                Price = 64
            }
        }.AsQueryable<Product>();
    }
}