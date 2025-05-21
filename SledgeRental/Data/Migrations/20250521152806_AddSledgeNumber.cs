using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SledgeRental.Migrations
{
    /// <inheritdoc />
    public partial class AddSledgeNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SledgeNumber",
                table: "Sledges",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SledgeNumber",
                table: "Sledges");
        }
    }
}
