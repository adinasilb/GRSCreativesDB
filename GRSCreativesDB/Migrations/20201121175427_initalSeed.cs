using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSCreativesDB.Migrations
{
    public partial class initalSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RawMaterialTypes",
                columns: new[] { "RawMaterialTypeID", "RawMaterialDescription" },
                values: new object[] { 1, "Raw Material" });

            migrationBuilder.InsertData(
                table: "RawMaterialTypes",
                columns: new[] { "RawMaterialTypeID", "RawMaterialDescription" },
                values: new object[] { 2, "Finished Good" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RawMaterialTypes",
                keyColumn: "RawMaterialTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RawMaterialTypes",
                keyColumn: "RawMaterialTypeID",
                keyValue: 2);
        }
    }
}
