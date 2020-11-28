using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSCreativesDB.Migrations
{
    public partial class seededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RawMaterials",
                columns: new[] { "RawMaterialID", "JewelryComponent", "LocketSet", "RawMaterialDescription", "RawMaterialTypeID" },
                values: new object[,]
                {
                    { 100, false, false, "Locket", 1 },
                    { 101, false, false, "Charm", 1 },
                    { 102, false, false, "Plate", 1 },
                    { 103, false, false, "Chain", 1 },
                    { 200, false, false, "Locket Set", 2 },
                    { 201, false, false, "Earrings", 2 },
                    { 202, false, false, "Necklace", 2 },
                    { 203, false, false, "Bracelet", 2 },
                    { 204, false, false, "Charm Set", 2 },
                    { 205, false, false, "Necklace Plus Charm", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: 205);
        }
    }
}
