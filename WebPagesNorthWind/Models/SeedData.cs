using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebPagesNorthWind.Data;

namespace WebPagesNorthWind.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NorthWindContext(serviceProvider.GetRequiredService<DbContextOptions<NorthWindContext>>()))
            {
                if (!context.Product.Any())
                {
                    context.Product.AddRange(
                        new Product { Name = "Azúcar", RegisterDate = DateTime.Now, Category = "Azúcares", UnitPrice = 15.99m },
                        new Product { Name = "Arroz", RegisterDate = DateTime.Now, Category = "Arroces", UnitPrice = 23.87m },
                        new Product { Name = "Sal", RegisterDate = DateTime.Now, Category = "Sales", UnitPrice = 9.48m },
                        new Product { Name = "Pan", RegisterDate = DateTime.Now, Category = "Panes", UnitPrice = 3.12m }
                        );

                    context.SaveChanges();
                }
            }
        }
    }
}
