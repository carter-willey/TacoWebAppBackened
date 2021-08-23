using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class userregistration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b19c46e4-2e71-4f40-8598-fa7c4398565d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6ba6afe-7ece-4ce4-9812-cc7e03e210e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "725f9245-24f3-439b-b1a1-f2dadafe3b4f", "af746fc8-b402-48d2-811f-2c93e3fd87b6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d47811d2-e5df-4d4a-b2b6-6fcb7973d358", "b13a3cef-5cfd-4ba4-9a96-617dc303645b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "725f9245-24f3-439b-b1a1-f2dadafe3b4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d47811d2-e5df-4d4a-b2b6-6fcb7973d358");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6ba6afe-7ece-4ce4-9812-cc7e03e210e2", "47f19147-469d-4fd8-9b64-e22d4fb3c99f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b19c46e4-2e71-4f40-8598-fa7c4398565d", "aef1e33e-55b6-4023-b76a-b134912340ef", "Admin", "ADMIN" });
        }
    }
}
