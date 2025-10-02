using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallinnaRakenduslikKolledz.Migrations
{
    /// <inheritdoc />
    public partial class DeliquentModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deliquents",
                columns: table => new
                {
                    DeliquentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Violation = table.Column<int>(type: "int", nullable: false),
                    DeliquentType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliquents", x => x.DeliquentID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliquents");
        }
    }
}
