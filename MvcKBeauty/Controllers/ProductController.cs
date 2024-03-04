using Microsoft.AspNetCore.Mvc;
using MvcKBeauty.Models;
using System.Collections.Generic;

namespace MvcKBeauty.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Catalogue()
        {
            // Retrieve a list of products (sample data for demonstration)
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Highlighter", Price = 10.99m, ImageUrl = "/images/img1.jpg", CustomerRating = 4.5f },
                new Product { Id = 2, Name = "Skin Care", Price = 19.99m, ImageUrl = "/images/img2.webp", CustomerRating = 3.8f },
                new Product { Id = 3, Name = "Blush", Price = 30.99m, ImageUrl = "/images/img3.jpg", CustomerRating = 4.0f },
                new Product { Id = 4, Name = "Lip Mask", Price = 15.99m, ImageUrl = "/images/img4.jpg", CustomerRating = 4.9f },
                new Product { Id = 5, Name = "Cleanser", Price = 18.99m, ImageUrl = "/images/img5.webp", CustomerRating = 3f },
                new Product { Id = 6, Name = "Moisturiser", Price = 20.99m, ImageUrl = "/images/img6.png", CustomerRating = 4.8f },
                new Product { Id = 7, Name = "Lipstick", Price = 35.99m, ImageUrl = "/images/img7.jpg", CustomerRating = 5f },
                new Product { Id = 8, Name = "Face Masks", Price = 30.99m, ImageUrl = "/images/img8.jpeg", CustomerRating = 4.7f },
                new Product { Id = 9, Name = "Compact", Price = 32.99m, ImageUrl = "/images/img9.webp", CustomerRating = 2f },
                new Product { Id = 10, Name = "Eye Shadow", Price = 45.99m, ImageUrl = "/images/img10.webp", CustomerRating = 4.1f },


                // Add more products as needed
            };

            return View(products);
        }
    }
}
