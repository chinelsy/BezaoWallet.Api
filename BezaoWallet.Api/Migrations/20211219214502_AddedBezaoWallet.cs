using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BezaoWallet.Api.Migrations
{
    public partial class AddedBezaoWallet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12a4e4e8-6552-4018-b082-0c9fa9b54207");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b48b6053-1f09-4fb6-8923-9c42dde48025");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountType", "Balance", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy", "UserId", "WalletId" },
                values: new object[] { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 2, 1000000m, new DateTime(2021, 12, 19, 22, 44, 57, 102, DateTimeKind.Local).AddTicks(7135), null, true, new DateTime(2021, 12, 19, 22, 44, 57, 102, DateTimeKind.Local).AddTicks(8667), null, new Guid("1a986837-106b-4312-b045-8109166f457b"), "3071977856" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45df0085-2c6f-44b9-98ff-fa9372bbe46e", "a807bd93-fec8-4480-9105-2d4912efbee9", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d46b614-89c3-4773-a217-1be0cb40e2bd", "532f5a83-3116-49ff-8c44-163d6ed183ac", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AccountId", "Address", "CreatedAt", "CreatedBy", "DateOfBirth", "UpdatedAt", "UpdatedBy", "UserId", "UserId1" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "United State Of Abakpa", new DateTime(2021, 12, 19, 22, 44, 57, 113, DateTimeKind.Local).AddTicks(2381), null, new DateTime(1995, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 19, 22, 44, 57, 113, DateTimeKind.Local).AddTicks(2511), null, new Guid("1a986837-106b-4312-b045-8109166f457b"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45df0085-2c6f-44b9-98ff-fa9372bbe46e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d46b614-89c3-4773-a217-1be0cb40e2bd");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b48b6053-1f09-4fb6-8923-9c42dde48025", "ddb02fed-acba-4871-925b-9320886a39fc", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12a4e4e8-6552-4018-b082-0c9fa9b54207", "68058b3f-8711-492c-8163-901b274a6304", "Customer", "CUSTOMER" });
        }
    }
}
