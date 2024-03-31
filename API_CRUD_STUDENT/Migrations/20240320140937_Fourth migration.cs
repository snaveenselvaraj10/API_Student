using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_CRUD_STUDENT.Migrations
{
    /// <inheritdoc />
    public partial class Fourthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Student",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Student",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "EmailId",
                table: "Student",
                newName: "emailId");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Student",
                newName: "department");

            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "Student",
                newName: "dob");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Student",
                newName: "studentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Student",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Student",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "emailId",
                table: "Student",
                newName: "EmailId");

            migrationBuilder.RenameColumn(
                name: "dob",
                table: "Student",
                newName: "DOB");

            migrationBuilder.RenameColumn(
                name: "department",
                table: "Student",
                newName: "Department");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "Student",
                newName: "StudentId");
        }
    }
}
