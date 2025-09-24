using Microsoft.AspNetCore.Mvc;
using viduC4MVC.Models;
using System.Collections.Generic;

namespace MvcDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Tạo list sản phẩm mẫu
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1500 },
                new Product { Id = 2, Name = "Chuột", Price = 20 },
                new Product { Id = 3, Name = "Bàn phím", Price = 30 }
            };

            return View(products); // Trả về view kèm model
        }
    }
}
