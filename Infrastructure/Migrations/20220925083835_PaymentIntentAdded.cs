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

            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "Basket",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentIntentId",
                table: "Basket",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e101a16-cb8b-4dd3-94f6-4372ca52fe26", "77ce9508-b46e-4bc7-bb04-71b02c81e7e7", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29657011-17cc-4fcb-b17c-ee90388a05d4", "c155c28d-c813-4695-beb3-2bc085379bea", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29657011-17cc-4fcb-b17c-ee90388a05d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e101a16-cb8b-4dd3-94f6-4372ca52fe26");

            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "Basket");

            migrationBuilder.DropColumn(
                name: "PaymentIntentId",
                table: "Basket");

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
