using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebPagesNorthWind.Models;

namespace WebPagesNorthWind.Data
{
    public class NorthWindContext : DbContext
    {
        public NorthWindContext (DbContextOptions<NorthWindContext> options)
            : base(options)
        {
        }

        public DbSet<WebPagesNorthWind.Models.Product> Product { get; set; }
    }
}
