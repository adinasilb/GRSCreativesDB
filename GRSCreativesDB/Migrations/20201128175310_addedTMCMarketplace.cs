using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSCreativesDB.Migrations
{
    public partial class addedTMCMarketplace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Marketplaces",
                keyColumn: "MarketplaceID",
                keyValue: 1,
                column: "MarketplaceDescription",
                value: "Tell Me A Charm");

            migrationBuilder.UpdateData(
                table: "Marketplaces",
                keyColumn: "MarketplaceID",
                keyValue: 2,
                column: "MarketplaceDescription",
                value: "Amazon");

            migrationBuilder.InsertData(
                table: "Marketplaces",
                columns: new[] { "MarketplaceID", "MarketplaceDescription" },
                values: new object[] { 3, "WalMart" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marketplaces",
                keyColumn: "MarketplaceID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Marketplaces",
                keyColumn: "MarketplaceID",
                keyValue: 1,
                column: "MarketplaceDescription",
                value: "Amazon");

            migrationBuilder.UpdateData(
                table: "Marketplaces",
                keyColumn: "MarketplaceID",
                keyValue: 2,
                column: "MarketplaceDescription",
                value: "WalMart");
        }
    }
}
