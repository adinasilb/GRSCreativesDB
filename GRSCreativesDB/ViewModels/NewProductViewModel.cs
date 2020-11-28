using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRSCreativesDB.Models;

namespace GRSCreativesDB.ViewModels
{
    public class NewProductViewModel
    {
        public AliasSKU AliasSKU { get; set; }
        public List<RawMaterial> RawMaterials { get; set; }
        public List<Marketplace> Marketplaces { get; set; }
    }
}
