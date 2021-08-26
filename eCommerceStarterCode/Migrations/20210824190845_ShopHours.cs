using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class ShopHours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53466a79-b366-486b-8e04-735e2dad25b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ee6f339-8f97-4c02-96ff-03a1f7d75e05");

            migrationBuilder.RenameColumn(
                name: "Open",
                table: "ShopHours",
                newName: "WedOpen");

            migrationBuilder.RenameColumn(
                name: "Day",
                table: "ShopHours",
                newName: "WedClose");

            migrationBuilder.RenameColumn(
                name: "Close",
                table: "ShopHours",
                newName: "TuesOpen");

            migrationBuilder.AddColumn<int>(
                name: "FriClose",
                table: "ShopHours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FriOpen",
                table: "ShopHours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MonClose",
                table: "ShopHours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MonOpen",
                table: "ShopHours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SatClose",
                table: "ShopHours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SatOpen",
                table: "ShopHours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SunClose",
                table: "ShopHours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SunOpen",
                table: "ShopHours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ThursClose",
                table: "ShopHours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ThursOpen",
                table: "ShopHours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TuesClose",
                table: "ShopHours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd797835-f6d0-4f1d-a843-894cb527969e", "93b91f7a-cd91-4f71-aad4-1b76cb71ecf7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41544d1a-d10e-4283-af68-c0ba1dc3e49a", "23b75a5f-84c3-41e0-9895-ca804af79872", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41544d1a-d10e-4283-af68-c0ba1dc3e49a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd797835-f6d0-4f1d-a843-894cb527969e");

            migrationBuilder.DropColumn(
                name: "FriClose",
                table: "ShopHours");

            migrationBuilder.DropColumn(
                name: "FriOpen",
                table: "ShopHours");

            migrationBuilder.DropColumn(
                name: "MonClose",
                table: "ShopHours");

            migrationBuilder.DropColumn(
                name: "MonOpen",
                table: "ShopHours");

            migrationBuilder.DropColumn(
                name: "SatClose",
                table: "ShopHours");

            migrationBuilder.DropColumn(
                name: "SatOpen",
                table: "ShopHours");

            migrationBuilder.DropColumn(
                name: "SunClose",
                table: "ShopHours");

            migrationBuilder.DropColumn(
                name: "SunOpen",
                table: "ShopHours");

            migrationBuilder.DropColumn(
                name: "ThursClose",
                table: "ShopHours");

            migrationBuilder.DropColumn(
                name: "ThursOpen",
                table: "ShopHours");

            migrationBuilder.DropColumn(
                name: "TuesClose",
                table: "ShopHours");

            migrationBuilder.RenameColumn(
                name: "WedOpen",
                table: "ShopHours",
                newName: "Open");

            migrationBuilder.RenameColumn(
                name: "WedClose",
                table: "ShopHours",
                newName: "Day");

            migrationBuilder.RenameColumn(
                name: "TuesOpen",
                table: "ShopHours",
                newName: "Close");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ee6f339-8f97-4c02-96ff-03a1f7d75e05", "fea09c23-4bea-4653-ab58-8427429347de", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53466a79-b366-486b-8e04-735e2dad25b4", "839878c4-6626-42b9-b69b-f7c5d37dc3c7", "Admin", "ADMIN" });
        }
    }
}
