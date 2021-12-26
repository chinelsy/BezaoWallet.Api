using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BezaoWallet.Api.Migrations
{
    public partial class AddedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Accounts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b48b6053-1f09-4fb6-8923-9c42dde48025", "ddb02fed-acba-4871-925b-9320886a39fc", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12a4e4e8-6552-4018-b082-0c9fa9b54207", "68058b3f-8711-492c-8163-901b274a6304", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12a4e4e8-6552-4018-b082-0c9fa9b54207");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b48b6053-1f09-4fb6-8923-9c42dde48025");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
