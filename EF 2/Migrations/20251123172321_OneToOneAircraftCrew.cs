using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_2.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneAircraftCrew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssistPilot",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Host1",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Host2",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MajPilot",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssistPilot",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "Host1",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "Host2",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "MajPilot",
                table: "Aircrafts");
        }
    }
}
