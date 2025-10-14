using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbanhang_nhom10.Models;

namespace Webbanhang_nhom10.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "DirtyCoins Patch In Heart T-Shirt Black", Price = "395.000₫", Image = Url.Content("~/Content/Img/Tshirt/ao-den-01-font.jpg") },
                new Product { Id = 2, Name = "DirtyCoins Patch In Heart T-Shirt White", Price = "395.000₫", Image = Url.Content("~/Content/Img/Tshirt/ao-trang-01-font.jpg") },
                new Product { Id = 3, Name = "DirtyCoins Bình Tân Embroidered Polo Black", Price = "395.000₫", Image = Url.Content("~/Content/Img/Tshirt/binh-tan-font.jpg") },
                new Product { Id = 4, Name = "DirtyCoins Rope Embroidery Knit Polo Black", Price = "395.000₫", Image = Url.Content("~/Content/Img/Tshirt/black-polo-font.jpg") },
                new Product { Id = 5, Name = "DirtyCoins Embroidery Chain Knit Polo Cream", Price = "395.000₫", Image = Url.Content("~/Content/Img/Tshirt/cream-polo-font.jpg") },
                new Product { Id = 6, Name = "Hanoi Lover T-Shirt White", Price = "395.000₫", Image = Url.Content("~/Content/Img/Tshirt/Hanoi-font.jpg") },
                new Product { Id = 7, Name = "DirtyCoins Striped Soccer Jersey Baby Blue White", Price = "395.000₫", Image = Url.Content("~/Content/Img/Tshirt/messi-font.jpg") },
                new Product { Id = 8, Name = "DirtyCoins Wild West Fade Relaxed Tan", Price = "395.000₫", Image = Url.Content("~/Content/Img/Tshirt/wild-west-font.jpg") }
            };
        }

        public ActionResult Index()
        {
            var products = GetProducts();
            return View(products);
        }

        public ActionResult Detail(int id)
        {
            var products = GetProducts();
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

    }
}