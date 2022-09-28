using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class publishedPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28334137-47a5-4522-aea3-3819173a89d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c26e12ff-fc72-4329-9fa4-d3230e9b8789");

            migrationBuilder.AddColumn<bool>(
                name: "Published",
                table: "Courses",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5bc24880-117c-457c-b00d-5e50b8e9fae2", "4663c80d-ee7f-4ab4-b140-cbe01cc8707c", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a7a2939-c1d7-4a5e-b2bb-781c9c37e533", "ec26b9c1-b7db-442e-a6b9-dd38c6fe00cc", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bc24880-117c-457c-b00d-5e50b8e9fae2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a7a2939-c1d7-4a5e-b2bb-781c9c37e533");

            migrationBuilder.DropColumn(
                name: "Published",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c26e12ff-fc72-4329-9fa4-d3230e9b8789", "5fa6d5fa-c600-4022-ba4c-4d1aba967dd4", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28334137-47a5-4522-aea3-3819173a89d9", "de6a5ef8-befe-419e-ac3b-8e1323d8ee01", "Instructor", "INSTRUCTOR" });
        }
    }
}
