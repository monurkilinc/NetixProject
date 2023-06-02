using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_personalıd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminContact = table.Column<int>(type: "int", nullable: false),
                    AdminImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    ComputerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerSerialNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerYearOfProduction = table.Column<int>(type: "int", nullable: false),
                    OperatingSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ram = table.Column<int>(type: "int", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicCard = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.ComputerId);
                });

            migrationBuilder.CreateTable(
                name: "Personals",
                columns: table => new
                {
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalAge = table.Column<int>(type: "int", nullable: false),
                    PersonalMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalCellPhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    ComputerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personals", x => x.PersonalId);
                    table.ForeignKey(
                        name: "FK_Personals_Computers_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computers",
                        principalColumn: "ComputerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicePriority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceWorker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServisStatus = table.Column<bool>(type: "bit", nullable: false),
                    ServiceDelayStatus = table.Column<bool>(type: "bit", nullable: false),
                    DeviceStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuaranteeStatus = table.Column<bool>(type: "bit", nullable: false),
                    DeviceServiceReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceChangingParts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceServiceHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceDateEntry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeviceDeliverEntry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeviceProcessingTime = table.Column<int>(type: "int", nullable: true),
                    ComputerId = table.Column<int>(type: "int", nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_Computers_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computers",
                        principalColumn: "ComputerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Services_Personals_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personals",
                        principalColumn: "PersonalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personals_ComputerId",
                table: "Personals",
                column: "ComputerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_ComputerId",
                table: "Services",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_PersonalId",
                table: "Services",
                column: "PersonalId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Personals");

            migrationBuilder.DropTable(
                name: "Computers");
        }
    }
}
