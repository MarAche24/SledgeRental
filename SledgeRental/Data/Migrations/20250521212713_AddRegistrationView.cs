using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SledgeRental.Migrations
{
    /// <inheritdoc />
    public partial class AddRegistrationView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS RegistrationInfo_View;");

            migrationBuilder.Sql("""
                CREATE VIEW RegistrationInfo_View AS
                    SELECT Reservations.Id AS ReservationId, Reservations.Date AS ReservationDate, StartTime, EndTime, Sledges.SledgeNumber, CONCAT(AspNetUsers.FirstName, ' ', AspNetUsers.LastName) AS CustomerName, SledgeKinds.Name AS SledgeKind FROM Reservations
                        JOIN AspNetUsers ON Reservations.CustomerId = AspNetUsers.Id
                        JOIN Sledges ON Reservations.SledgeId = Sledges.Id
                        JOIN SledgeKinds ON Sledges.SledgeKindId = SledgeKinds.Id
                """);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS RegistrationInfo_View;");
        }
    }
}
