using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReDoMusic.Domain.Entities;
using ReDoMusic.Persistence.Contexts;
using System;
using System.Linq;

namespace ReDoMusic.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ReDoMusicDbContext _dbContext;

        public ProductController()
        {
           _dbContext = new();
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = _dbContext.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(string name, string description, decimal price)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description))
            {
                TempData["ErrorMessage"] = "Name and description are required.";
                return RedirectToAction("Index");
            }

            var product = new Product
            {
                Name = name,
                Description = description,
                Price = price
            };

            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddReview()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReview(Guid productId, string comment, int rating)
        {
            var product = _dbContext.Products
                .Include(p => p.Reviews)
                .FirstOrDefault(p => p.Id == productId);

            if (product == null)
            {
                TempData["ErrorMessage"] = "Product not found.";
                return RedirectToAction("Index");
            }

            var review = new Review
            {
                Comment = comment,
                Rating = rating,
                ProductId = productId
            };

            product.Reviews.Add(review);
            _dbContext.SaveChanges();

            return RedirectToAction("Details", new { id = productId });
        }
    }
}
