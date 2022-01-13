using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebPagesNorthWind.Data;
using WebPagesNorthWind.Models;

namespace WebPagesNorthWind.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly WebPagesNorthWind.Data.NorthWindContext _context;

        public IndexModel(WebPagesNorthWind.Data.NorthWindContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
