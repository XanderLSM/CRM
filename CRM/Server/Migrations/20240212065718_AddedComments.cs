using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c77f72c7-684f-4feb-ae6d-75938e601f8e", "AQAAAAIAAYagAAAAEKZKLbHbyaDKUKP+u0drnqvd9kj2EK72YnpTS0XF/153hg9igNj+yf38rvJGZzhE/w==", "8e9dbe10-41a5-47eb-bced-710cf3d4f135" });

            migrationBuilder.UpdateData(
                table: "Blogcategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 57, 18, 142, DateTimeKind.Local).AddTicks(1254), new DateTime(2024, 2, 12, 14, 57, 18, 142, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Blogcategorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 57, 18, 142, DateTimeKind.Local).AddTicks(1275), new DateTime(2024, 2, 12, 14, 57, 18, 142, DateTimeKind.Local).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(1700), new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(1715), new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(2033), new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(2036), new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(2219), new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(2221), new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(2223), new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 2, 12, 14, 57, 18, 93, DateTimeKind.Local).AddTicks(2224) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2af2b63f-995d-4bc2-b6fc-40d70572d0cf", "AQAAAAIAAYagAAAAEK1HK4t+7RHn1411+OxUtRuI4m9I70YQ7/WBW+wFX58gpcsFRMLEQgijFA2DvqyStg==", "92d8e22f-0229-4058-903c-df45252f7812" });

            migrationBuilder.UpdateData(
                table: "Blogcategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 28, 33, 947, DateTimeKind.Local).AddTicks(1870), new DateTime(2024, 2, 11, 20, 28, 33, 947, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Blogcategorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 28, 33, 947, DateTimeKind.Local).AddTicks(1887), new DateTime(2024, 2, 11, 20, 28, 33, 947, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(7629), new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(7652), new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(8053), new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(8056), new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(8381), new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(8383), new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(8386), new DateTime(2024, 2, 11, 20, 28, 33, 894, DateTimeKind.Local).AddTicks(8387) });
        }
    }
}
