using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRM.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedData4Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb07e0d5-f6f6-49b2-8b03-bc04f8d7f77b", "AQAAAAIAAYagAAAAEMI22GVeH0DeY+n5xjiPQfcY9/0iYBUemihLztlQWgue8mdej7CRF96hhq6PuM964Q==", "71ff82e0-a07d-4016-996f-1d48c15ae6b5" });

            migrationBuilder.InsertData(
                table: "Blogcategorys",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 11, 20, 21, 38, 222, DateTimeKind.Local).AddTicks(1566), new DateTime(2024, 2, 11, 20, 21, 38, 222, DateTimeKind.Local).AddTicks(1582), "Tips N Tricks", "System" },
                    { 2, "System", new DateTime(2024, 2, 11, 20, 21, 38, 222, DateTimeKind.Local).AddTicks(1585), new DateTime(2024, 2, 11, 20, 21, 38, 222, DateTimeKind.Local).AddTicks(1585), "Finance", "System" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(8505), new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(8517), new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(8820), new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(8822), new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(9026), new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(9028), new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(9029), new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(9032), new DateTime(2024, 2, 11, 20, 21, 38, 172, DateTimeKind.Local).AddTicks(9032) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogcategorys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogcategorys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63bc0239-be42-4ffd-8e44-c0a07b877a0a", "AQAAAAIAAYagAAAAEO0uZQ2IK8V97o1Di5PYND/6ooNr7MQSb4YF4RJ46etogmYbScyjrBQxLs7myoXhww==", "7400ed0d-2693-4e66-8915-2af4393abd05" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(5576), new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(5590), new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(5938), new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(5941), new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(6198), new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(6202), new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(6204), new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(6206), new DateTime(2024, 2, 11, 20, 16, 13, 530, DateTimeKind.Local).AddTicks(6207) });
        }
    }
}
