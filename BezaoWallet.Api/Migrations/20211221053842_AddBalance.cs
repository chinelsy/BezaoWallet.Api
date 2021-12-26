using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BezaoWallet.Api.Migrations
{
    public partial class AddBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45df0085-2c6f-44b9-98ff-fa9372bbe46e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d46b614-89c3-4773-a217-1be0cb40e2bd");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccountBalance",
                table: "Transactions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0188fd88-af60-4736-9f3a-48a31c42f574");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d03aed58-20a0-4c29-9e97-dbbdf346c638");

            migrationBuilder.AlterColumn<string>(
                name: "AccountBalance",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 19, 22, 44, 57, 102, DateTimeKind.Local).AddTicks(7135), new DateTime(2021, 12, 19, 22, 44, 57, 102, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45df0085-2c6f-44b9-98ff-fa9372bbe46e", "a807bd93-fec8-4480-9105-2d4912efbee9", "Administrator", "ADMINISTRATOR" },
                    { "7d46b614-89c3-4773-a217-1be0cb40e2bd", "532f5a83-3116-49ff-8c44-163d6ed183ac", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 12, 19, 22, 44, 57, 113, DateTimeKind.Local).AddTicks(2381), new DateTime(2021, 12, 19, 22, 44, 57, 113, DateTimeKind.Local).AddTicks(2511) });
        }
    }
}
