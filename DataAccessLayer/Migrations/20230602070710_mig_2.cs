using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Services",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_PersonalId",
                table: "Services",
                column: "PersonalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Personals_PersonalId",
                table: "Services",
                column: "PersonalId",
                principalTable: "Personals",
                principalColumn: "PersonalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Personals_PersonalId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_PersonalId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Services");
        }
    }
}
