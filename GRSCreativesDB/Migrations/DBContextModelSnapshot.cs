﻿// <auto-generated />
using GRSCreativesDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GRSCreativesDB.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GRSCreativesDB.Models.AliasSKU", b =>
                {
                    b.Property<int>("AliasSKUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ChildSKU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<int>("MarketplaceID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("AliasSKUID");

                    b.HasIndex("ProductID");

                    b.ToTable("AliasSKUs");
                });

            modelBuilder.Entity("GRSCreativesDB.Models.JewelryGroup", b =>
                {
                    b.Property<int>("JewelryGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PieceID")
                        .HasColumnType("int");

                    b.Property<int>("SetID")
                        .HasColumnType("int");

                    b.HasKey("JewelryGroupID");

                    b.HasIndex("PieceID");

                    b.HasIndex("SetID");

                    b.ToTable("JewelryGroups");
                });

            modelBuilder.Entity("GRSCreativesDB.Models.Marketplace", b =>
                {
                    b.Property<int>("MarketplaceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MarketplaceDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarketplaceID");

                    b.ToTable("Marketplaces");

                    b.HasData(
                        new
                        {
                            MarketplaceID = 1,
                            MarketplaceDescription = "Tell Me A Charm"
                        },
                        new
                        {
                            MarketplaceID = 2,
                            MarketplaceDescription = "Amazon"
                        },
                        new
                        {
                            MarketplaceID = 3,
                            MarketplaceDescription = "WalMart"
                        });
                });

            modelBuilder.Entity("GRSCreativesDB.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("InventoryNumAmazon")
                        .HasColumnType("int");

                    b.Property<int>("InventoryNumWarehouse")
                        .HasColumnType("int");

                    b.Property<bool>("JewelryGroup")
                        .HasColumnType("bit");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RawMaterialID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("RawMaterialID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("GRSCreativesDB.Models.RawMaterial", b =>
                {
                    b.Property<int>("RawMaterialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("JewelryComponent")
                        .HasColumnType("bit");

                    b.Property<bool>("LocketSet")
                        .HasColumnType("bit");

                    b.Property<string>("RawMaterialDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RawMaterialTypeID")
                        .HasColumnType("int");

                    b.HasKey("RawMaterialID");

                    b.HasIndex("RawMaterialTypeID");

                    b.ToTable("RawMaterials");

                    b.HasData(
                        new
                        {
                            RawMaterialID = 100,
                            JewelryComponent = false,
                            LocketSet = false,
                            RawMaterialDescription = "Locket",
                            RawMaterialTypeID = 1
                        },
                        new
                        {
                            RawMaterialID = 101,
                            JewelryComponent = false,
                            LocketSet = false,
                            RawMaterialDescription = "Charm",
                            RawMaterialTypeID = 1
                        },
                        new
                        {
                            RawMaterialID = 102,
                            JewelryComponent = false,
                            LocketSet = false,
                            RawMaterialDescription = "Plate",
                            RawMaterialTypeID = 1
                        },
                        new
                        {
                            RawMaterialID = 103,
                            JewelryComponent = false,
                            LocketSet = false,
                            RawMaterialDescription = "Chain",
                            RawMaterialTypeID = 1
                        },
                        new
                        {
                            RawMaterialID = 200,
                            JewelryComponent = false,
                            LocketSet = false,
                            RawMaterialDescription = "Locket Set",
                            RawMaterialTypeID = 2
                        },
                        new
                        {
                            RawMaterialID = 201,
                            JewelryComponent = false,
                            LocketSet = false,
                            RawMaterialDescription = "Earrings",
                            RawMaterialTypeID = 2
                        },
                        new
                        {
                            RawMaterialID = 202,
                            JewelryComponent = false,
                            LocketSet = false,
                            RawMaterialDescription = "Necklace",
                            RawMaterialTypeID = 2
                        },
                        new
                        {
                            RawMaterialID = 203,
                            JewelryComponent = false,
                            LocketSet = false,
                            RawMaterialDescription = "Bracelet",
                            RawMaterialTypeID = 2
                        },
                        new
                        {
                            RawMaterialID = 204,
                            JewelryComponent = false,
                            LocketSet = false,
                            RawMaterialDescription = "Charm Set",
                            RawMaterialTypeID = 2
                        },
                        new
                        {
                            RawMaterialID = 205,
                            JewelryComponent = false,
                            LocketSet = false,
                            RawMaterialDescription = "Necklace Plus Charm",
                            RawMaterialTypeID = 2
                        });
                });

            modelBuilder.Entity("GRSCreativesDB.Models.RawMaterialType", b =>
                {
                    b.Property<int>("RawMaterialTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("RawMaterialDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RawMaterialTypeID");

                    b.ToTable("RawMaterialTypes");

                    b.HasData(
                        new
                        {
                            RawMaterialTypeID = 1,
                            RawMaterialDescription = "Raw Material"
                        },
                        new
                        {
                            RawMaterialTypeID = 2,
                            RawMaterialDescription = "Finished Good"
                        });
                });

            modelBuilder.Entity("GRSCreativesDB.Models.AliasSKU", b =>
                {
                    b.HasOne("GRSCreativesDB.Models.Marketplace", "Marketplace")
                        .WithMany("AliasSKUs")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("ForeignKey_AliasSKU_Marketplace")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GRSCreativesDB.Models.Product", "Product")
                        .WithMany("AliasSKUs")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("ForeignKey_AliasSKU_Product")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Marketplace");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GRSCreativesDB.Models.JewelryGroup", b =>
                {
                    b.HasOne("GRSCreativesDB.Models.Product", "Piece")
                        .WithMany("Pieces")
                        .HasForeignKey("PieceID")
                        .HasConstraintName("ForeignKey_JewelryGroup_Product_Pieces")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GRSCreativesDB.Models.Product", "Set")
                        .WithMany("Sets")
                        .HasForeignKey("SetID")
                        .HasConstraintName("ForeignKey_JewelryGroup_Product_Sets")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Piece");

                    b.Navigation("Set");
                });

            modelBuilder.Entity("GRSCreativesDB.Models.Product", b =>
                {
                    b.HasOne("GRSCreativesDB.Models.RawMaterial", "RawMaterial")
                        .WithMany("Products")
                        .HasForeignKey("RawMaterialID")
                        .HasConstraintName("ForeignKey_Product_RawMaterial")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("RawMaterial");
                });

            modelBuilder.Entity("GRSCreativesDB.Models.RawMaterial", b =>
                {
                    b.HasOne("GRSCreativesDB.Models.RawMaterialType", "RawMaterialType")
                        .WithMany("RawMaterials")
                        .HasForeignKey("RawMaterialTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RawMaterialType");
                });

            modelBuilder.Entity("GRSCreativesDB.Models.Marketplace", b =>
                {
                    b.Navigation("AliasSKUs");
                });

            modelBuilder.Entity("GRSCreativesDB.Models.Product", b =>
                {
                    b.Navigation("AliasSKUs");

                    b.Navigation("Pieces");

                    b.Navigation("Sets");
                });

            modelBuilder.Entity("GRSCreativesDB.Models.RawMaterial", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("GRSCreativesDB.Models.RawMaterialType", b =>
                {
                    b.Navigation("RawMaterials");
                });
#pragma warning restore 612, 618
        }
    }
}
