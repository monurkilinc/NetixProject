using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_299_spartans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceHistories_Services_ServiceId",
                table: "ServiceHistories");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceHistories_Services_ServiceId",
                table: "ServiceHistories",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceHistories_Services_ServiceId",
                table: "ServiceHistories");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceHistories_Services_ServiceId",
                table: "ServiceHistories",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
