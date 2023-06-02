using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_computer_table_4 : Migration
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
                    DeviceProcessingTime = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    ComputerId = table.Column<int>(type: "int", nullable: false),
                    ComputerSerialNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerYearOfProduction = table.Column<int>(type: "int", nullable: false),
                    OperatingSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ram = table.Column<int>(type: "int", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.ComputerId);
                    table.ForeignKey(
                        name: "FK_Computers_Personals_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Personals",
                        principalColumn: "PersonalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computers_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Computers_ServiceId",
                table: "Computers",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Personals");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
