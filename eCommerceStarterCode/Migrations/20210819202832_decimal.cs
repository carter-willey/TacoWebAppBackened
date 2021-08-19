using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class @decimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9356a4a-cc16-4ba6-a8f8-2fd1e4ae007f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f740b3fe-5199-4317-8d8c-816149d03c7f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a678d6b0-99f1-4fd7-ae11-93bc0f51da9e", "91064958-464f-4abf-aa5f-667e140b347f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4780f2b4-bb6b-47d9-9cdc-d7547c831ea2", "a0704c0c-2cf8-4ced-9c3d-25906f63a564", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4780f2b4-bb6b-47d9-9cdc-d7547c831ea2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a678d6b0-99f1-4fd7-ae11-93bc0f51da9e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9356a4a-cc16-4ba6-a8f8-2fd1e4ae007f", "9dcfcc45-7163-4279-a170-3603a92cf39d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f740b3fe-5199-4317-8d8c-816149d03c7f", "713827c5-7431-4bd8-8747-47f03ceab184", "Admin", "ADMIN" });
        }
    }
}
