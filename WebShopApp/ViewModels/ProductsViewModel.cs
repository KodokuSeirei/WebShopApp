using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopApp.Models;

namespace WebShopApp.ViewModels
{
    public class ProductsViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}