using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRSCreativesDB.Models;

namespace GRSCreativesDB.ViewModels
{
    public class ProductViewModel
    {
        public List<AliasSKU> AliasSKUs { get; set; } //if product has multiple children
        public List<Product> Products { get; set; } //if product is a locket set
        public Product LocketSet { get; set; }
    }
}
