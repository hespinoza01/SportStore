using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductStorage storage;

        public ProductController(IProductStorage _storage)
        {
            this.storage = _storage;
        }

        public ViewResult List() => this.View(this.storage.Products);
    }
}