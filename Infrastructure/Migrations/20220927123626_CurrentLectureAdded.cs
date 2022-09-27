using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CurrentLectureAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e7fa438-7251-4b38-97f5-6f6473e2edd6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d22cb5ac-7bf6-45d6-97ec-dbd717046d10");

            migrationBuilder.AddColumn<int>(
                name: "CurrentLecture",
                table: "UserCourses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c26e12ff-fc72-4329-9fa4-d3230e9b8789", "5fa6d5fa-c600-4022-ba4c-4d1aba967dd4", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28334137-47a5-4522-aea3-3819173a89d9", "de6a5ef8-befe-419e-ac3b-8e1323d8ee01", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28334137-47a5-4522-aea3-3819173a89d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c26e12ff-fc72-4329-9fa4-d3230e9b8789");

            migrationBuilder.DropColumn(
                name: "CurrentLecture",
                table: "UserCourses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e7fa438-7251-4b38-97f5-6f6473e2edd6", "34910d7f-6573-49db-9cbc-3e0f2570e1f5", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d22cb5ac-7bf6-45d6-97ec-dbd717046d10", "fd2db3e5-c764-40aa-a9a2-2cd17523a29a", "Instructor", "INSTRUCTOR" });
        }
    }
}
