using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedBlogcomments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogcomments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogpostId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogcomments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogcomments_Blogposts_BlogpostId",
                        column: x => x.BlogpostId,
                        principalTable: "Blogposts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Blogcomments_BlogpostId",
                table: "Blogcomments",
                column: "BlogpostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogcomments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb07e0d5-f6f6-49b2-8b03-bc04f8d7f77b", "AQAAAAIAAYagAAAAEMI22GVeH0DeY+n5xjiPQfcY9/0iYBUemihLztlQWgue8mdej7CRF96hhq6PuM964Q==", "71ff82e0-a07d-4016-996f-1d48c15ae6b5" });

            migrationBuilder.UpdateData(
                table: "Blogcategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 21, 38, 222, DateTimeKind.Local).AddTicks(1566), new DateTime(2024, 2, 11, 20, 21, 38, 222, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Blogcategorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 11, 20, 21, 38, 222, DateTimeKind.Local).AddTicks(1585), new DateTime(2024, 2, 11, 20, 21, 38, 222, DateTimeKind.Local).AddTicks(1585) });

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
    }
}
