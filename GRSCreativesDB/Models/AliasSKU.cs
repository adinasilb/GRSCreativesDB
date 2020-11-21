using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRSCreativesDB.Models
{
    public class AliasSKU
    {
        [Key]
        public int AliasSKUID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public string ChildSKU { get; set; }
        public bool IsMain { get; set; }
        public int MarketplaceID { get; set; }
        public Marketplace Marketplace { get; set; }
    }
}
