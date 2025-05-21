using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SledgeRental.Migrations
{
    /// <inheritdoc />
    public partial class SledgekindDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SledgeKinds",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Einsitzer" },
                    { 2, "Zweisitzer" },
                    { 3, "Rennschlitten" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SledgeKinds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SledgeKinds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SledgeKinds",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
