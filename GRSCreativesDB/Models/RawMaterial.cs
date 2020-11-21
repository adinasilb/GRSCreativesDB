using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRSCreativesDB.Models
{
    public class RawMaterial
    {
        [Key]
        public int RawMaterialID { get; set; }
        public string RawMaterialDescription { get; set; }
        public int RawMaterialTypeID { get; set; }
        public RawMaterialType RawMaterialType { get; set; }
        public bool JewelryComponent { get; set; }
        public bool LocketSet { get; set; }
        public List<Product> Products { get; set; }
    }
}
