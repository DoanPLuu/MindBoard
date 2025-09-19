using Microsoft.AspNetCore.Mvc;
using viduC4Razor.Models;
using System.Collections.Generic;
using System.Linq;

namespace viduC4Razor.Controllers
{
    public class ProductController : Controller
    {
        // Dữ liệu mẫu (in-memory, thay cho database)
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1500 },
            new Product { Id = 2, Name = "Chuột máy tính", Price = 20 },
            new Product { Id = 3, Name = "Bàn phím cơ", Price = 80 }
        };

        // Hiển thị danh sách
        [HttpGet]
        public IActionResult Index()
        {
            return View(products);
        }

        // Form thêm sản phẩm
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Nhận dữ liệu từ form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            // Tự động gán Id tăng dần
            product.Id = products.Max(p => p.Id) + 1;
            products.Add(product);

            return RedirectToAction("Index");
        }
    }
}
