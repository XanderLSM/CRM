using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Server.Migrations
{
    /// <inheritdoc />
    public partial class BookingDateInChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2685416b-9974-4393-b0bb-94a4a0ad1404", "AQAAAAIAAYagAAAAEJItHIwxKNi+aJ7bxF8qQfZUxqtzkbdBN8hnqu2PdMIlWBaXaLfqqL47CkQgY3O94Q==", "6613dbd8-f714-40bb-9447-e3ea45df25d2" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5407), new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5421), new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5739), new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5742), new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5933), new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5935), new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5937), new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5938), new DateTime(2024, 2, 11, 15, 8, 28, 260, DateTimeKind.Local).AddTicks(5939) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0e84281-7afc-4a28-b882-dcf242d5733a", "AQAAAAIAAYagAAAAECJ4OgDQdsJEvTBL+3B/mR6h93EaxDGLEdzzhCsQqqCm3e61aXBPKJZNmmE9MexYUA==", "c1a87d75-4cd9-4b99-afac-24b69883d120" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7376), new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7392), new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7724), new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7726), new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7925), new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7928), new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7929), new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7931), new DateTime(2024, 2, 10, 20, 51, 43, 821, DateTimeKind.Local).AddTicks(7932) });
        }
    }
}
