using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_2.Migrations
{
    /// <inheritdoc />
    public partial class AddqualifactionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => new { x.EmployeeId, x.Name });
                    table.ForeignKey(
                        name: "FK_Qualifications_Empolyees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Empolyees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Qualifications");
        }
    }
}
