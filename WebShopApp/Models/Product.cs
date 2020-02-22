using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShopApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public decimal Price { get; set; }
        public string VendorCode { get; set; }
        public bool Activity { get; set; }
        public string CategoryName { get; set; }

        public Category Category { get; set; }
    }
}