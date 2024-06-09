using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVlla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 10, 39, 12, 124, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 10, 39, 12, 124, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 10, 39, 12, 124, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 10, 39, 12, 124, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 10, 39, 12, 124, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 10, 39, 12, 124, DateTimeKind.Local).AddTicks(5014));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 10, 26, 11, 316, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 10, 26, 11, 316, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 10, 26, 11, 316, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 10, 26, 11, 316, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 10, 26, 11, 316, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 9, 10, 26, 11, 316, DateTimeKind.Local).AddTicks(770));
        }
    }
}
