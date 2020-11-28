using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSCreativesDB.Migrations
{
    public partial class seededMarketplaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Marketplaces",
                columns: new[] { "MarketplaceID", "MarketplaceDescription" },
                values: new object[] { 1, "Amazon" });

            migrationBuilder.InsertData(
                table: "Marketplaces",
                columns: new[] { "MarketplaceID", "MarketplaceDescription" },
                values: new object[] { 2, "WalMart" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marketplaces",
                keyColumn: "MarketplaceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marketplaces",
                keyColumn: "MarketplaceID",
                keyValue: 2);
        }
    }
}
