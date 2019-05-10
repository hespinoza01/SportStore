using System;
using System.Linq;

namespace SportStore.Models
{
    public interface IProductStorage
    {
        IQueryable<Product> Products { get; }
    }
}