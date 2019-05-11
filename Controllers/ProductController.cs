using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductStorage storage;
        public int PageSize = 4;

        public ProductController(IProductStorage _storage)
        {
            this.storage = _storage;
        }

        public ViewResult List(int productPage = 1) => this.View(
            new ProductsListViewModel
            {
                Products = this.storage.Products
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * this.PageSize)
                    .Take(this.PageSize),
                PagingInfo = new PageInfo
                {
                    CurrentPage = productPage,
                    ItemsForPage = this.PageSize,
                    TotalItems = storage.Products.Count()
                }
            }
        );
    }
}