using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRSCreativesDB.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductDescription { get; set; }
        public int InventoryNumWarehouse { get; set; }
        public int InventoryNumAmazon { get; set; }
        public bool JewelryGroup { get; set; }
        public int RawMaterialID { get; set; }
        public RawMaterial RawMaterial { get; set; }
        public int Quantity { get; set; }

        public List<AliasSKU> AliasSKUs { get; set; }
        public List<JewelryGroup> Sets { get; set; }
        public List<JewelryGroup> Pieces { get; set; }
    }
}
