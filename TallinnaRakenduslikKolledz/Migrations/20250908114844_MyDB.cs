using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallinnaRakenduslikKolledz.Migrations
{
    /// <inheritdoc />
    public partial class MyDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_StudentID",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Student_StudentID",
                table: "Tracks");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Tracks",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_StudentID",
                table: "Tracks",
                newName: "IX_Tracks_StudentId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Student",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Enrollment",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_StudentID",
                table: "Enrollment",
                newName: "IX_Enrollment_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Student_StudentId",
                table: "Enrollment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Student_StudentId",
                table: "Tracks",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_StudentId",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Student_StudentId",
                table: "Tracks");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Tracks",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_StudentId",
                table: "Tracks",
                newName: "IX_Tracks_StudentID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Student",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Enrollment",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_StudentId",
                table: "Enrollment",
                newName: "IX_Enrollment_StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Student_StudentID",
                table: "Enrollment",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Student_StudentID",
                table: "Tracks",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID");
        }
    }
}
