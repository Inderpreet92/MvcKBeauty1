using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MvcKBeauty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MvcKBeauty.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Check if the database has already been seeded
                if (context.Products.Any())
                {
                    return; // Database has been seeded
                }

                // Seed the database with sample product data
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Sample Product 1",
                        Price = 19.99m,
                        // Add more product attributes here
                        ImageUrl = "/images/sample-product-1.jpg",
                        CustomerRating = 4.5f
                    },
                    new Product
                    {
                        Name = "Sample Product 2",
                        Price = 29.99m,
                        // Add more product attributes here
                        ImageUrl = "/images/sample-product-2.jpg",
                        CustomerRating = 4.0f
                    }
                    // Add more sample product data as needed
                );

                context.SaveChanges();
            }
        }
    }
}
