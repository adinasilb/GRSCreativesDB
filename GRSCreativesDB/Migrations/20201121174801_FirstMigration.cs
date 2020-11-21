using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSCreativesDB.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marketplaces",
                columns: table => new
                {
                    MarketplaceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketplaceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marketplaces", x => x.MarketplaceID);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterialTypes",
                columns: table => new
                {
                    RawMaterialTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RawMaterialDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterialTypes", x => x.RawMaterialTypeID);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                columns: table => new
                {
                    RawMaterialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RawMaterialDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RawMaterialTypeID = table.Column<int>(type: "int", nullable: false),
                    JewelryComponent = table.Column<bool>(type: "bit", nullable: false),
                    LocketSet = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterials", x => x.RawMaterialID);
                    table.ForeignKey(
                        name: "FK_RawMaterials_RawMaterialTypes_RawMaterialTypeID",
                        column: x => x.RawMaterialTypeID,
                        principalTable: "RawMaterialTypes",
                        principalColumn: "RawMaterialTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InventoryNumWarehouse = table.Column<int>(type: "int", nullable: false),
                    InventoryNumAmazon = table.Column<int>(type: "int", nullable: false),
                    JewelryGroup = table.Column<bool>(type: "bit", nullable: false),
                    RawMaterialID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "ForeignKey_Product_RawMaterial",
                        column: x => x.RawMaterialID,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AliasSKUs",
                columns: table => new
                {
                    AliasSKUID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ChildSKU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    MarketplaceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AliasSKUs", x => x.AliasSKUID);
                    table.ForeignKey(
                        name: "ForeignKey_AliasSKU_Marketplace",
                        column: x => x.ProductID,
                        principalTable: "Marketplaces",
                        principalColumn: "MarketplaceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ForeignKey_AliasSKU_Product",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JewelryGroups",
                columns: table => new
                {
                    JewelryGroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SetID = table.Column<int>(type: "int", nullable: false),
                    PieceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JewelryGroups", x => x.JewelryGroupID);
                    table.ForeignKey(
                        name: "ForeignKey_JewelryGroup_Product_Pieces",
                        column: x => x.PieceID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ForeignKey_JewelryGroup_Product_Sets",
                        column: x => x.SetID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AliasSKUs_ProductID",
                table: "AliasSKUs",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_JewelryGroups_PieceID",
                table: "JewelryGroups",
                column: "PieceID");

            migrationBuilder.CreateIndex(
                name: "IX_JewelryGroups_SetID",
                table: "JewelryGroups",
                column: "SetID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_RawMaterialID",
                table: "Products",
                column: "RawMaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_RawMaterialTypeID",
                table: "RawMaterials",
                column: "RawMaterialTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AliasSKUs");

            migrationBuilder.DropTable(
                name: "JewelryGroups");

            migrationBuilder.DropTable(
                name: "Marketplaces");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropTable(
                name: "RawMaterialTypes");
        }
    }
}
