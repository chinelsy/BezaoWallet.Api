using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BezaoWallet.Api.Migrations
{
    public partial class UpdatedBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0188fd88-af60-4736-9f3a-48a31c42f574");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d03aed58-20a0-4c29-9e97-dbbdf346c638");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccountBalance",
                table: "Transactions",
                type: "decimal(38,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 21, 6, 44, 46, 184, DateTimeKind.Local).AddTicks(9798), new DateTime(2021, 12, 21, 6, 44, 46, 185, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9793df17-378d-46e3-b76c-f38310e07fae", "68a1e100-4c57-47cc-97d6-b088e56f6f33", "Administrator", "ADMINISTRATOR" },
                    { "4180e881-eb28-4c47-acef-33c2b1150f92", "209a3745-17ce-4a6e-81bd-0ef127e07e30", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 21, 6, 44, 46, 194, DateTimeKind.Local).AddTicks(8837), new DateTime(2021, 12, 21, 6, 44, 46, 194, DateTimeKind.Local).AddTicks(8936) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4180e881-eb28-4c47-acef-33c2b1150f92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9793df17-378d-46e3-b76c-f38310e07fae");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccountBalance",
                table: "Transactions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38,2)");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 21, 6, 38, 37, 457, DateTimeKind.Local).AddTicks(3531), new DateTime(2021, 12, 21, 6, 38, 37, 457, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d03aed58-20a0-4c29-9e97-dbbdf346c638", "5c56b63e-d524-40f7-8b6f-e8604eeb2b0f", "Administrator", "ADMINISTRATOR" },
                    { "0188fd88-af60-4736-9f3a-48a31c42f574", "f6876bcb-254c-43d6-a09f-dbe0327399fd", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 21, 6, 38, 37, 465, DateTimeKind.Local).AddTicks(8751), new DateTime(2021, 12, 21, 6, 38, 37, 465, DateTimeKind.Local).AddTicks(8860) });
        }
    }
}
