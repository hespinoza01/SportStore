using System;
using System.Linq;

namespace SportStore.Models
{
    public class EFProductStorage : IProductStorage
    {
        private ApplicationDbContext context;

        public EFProductStorage(ApplicationDbContext adc) => this.context = adc;

        public IQueryable<Product> Products => this.context.Products;
    }
}