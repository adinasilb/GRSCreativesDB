using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRSCreativesDB.Models;

namespace GRSCreativesDB.Data
{
    public class DBInitializer
    {
        public static void Initialize(DBContext context)
        {
            context.Database.EnsureCreated();

            //if (!context.RawMaterials.Any())
            //{
            var rawMaterials = new RawMaterial[]
            {
                    new RawMaterial
                    {
                        RawMaterialID = 1,
                        RawMaterialDescription = "Locket"
                    }
            };
            foreach (RawMaterial rm in rawMaterials)
            {
                context.RawMaterials.Add(rm);
            }
            context.SaveChanges();
            //}


        }
    }
}
