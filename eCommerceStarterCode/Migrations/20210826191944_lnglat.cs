using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class lnglat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f6f6a91-9c1a-4094-adaf-f98505ac1e89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "156047ba-045f-4368-864c-6be5a5bccb31");

            migrationBuilder.AddColumn<decimal>(
                name: "Lat",
                table: "Shops",
                type: "decimal(10,8)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Lng",
                table: "Shops",
                type: "decimal(11,8)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "389e2ab2-b77a-4a97-a05c-04d2f54746ed", "edc01cb5-2184-4455-b026-df61f62b284a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4d1a45f-d728-40e3-86ff-a4057b44f59f", "d25caffa-f877-4a3d-9268-74819c2ca749", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "389e2ab2-b77a-4a97-a05c-04d2f54746ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4d1a45f-d728-40e3-86ff-a4057b44f59f");

            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "Lng",
                table: "Shops");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f6f6a91-9c1a-4094-adaf-f98505ac1e89", "381cbdd8-d1be-4b0c-a731-4ca8c9a2e8f8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "156047ba-045f-4368-864c-6be5a5bccb31", "b7418936-37e7-4ea5-99c5-30edace30515", "Admin", "ADMIN" });
        }
    }
}
