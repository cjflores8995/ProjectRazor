using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPagesNorthWind.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Register Date")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }
        
        [Display(Name = "Product Category")]
        public string Category { get; set; }

        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
    }
}
