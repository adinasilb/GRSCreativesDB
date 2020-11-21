using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRSCreativesDB.Models
{
    public class RawMaterialType
    {
        [Key]
        public int RawMaterialTypeID { get; set; }
        public string RawMaterialDescription { get; set; }
        public List<RawMaterial> RawMaterials { get; set; }
    }
}
