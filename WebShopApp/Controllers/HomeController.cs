using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShopApp.Models;
using System.Data.Entity;
using WebShopApp.ViewModels;

namespace WebShopApp.Controllers
{
    public class HomeController : Controller
    {
        StoreContext db = new StoreContext();
        public ActionResult Index()
        {           
            List<Category> categories = db.Categories.ToList();

            ProductsViewModel pvm = new ProductsViewModel
            {
                Categories = categories
            };
            return View(pvm);
        }
       [HttpGet]
        public ActionResult Show(string parameterName)
        {
            IQueryable<Product> products = db.Products.Include(p => p.Category);
            if (parameterName != null && parameterName != "")
            {
                products = products.Where(p => p.CategoryName == parameterName&&p.Activity==true) ;
            }
            List<Category> categories = db.Categories.ToList();

            ProductsViewModel pvm = new ProductsViewModel
            {
                Products = products.ToList(),
                Categories = categories
            };
            return View("Index",pvm);
        }
    }
}