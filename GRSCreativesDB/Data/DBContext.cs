using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRSCreativesDB.Models;

namespace GRSCreativesDB.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options) : base(options)
        {

        }

        public DbSet<AliasSKU> AliasSKUs { get; set; }
        public DbSet<JewelryGroup> JewelryGroups { get; set; }
        public DbSet<Marketplace> Marketplaces { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<RawMaterialType> RawMaterialTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AliasSKU>()
                .HasOne(a => a.Product)
                .WithMany(p => p.AliasSKUs)
                .HasForeignKey(a => a.ProductID)
                .HasConstraintName("ForeignKey_AliasSKU_Product")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AliasSKU>()
                .HasOne(a => a.Marketplace)
                .WithMany(m => m.AliasSKUs)
                .HasForeignKey(a => a.ProductID)
                .HasConstraintName("ForeignKey_AliasSKU_Marketplace")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JewelryGroup>()
                .HasOne(jg => jg.Set)
                .WithMany(p => p.Sets)
                .HasForeignKey(jg => jg.SetID)
                .HasConstraintName("ForeignKey_JewelryGroup_Product_Sets")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JewelryGroup>()
                .HasOne(jg => jg.Piece)
                .WithMany(p => p.Pieces)
                .HasForeignKey(jg => jg.PieceID)
                .HasConstraintName("ForeignKey_JewelryGroup_Product_Pieces")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.RawMaterial)
                .WithMany(rw => rw.Products)
                .HasForeignKey(p => p.RawMaterialID)
                .HasConstraintName("ForeignKey_Product_RawMaterial")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
