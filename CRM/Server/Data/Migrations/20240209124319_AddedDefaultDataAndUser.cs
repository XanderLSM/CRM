using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRM.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c19de6c2-35a1-470f-9e0a-5cabf67d1afc", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEI1kWN7ZwKah05B1bhzKghOefGFO8OPxUsabUDDM6KNK+84chjLWSL9pXGHYBNylDA==", null, false, "7af591bb-49e8-4702-80e8-0f5be767ff5b", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9471), new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9483), "Black", "System" },
                    { 2, "System", new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9485), new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9486), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9791), new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9792), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9793), new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9794), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9979), new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9979), "3 Series", "System" },
                    { 2, "System", new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9980), new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9981), "X5", "System" },
                    { 3, "System", new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9983), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9984), new DateTime(2024, 2, 9, 20, 43, 19, 786, DateTimeKind.Local).AddTicks(9984), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
