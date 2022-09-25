using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PaymentIntentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ac767f8-93e5-4457-9197-5c93ace06bbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54cf415a-9645-4bfa-b31a-a65265b84c05");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09d36188-d557-4e86-b193-625039ec79e9", "16f4137f-eb7e-4776-8f80-ed8947961a31", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b28b1b8b-1b0f-49e7-8f5c-d738c6966d40", "a00cba7e-df19-4502-8e7c-bfed4ee411c7", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09d36188-d557-4e86-b193-625039ec79e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b28b1b8b-1b0f-49e7-8f5c-d738c6966d40");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ac767f8-93e5-4457-9197-5c93ace06bbb", "fe52845a-a074-45c6-9c6f-bf8739df48d9", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54cf415a-9645-4bfa-b31a-a65265b84c05", "c1a1c115-8ba9-4995-a7f8-449d8773d48c", "Instructor", "INSTRUCTOR" });
        }
    }
}
