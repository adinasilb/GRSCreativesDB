using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRSCreativesDB.Models
{
    public class JewelryGroup
    {
        [Key]
        public int JewelryGroupID { get; set; }
        public int SetID { get; set; }
        public Product Set { get; set; }
        public int PieceID { get; set; }
        public Product Piece { get; set; }
    }
}
