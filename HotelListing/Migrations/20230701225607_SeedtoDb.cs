using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Migrations
{
    /// <inheritdoc />
    public partial class SeedtoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Name", "ShortName" },
                values: new object[] { 1, "United States", "US" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 1, "sdasdasd", 1, "HotelCalifornia", 4.2999999999999998 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1);
        }
    }
}
