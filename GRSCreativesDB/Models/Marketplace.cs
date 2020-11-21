using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRSCreativesDB.Models
{
    public class Marketplace
    {
        [Key]
        public int MarketplaceID { get; set; }
        public string MarketplaceDescription { get; set; }
        public List<AliasSKU> AliasSKUs { get; set; }
    }
}
